using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SimPendu
{
    public partial class frmPendu : Form
    {
        frmData dWin;
        double pTime, mTime;
        double pDeg, pBar, pMass, pFri, pGrev = 3, pVel, pAcc;
        private double peakT = -1; // 마지막으로 최고점에 도달했을 때의 시간
        private bool changeDirec = true; // 진자의 이동 방향을 추적
        private bool isStabilizing = false; // 중력 안정화 상태를 추적
        private long lastStableTime; // 중력 안정화가 끝난 후의 시간을 기록
        private long pauseTime; // 중력 안정화 시간 동안 경과된 시간을 저장
        private bool initialStart = true; // 진자 운동이 처음 시작되었는지를 추적
        private double initialTime = 0; // 초기 시간을 저장하는 변수
        private List<double> periods = new List<double>();
        private bool periodMeasured = false;
        public frmPendu()
        {
            InitializeComponent();
            DoubleBuffered = true;
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(Image));
            osBall.Size = new Size(75, 75);
            this.MouseWheel += MainForm_MouseWheel;
        }

        private void frmPendu_Load(object sender, EventArgs e)
        {
            drawPendu(120, 45);
            dWin = new frmData();
            dWin.Show();
            dWin.Location = new Point(this.Location.X + this.Width, this.Location.Y);
            btReset.PerformClick();
            DoubleBuffered = true;
        }

        private void drawPendu(double bar, double deg)
        {
            double rad = deg * Math.PI / 180;
            int ball = (int)pMass; // 여기서 double -> int 변환
            int xo = rsCeiling.Location.X + rsCeiling.Width / 2;
            int yo = rsCeiling.Location.Y + rsCeiling.Height;

            lsBar.StartPoint = new Point(xo, yo);
            xo += (int)(bar * Math.Sin(rad)); // 여기서 double -> int 변환
            yo += (int)(bar * Math.Cos(rad)); // 여기서 double -> int 변환
            lsBar.EndPoint = new Point(xo, yo);
            xo -= ball / 2;
            yo -= ball / 2;
            osBall.Width = osBall.Height = ball;
            osBall.Location = new Point(xo, yo);
            osBall.BringToFront();
            panel1.SendToBack();
            panel1.Refresh();
        }

        ///** 트랙바, 텍스트 연동, 값 바꿀 때 잠시 멈춤**//
        long transGrevT, transFriT, transBarT, transDegT, transMassT;

        private void sbBar_Scroll(object sender, EventArgs e)
        {
            double deg = pDeg; // 현재 각도를 유지
            pBar = Convert.ToDouble(sbBar.Value);
            tbBar.Text = Convert.ToString(sbBar.Value);
            drawPendu(pBar, deg); // 새로운 길이와 현재 각도로 진자를 다시 그림

            transBarT = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            if (!initialStart)
            {
                isStabilizing = true;
                lastStableTime = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            }
            ResetPeriodMeasurement();
            periodMeasured = false;
        }

        private void tbBar_TextChanged(object sender, EventArgs e)
        {
            double deg = pDeg; // 현재 각도를 유지
            sbBar.Value = Convert.ToInt32(tbBar.Text);
            pBar = Convert.ToDouble(tbBar.Text);
            drawPendu(pBar, deg); // 새로운 길이와 현재 각도로 진자를 다시 그림

            transBarT = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            if (!initialStart)
            {
                isStabilizing = true;
                lastStableTime = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            }

            firstPeriodSkipped = false;
            ResetPeriodMeasurement();
            periodMeasured = false;
        }

        private void tbDeg_TextChanged(object sender, EventArgs e)
        {
            double bar = pBar; // 현재 길이를 유지
            sbDeg.Value = Convert.ToInt32(tbDeg.Text);
            pDeg = Convert.ToDouble(tbDeg.Text);
            drawPendu(bar, pDeg); // 새로운 각도와 현재 길이로 진자를 다시 그림

            transDegT = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            if (!initialStart)
            {
                isStabilizing = true;
                lastStableTime = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            }


            firstPeriodSkipped = false;
            periodMeasured = false;
            ResetPeriodMeasurement();
        }

        private void sbDeg_Scroll(object sender, EventArgs e)
        {
            double bar = pBar; // 현재 길이를 유지
            pDeg = Convert.ToDouble(sbDeg.Value);
            tbDeg.Text = Convert.ToString(sbDeg.Value);
            drawPendu(bar, pDeg); // 새로운 각도와 현재 길이로 진자를 다시 그림

            transDegT = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            if (!initialStart)
            {
                isStabilizing = true;
                lastStableTime = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            }

            ResetPeriodMeasurement();
            periodMeasured = false;
        }

        private void sbMass_Scroll(object sender, EventArgs e)
        {
            double deg = pDeg; // 현재 각도를 유지
            pMass = Convert.ToDouble(sbMass.Value);
            tbMass.Text = Convert.ToString(sbMass.Value);
            drawPendu(pBar, deg); // 새로운 무게와 현재 각도로 진자를 다시 그림

            transMassT = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            if (!initialStart)
            {
                isStabilizing = true;
                lastStableTime = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            }
            ResetPeriodMeasurement();
            periodMeasured = false;
        }

        private void tbMass_TextChanged(object sender, EventArgs e)
        {
            double deg = pDeg; // 현재 각도를 유지
            sbMass.Value = Convert.ToInt32(tbMass.Text);
            pMass = Convert.ToDouble(tbMass.Text);
            drawPendu(pBar, deg); // 새로운 무게와 현재 각도로 진자를 다시 그림

            transMassT = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            if (!initialStart)
            {
                isStabilizing = true;
                lastStableTime = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            }
            ResetPeriodMeasurement();
            periodMeasured = false;
        }

        private void sbFri_Scroll(object sender, EventArgs e)
        {
            double deg = pDeg; // 현재 각도를 유지
            pFri = sbFri.Value * 0.1;
            tbFri.Text = pFri.ToString("0.0");
            drawPendu(pBar, deg); // 새로운 마찰력과 현재 각도로 진자를 다시 그림

            transFriT = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            if (!initialStart)
            {
                isStabilizing = true;
                lastStableTime = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            }
            ResetPeriodMeasurement();
            periodMeasured = false;
        }

        private void tbFri_TextChanged(object sender, EventArgs e)
        {
            double deg = pDeg; // 현재 각도를 유지
            double tbValue;
            if (double.TryParse(tbFri.Text, out tbValue))
            {
                sbFri.Value = Convert.ToInt32(tbValue * 10);
                pFri = tbValue;
                drawPendu(pBar, deg); // 새로운 마찰력과 현재 각도로 진자를 다시 그림

                transFriT = DateTimeOffset.Now.ToUnixTimeMilliseconds();
                if (!initialStart)
                {
                    isStabilizing = true;
                    lastStableTime = DateTimeOffset.Now.ToUnixTimeMilliseconds();
                }
                ResetPeriodMeasurement();
            }
            periodMeasured = false;
            firstPeriodSkipped = false;
        }

        private void sbGrev_Scroll(object sender, EventArgs e)
        {
            tbGrev.Text = Convert.ToString(sbGrev.Value);
            ResetPeriodMeasurement();
            periodMeasured = false;
        }

        private void tbGrev_TextChanged(object sender, EventArgs e)
        {
            sbGrev.Value = (int)Convert.ToDouble(tbGrev.Text);
            transGrevT = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            firstPeriodSkipped = false;
            drawPendu(pBar, pDeg);
            ResetPeriodMeasurement();
            periodMeasured = false;
        }

        private bool mDown = false;

        private void frmPendu_MouseDown(object sender, MouseEventArgs e)
        {
            mDown = true;
        }

        private void frmPendu_MouseUp(object sender, MouseEventArgs e)
        {
            mDown = false;
        }

        int mass;

        private void MainForm_MouseWheel(object sender, MouseEventArgs e)
        {
            mass = sbMass.Value;

            if (e.Delta > 0)
            {
                osBall.Width = osBall.Height = mass;
                sbMass.Value++;
                tbMass.Text = Convert.ToString(sbMass.Value);
            }
            else
            {
                osBall.Width = osBall.Height = mass;
                sbMass.Value--;
                tbMass.Text = Convert.ToString(sbMass.Value);
            }

            if (!initialStart)
            {
                isStabilizing = true;
                lastStableTime = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            }
        }

        private void frmPendu_MouseMove(object sender, MouseEventArgs e)
        {
            int xo = rsCeiling.Location.X + rsCeiling.Width / 2;
            int yo = rsCeiling.Location.Y + rsCeiling.Height;
            double x = e.Location.X - xo;
            double y = e.Location.Y - yo;
            double a = Math.Pow(x, 2); // a=x^2
            double b = Math.Pow(y, 2); // b=y^2
            double c = a + b;
            if (mDown)
            {
                double newDeg = Math.Atan2(x, y) * 180 / Math.PI;
                double bar = Math.Sqrt(c);

                if (newDeg > 90)
                {
                    newDeg = 90;
                }
                if (newDeg < -90)
                {
                    newDeg = -90;
                }
                if (bar < 50)
                {
                    bar = 50;
                }
                if (bar > 300)
                {
                    bar = 300;
                }

                // 각도의 부호가 변경되었는지 확인
                if ((newDeg > 0 && pDeg < 0) || (newDeg < 0 && pDeg > 0))
                {
                    // 각도의 부호가 변경되면 속도와 가속도의 부호를 반전
                    pVel = -pVel;
                    pAcc = -pAcc;
                }

                // 현재 각도를 업데이트
                pDeg = newDeg;

                sbDeg.Value = (int)newDeg;
                tbDeg.Text = newDeg.ToString("0");
                sbBar.Value = (int)bar;
                tbBar.Text = bar.ToString("0");

                drawPendu(bar, newDeg);
            }
        }

        ///////////******************체크박스, 폼 열고닫기(투명도)*************////////////
        private void btData_Click(object sender, EventArgs e)
        {
            if (dWin.Opacity == 0)
            {
                dWin.Opacity = 100;
            }
            else
            {
                dWin.Opacity = 0;
            }
        }

        private void cbMars_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMars.Checked)
            {
                cbMoon.Checked = false;
                cbEarth.Checked = false;
                osBall.BackgroundImage = Properties.Resources.화성1;
            }
            else
            {
                osBall.BackgroundImage = Properties.Resources.쇠구슬;
            }
        }

        private void cbMoon_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMoon.Checked)
            {
                cbMars.Checked = false;
                cbEarth.Checked = false;
                osBall.BackgroundImage = Properties.Resources.달;
            }
            else
            {
                osBall.BackgroundImage = Properties.Resources.쇠구슬;
            }
        }

        private void cbEarth_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEarth.Checked)
            {
                cbMoon.Checked = false;
                cbMars.Checked = false;
                osBall.BackgroundImage = Properties.Resources.지구;
            }
            else
            {
                osBall.BackgroundImage = Properties.Resources.쇠구슬;
            }
        }

        private void ResetPeriodMeasurement()
        {
            peakT = -1;
            changeDirec = true;
            periods.Clear();
            lbVT.Text = "0.000";
            firstPeriodSkipped = false;
        }

        private long stopT, laststopT = 0;
        private bool isPaused = false;
        /////////////////********************//////////////////
        private void btStart_Click(object sender, EventArgs e)
        {
            if (btStart.Text == "Stop")
            {
                btStart.Text = "Start";
                timer1.Enabled = false;
                stopT = DateTimeOffset.Now.ToUnixTimeMilliseconds(); // 일시 정지 시간 저장
                isPaused = true; // 일시 정지 상태 설정
            }
            else
            {
                if (pTime == 0)
                {
                    btStart.Text = "Stop";
                    btReset.Text = "Reset"; // 추가된 부분
                    pTime = 0;
                    mTime = DateTimeOffset.Now.ToUnixTimeMilliseconds();
                    initialTime = mTime; // 초기 시간을 설정
                    timer1.Enabled = true;
                    pBar = Convert.ToDouble(tbBar.Text);
                    pDeg = Convert.ToDouble(tbDeg.Text);
                    pMass = Convert.ToDouble(tbMass.Text);
                    pFri = Convert.ToDouble(tbFri.Text);
                    pGrev = Convert.ToDouble(tbGrev.Text);
                    pVel = 0;
                    initialStart = false; // 초기 시작이 끝났음을 표시
                }
                else
                {
                    laststopT = DateTimeOffset.Now.ToUnixTimeMilliseconds() - stopT; // 일시 정지 후 경과한 시간 계산
                    btStart.Text = "Stop";
                    timer1.Enabled = true;
                    mTime += laststopT; // 경과한 시간을 기존 시간에 추가
                    if (isPaused)
                    {
                        initialTime += laststopT; // 경과한 시간을 초기 시간에 추가하여 보정
                        isPaused = false; // 일시 정지 상태 해제
                    }
                }
            }
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            if (btReset.Text == "Reset")
            {
                btStart.Text = "Start"; // 추가된 부분
                btReset.Text = "Set";
                timer1.Enabled = false;
            }

            pBar = Convert.ToDouble(tbBar.Text);
            pDeg = Convert.ToDouble(tbDeg.Text);
            pMass = Convert.ToDouble(tbMass.Text);
            pFri = Convert.ToDouble(tbFri.Text); 
            pGrev = Convert.ToDouble(tbGrev.Text);
            pVel = 0;
            pAcc = 0; // 가속도 초기화 추가

            // 주기 측정 변수 초기화
            peakT = -1;
            changeDirec = true;
            initialTime = 0;
            periodMeasured = false;
            firstPeriodSkipped = false;

            if (dWin != null)
            {
                dWin.ClearData();
            }
            drawPendu(pBar, pDeg);

            lbMsec.Text = Convert.ToString(0);
            lbVvel.Text = Convert.ToString(0);
            lbVacc.Text = Convert.ToString(0);
            lbVT.Text = Convert.ToString(0);
            lbVdeg.Text = Convert.ToString(0);
            lbTER.Text = Convert.ToString(0); //
            pTime = 0;

            chtAcc.Series[0].Points.Clear();
            chtDeg.Series[0].Points.Clear();
            chtVel.Series[0].Points.Clear();
            chtPot.Series[0].Points.Clear();
            chtKin.Series[0].Points.Clear();
            periodMeasured = false;

        }


        private bool firstPeriodSkipped = false; // 첫 번째 주기를 건너뛰기 위한 플래그
        private long stabilizedTimeOffset = 0; // 안정화 시간 동안 멈춘 시간을 저장

        private void timer1_Tick(object sender, EventArgs e)
        {
            long curT = DateTimeOffset.Now.ToUnixTimeMilliseconds() - stabilizedTimeOffset; // 안정화 시간 보정 적용

            double grevstableT = (curT + stabilizedTimeOffset - transGrevT) / 1000.0; // 중력 안정화 대기 시간 (초 단위)
            double barStableT = (curT + stabilizedTimeOffset - transBarT) / 1000.0;
            double massStableT = (curT + stabilizedTimeOffset - transMassT) / 1000.0;
            double friStableT = (curT + stabilizedTimeOffset - transFriT) / 1000.0;
            double degStableT = (curT + stabilizedTimeOffset - transDegT) / 1000.0;

            // 초기 시작이면 안정화 시간을 무시
            if (!initialStart && (grevstableT < 1.5 || barStableT < 1.5 || massStableT < 1.5 || friStableT < 1.5 || degStableT < 1.5))
            {
                if (!isStabilizing)
                {
                    // 안정화가 시작될 때 시간을 저장
                    isStabilizing = true;
                    lastStableTime = DateTimeOffset.Now.ToUnixTimeMilliseconds();
                }
                return;
            }

            // 안정화 기간이 끝난 후, pTime 업데이트 재개
            if (!initialStart && isStabilizing)
            {
                isStabilizing = false;
                long currentTime = DateTimeOffset.Now.ToUnixTimeMilliseconds();
                stabilizedTimeOffset += currentTime - lastStableTime; // 멈춘 시간을 보정 시간에 추가
            }

            // 기존의 물리 계산 및 주기 측정 로직을 계속 실행
            lbMsec.Text = ((double)(curT - initialTime) / 1000).ToString("0.000");
            lbTER.Text = (Math.Abs(pTime - (double)(curT - mTime) / 1000) / (curT - mTime) * 100.0).ToString("00.00" + "%"); //



            double ddf = pAcc, df = pVel;
            double rad = pDeg * Math.PI / 180;
            double dt = 0.0000001;
            double mass = pMass;
            double bar = pBar / 100;
            double fric = pFri * dt;
            double grev = pGrev;
            


            if (cbEarth.Checked == true)
            {
                grev = 9.8;
                tbGrev.Text = Convert.ToString(9.8);
            }
            else if (cbMoon.Checked == true)
            {
                grev = 1.62;
                tbGrev.Text = Convert.ToString(1.62);
            }
            else if (cbMars.Checked == true)
            {
                grev = 3.71;
                tbGrev.Text = Convert.ToString(3.71);
            }
            else
            {
                grev = Convert.ToDouble(tbGrev.Text);
            }
            for (int i = 0; i < 500000; i++)
            {
                ddf = -grev / bar * Math.Sin(rad) - fric / (mass * bar) * df;
                rad = rad + df * dt;
                df = df + ddf * dt - fric * df;
            }

            pTime += dt * 475000;
            pDeg = rad * 180 / Math.PI;
            pVel = df;
            pAcc = ddf;

            drawPendu(pBar, pDeg);
            dWin.tbData.AppendText(pTime.ToString("0.000") + "," + pDeg.ToString("0.0") + ","
                + pVel.ToString("0.00") + Environment.NewLine);

            lbVdeg.Text = pDeg.ToString("0.0");
            lbVvel.Text = pVel.ToString("0.00");
            lbVacc.Text = pAcc.ToString("0.00");

            // 주기 측정 로직
            if (!periodMeasured && df <= 0 && changeDirec)
            {
                if (peakT > 0)
                {
                    double period = (curT - peakT) / 1000.0;
                    if (firstPeriodSkipped)
                    {
                        lbVT.Text = Math.Round(period, 2).ToString("0.00");
                        periodMeasured = true; // 주기값이 출력되었음을 표시
                    }
                    else
                    {
                        firstPeriodSkipped = true;
                    }
                }
                peakT = curT;
                changeDirec = false;
            }
            else if (df > 0 && !changeDirec)
            {
                changeDirec = true;
            }

            // 최대각도 |90도| 제한
            if (pDeg > 90)
            {
                pDeg = 90;
                pVel = -pVel; // 속도를 반전
            }
            if (pDeg < -90)
            {
                pDeg = -90;
                pVel = -pVel; // 속도를 반전
            }

            // 차트 y축 범위 자동화
            chtKin.ChartAreas[0].AxisY.IsStartedFromZero = false;
            chtKin.ChartAreas[0].AxisY.Minimum = double.NaN;
            chtKin.ChartAreas[0].AxisY.Maximum = double.NaN;
            chtKin.ChartAreas[0].AxisY.IntervalAutoMode = IntervalAutoMode.VariableCount;
            chtKin.ChartAreas[0].RecalculateAxesScale();

            chtPot.ChartAreas[0].AxisY.IsStartedFromZero = false;
            chtPot.ChartAreas[0].AxisY.Minimum = double.NaN;
            chtPot.ChartAreas[0].AxisY.Maximum = double.NaN;
            chtPot.ChartAreas[0].AxisY.IntervalAutoMode = IntervalAutoMode.VariableCount;
            chtPot.ChartAreas[0].RecalculateAxesScale();

            double v = Convert.ToSingle(lbVvel.Text);
            double h = bar * (1 - Math.Cos(rad));
            double kin = 0.5 * mass * v * v;
            double pot = mass * pGrev * h;
            chtDeg.Series[0].Points.AddXY(lbMsec.Text, pDeg);
            chtKin.Series[0].Points.AddXY(lbMsec.Text, kin);
            chtPot.Series[0].Points.AddXY(lbMsec.Text, pot);
            chtVel.Series[0].Points.AddXY(lbMsec.Text, df);
            chtAcc.Series[0].Points.AddXY(lbMsec.Text, ddf);
        }


    }
}
