
using System;

namespace SimPendu
{
	partial class frmPendu
	{
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lsBar = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.osBall = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.rsCeiling = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbT = new System.Windows.Forms.Label();
            this.lbVT = new System.Windows.Forms.Label();
            this.lbVdeg = new System.Windows.Forms.Label();
            this.lbVvel = new System.Windows.Forms.Label();
            this.lbVacc = new System.Windows.Forms.Label();
            this.lbpDeg = new System.Windows.Forms.Label();
            this.lbVel = new System.Windows.Forms.Label();
            this.lbAcc = new System.Windows.Forms.Label();
            this.lboutput = new System.Windows.Forms.Label();
            this.lbSec = new System.Windows.Forms.Label();
            this.lbFri = new System.Windows.Forms.Label();
            this.lbGrav = new System.Windows.Forms.Label();
            this.lbMass = new System.Windows.Forms.Label();
            this.lbDeg = new System.Windows.Forms.Label();
            this.lbBar = new System.Windows.Forms.Label();
            this.sbFri = new System.Windows.Forms.TrackBar();
            this.sbGrev = new System.Windows.Forms.TrackBar();
            this.btReset = new System.Windows.Forms.Button();
            this.btStart = new System.Windows.Forms.Button();
            this.tbFri = new System.Windows.Forms.TextBox();
            this.tbGrev = new System.Windows.Forms.TextBox();
            this.cbMars = new System.Windows.Forms.CheckBox();
            this.cbMoon = new System.Windows.Forms.CheckBox();
            this.cbEarth = new System.Windows.Forms.CheckBox();
            this.lbMsec = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.sbMass = new System.Windows.Forms.TrackBar();
            this.tbMass = new System.Windows.Forms.TextBox();
            this.sbDeg = new System.Windows.Forms.TrackBar();
            this.sbBar = new System.Windows.Forms.TrackBar();
            this.tbDeg = new System.Windows.Forms.TextBox();
            this.tbBar = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbTER = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btData = new System.Windows.Forms.Button();
            this.chtDeg = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chtKin = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chtAcc = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chtPot = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chtVel = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sbFri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbGrev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbMass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbDeg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbBar)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtDeg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtKin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtAcc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtPot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtVel)).BeginInit();
            this.SuspendLayout();
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lsBar,
            this.osBall,
            this.rsCeiling});
            this.shapeContainer1.Size = new System.Drawing.Size(1080, 619);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // lsBar
            // 
            this.lsBar.BorderWidth = 3;
            this.lsBar.Name = "lsBar";
            this.lsBar.X1 = 199;
            this.lsBar.X2 = 197;
            this.lsBar.Y1 = 46;
            this.lsBar.Y2 = 123;
            // 
            // osBall
            // 
            this.osBall.BackgroundImage = global::SimPendu.Properties.Resources.쇠구슬;
            this.osBall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.osBall.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Central;
            this.osBall.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.osBall.Location = new System.Drawing.Point(172, 127);
            this.osBall.Name = "osBall";
            this.osBall.Size = new System.Drawing.Size(50, 50);
            // 
            // rsCeiling
            // 
            this.rsCeiling.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.ForwardDiagonal;
            this.rsCeiling.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.ForwardDiagonal;
            this.rsCeiling.Location = new System.Drawing.Point(57, 18);
            this.rsCeiling.Name = "rsCeiling";
            this.rsCeiling.Size = new System.Drawing.Size(352, 29);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.lbT);
            this.panel1.Controls.Add(this.lbVT);
            this.panel1.Controls.Add(this.lbVdeg);
            this.panel1.Controls.Add(this.lbVvel);
            this.panel1.Controls.Add(this.lbVacc);
            this.panel1.Controls.Add(this.lbpDeg);
            this.panel1.Controls.Add(this.lbVel);
            this.panel1.Controls.Add(this.lbAcc);
            this.panel1.Controls.Add(this.lboutput);
            this.panel1.Controls.Add(this.lbSec);
            this.panel1.Controls.Add(this.lbFri);
            this.panel1.Controls.Add(this.lbGrav);
            this.panel1.Controls.Add(this.lbMass);
            this.panel1.Controls.Add(this.lbDeg);
            this.panel1.Controls.Add(this.lbBar);
            this.panel1.Controls.Add(this.sbFri);
            this.panel1.Controls.Add(this.sbGrev);
            this.panel1.Controls.Add(this.btReset);
            this.panel1.Controls.Add(this.btStart);
            this.panel1.Controls.Add(this.tbFri);
            this.panel1.Controls.Add(this.tbGrev);
            this.panel1.Controls.Add(this.cbMars);
            this.panel1.Controls.Add(this.cbMoon);
            this.panel1.Controls.Add(this.cbEarth);
            this.panel1.Controls.Add(this.lbMsec);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.sbMass);
            this.panel1.Controls.Add(this.tbMass);
            this.panel1.Controls.Add(this.sbDeg);
            this.panel1.Controls.Add(this.sbBar);
            this.panel1.Controls.Add(this.tbDeg);
            this.panel1.Controls.Add(this.tbBar);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 332);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 283);
            this.panel1.TabIndex = 4;
            // 
            // lbT
            // 
            this.lbT.AutoSize = true;
            this.lbT.Location = new System.Drawing.Point(388, 222);
            this.lbT.Name = "lbT";
            this.lbT.Size = new System.Drawing.Size(59, 15);
            this.lbT.TabIndex = 38;
            this.lbT.Text = "주기[s]";
            // 
            // lbVT
            // 
            this.lbVT.AutoSize = true;
            this.lbVT.Location = new System.Drawing.Point(467, 222);
            this.lbVT.Name = "lbVT";
            this.lbVT.Size = new System.Drawing.Size(15, 15);
            this.lbVT.TabIndex = 37;
            this.lbVT.Text = "0";
            this.lbVT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbVdeg
            // 
            this.lbVdeg.AutoSize = true;
            this.lbVdeg.Location = new System.Drawing.Point(467, 109);
            this.lbVdeg.Name = "lbVdeg";
            this.lbVdeg.Size = new System.Drawing.Size(15, 15);
            this.lbVdeg.TabIndex = 36;
            this.lbVdeg.Text = "0";
            this.lbVdeg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbVvel
            // 
            this.lbVvel.AutoSize = true;
            this.lbVvel.Location = new System.Drawing.Point(467, 138);
            this.lbVvel.Name = "lbVvel";
            this.lbVvel.Size = new System.Drawing.Size(15, 15);
            this.lbVvel.TabIndex = 35;
            this.lbVvel.Text = "0";
            this.lbVvel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbVacc
            // 
            this.lbVacc.AutoSize = true;
            this.lbVacc.Location = new System.Drawing.Point(467, 168);
            this.lbVacc.Name = "lbVacc";
            this.lbVacc.Size = new System.Drawing.Size(15, 15);
            this.lbVacc.TabIndex = 34;
            this.lbVacc.Text = "0";
            this.lbVacc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbpDeg
            // 
            this.lbpDeg.AutoSize = true;
            this.lbpDeg.Location = new System.Drawing.Point(350, 109);
            this.lbpDeg.Name = "lbpDeg";
            this.lbpDeg.Size = new System.Drawing.Size(97, 15);
            this.lbpDeg.TabIndex = 33;
            this.lbpDeg.Text = "현재 각도[θ]";
            // 
            // lbVel
            // 
            this.lbVel.AutoSize = true;
            this.lbVel.Location = new System.Drawing.Point(371, 138);
            this.lbVel.Name = "lbVel";
            this.lbVel.Size = new System.Drawing.Size(76, 15);
            this.lbVel.TabIndex = 32;
            this.lbVel.Text = "속도[m/s]";
            // 
            // lbAcc
            // 
            this.lbAcc.AutoSize = true;
            this.lbAcc.Location = new System.Drawing.Point(352, 168);
            this.lbAcc.Name = "lbAcc";
            this.lbAcc.Size = new System.Drawing.Size(95, 15);
            this.lbAcc.TabIndex = 31;
            this.lbAcc.Text = "가속도[m/s²]";
            // 
            // lboutput
            // 
            this.lboutput.AutoSize = true;
            this.lboutput.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lboutput.Location = new System.Drawing.Point(403, 85);
            this.lboutput.Name = "lboutput";
            this.lboutput.Size = new System.Drawing.Size(39, 15);
            this.lboutput.TabIndex = 30;
            this.lboutput.Text = "출력";
            // 
            // lbSec
            // 
            this.lbSec.AutoSize = true;
            this.lbSec.Location = new System.Drawing.Point(403, 196);
            this.lbSec.Name = "lbSec";
            this.lbSec.Size = new System.Drawing.Size(44, 15);
            this.lbSec.TabIndex = 29;
            this.lbSec.Text = "초[s]";
            // 
            // lbFri
            // 
            this.lbFri.AutoSize = true;
            this.lbFri.Location = new System.Drawing.Point(200, 216);
            this.lbFri.Name = "lbFri";
            this.lbFri.Size = new System.Drawing.Size(75, 15);
            this.lbFri.TabIndex = 28;
            this.lbFri.Text = "마찰력[N]";
            // 
            // lbGrav
            // 
            this.lbGrav.AutoSize = true;
            this.lbGrav.Location = new System.Drawing.Point(200, 172);
            this.lbGrav.Name = "lbGrav";
            this.lbGrav.Size = new System.Drawing.Size(80, 15);
            this.lbGrav.TabIndex = 27;
            this.lbGrav.Text = "중력[m/s²]";
            // 
            // lbMass
            // 
            this.lbMass.AutoSize = true;
            this.lbMass.Location = new System.Drawing.Point(214, 126);
            this.lbMass.Name = "lbMass";
            this.lbMass.Size = new System.Drawing.Size(66, 15);
            this.lbMass.TabIndex = 26;
            this.lbMass.Text = "무게[kg]";
            // 
            // lbDeg
            // 
            this.lbDeg.AutoSize = true;
            this.lbDeg.Location = new System.Drawing.Point(218, 82);
            this.lbDeg.Name = "lbDeg";
            this.lbDeg.Size = new System.Drawing.Size(62, 15);
            this.lbDeg.TabIndex = 25;
            this.lbDeg.Text = "각도[θ]";
            // 
            // lbBar
            // 
            this.lbBar.AutoSize = true;
            this.lbBar.Location = new System.Drawing.Point(218, 37);
            this.lbBar.Name = "lbBar";
            this.lbBar.Size = new System.Drawing.Size(66, 15);
            this.lbBar.TabIndex = 24;
            this.lbBar.Text = "길이[㎝]";
            // 
            // sbFri
            // 
            this.sbFri.Location = new System.Drawing.Point(89, 205);
            this.sbFri.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sbFri.Name = "sbFri";
            this.sbFri.Size = new System.Drawing.Size(119, 56);
            this.sbFri.TabIndex = 23;
            this.sbFri.Scroll += new System.EventHandler(this.sbFri_Scroll);
            // 
            // sbGrev
            // 
            this.sbGrev.Location = new System.Drawing.Point(89, 158);
            this.sbGrev.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sbGrev.Maximum = 300;
            this.sbGrev.Minimum = 1;
            this.sbGrev.Name = "sbGrev";
            this.sbGrev.Size = new System.Drawing.Size(119, 56);
            this.sbGrev.TabIndex = 22;
            this.sbGrev.Value = 98;
            this.sbGrev.Scroll += new System.EventHandler(this.sbGrev_Scroll);
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(453, 45);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(85, 25);
            this.btReset.TabIndex = 21;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // btStart
            // 
            this.btStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btStart.Location = new System.Drawing.Point(453, 12);
            this.btStart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(85, 25);
            this.btStart.TabIndex = 20;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // tbFri
            // 
            this.tbFri.Location = new System.Drawing.Point(13, 213);
            this.tbFri.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbFri.Name = "tbFri";
            this.tbFri.Size = new System.Drawing.Size(73, 25);
            this.tbFri.TabIndex = 19;
            this.tbFri.Text = "0";
            this.tbFri.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbFri.TextChanged += new System.EventHandler(this.tbFri_TextChanged);
            // 
            // tbGrev
            // 
            this.tbGrev.Location = new System.Drawing.Point(13, 169);
            this.tbGrev.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbGrev.Name = "tbGrev";
            this.tbGrev.Size = new System.Drawing.Size(73, 25);
            this.tbGrev.TabIndex = 18;
            this.tbGrev.Text = "9.8";
            this.tbGrev.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbGrev.TextChanged += new System.EventHandler(this.tbGrev_TextChanged);
            // 
            // cbMars
            // 
            this.cbMars.AutoSize = true;
            this.cbMars.Location = new System.Drawing.Point(310, 32);
            this.cbMars.Name = "cbMars";
            this.cbMars.Size = new System.Drawing.Size(59, 19);
            this.cbMars.TabIndex = 16;
            this.cbMars.Text = "화성";
            this.cbMars.UseVisualStyleBackColor = true;
            this.cbMars.CheckedChanged += new System.EventHandler(this.cbMars_CheckedChanged);
            // 
            // cbMoon
            // 
            this.cbMoon.AutoSize = true;
            this.cbMoon.Location = new System.Drawing.Point(310, 57);
            this.cbMoon.Name = "cbMoon";
            this.cbMoon.Size = new System.Drawing.Size(44, 19);
            this.cbMoon.TabIndex = 15;
            this.cbMoon.Text = "달";
            this.cbMoon.UseVisualStyleBackColor = true;
            this.cbMoon.CheckedChanged += new System.EventHandler(this.cbMoon_CheckedChanged);
            // 
            // cbEarth
            // 
            this.cbEarth.AutoSize = true;
            this.cbEarth.Location = new System.Drawing.Point(310, 3);
            this.cbEarth.Name = "cbEarth";
            this.cbEarth.Size = new System.Drawing.Size(59, 19);
            this.cbEarth.TabIndex = 14;
            this.cbEarth.Text = "지구";
            this.cbEarth.UseVisualStyleBackColor = true;
            this.cbEarth.CheckedChanged += new System.EventHandler(this.cbEarth_CheckedChanged);
            // 
            // lbMsec
            // 
            this.lbMsec.AutoSize = true;
            this.lbMsec.Location = new System.Drawing.Point(467, 196);
            this.lbMsec.Name = "lbMsec";
            this.lbMsec.Size = new System.Drawing.Size(15, 15);
            this.lbMsec.TabIndex = 12;
            this.lbMsec.Text = "0";
            this.lbMsec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(103, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 11;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // sbMass
            // 
            this.sbMass.Location = new System.Drawing.Point(89, 115);
            this.sbMass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sbMass.Maximum = 100;
            this.sbMass.Minimum = 1;
            this.sbMass.Name = "sbMass";
            this.sbMass.Size = new System.Drawing.Size(119, 56);
            this.sbMass.TabIndex = 1;
            this.sbMass.Value = 30;
            this.sbMass.Scroll += new System.EventHandler(this.sbMass_Scroll);
            // 
            // tbMass
            // 
            this.tbMass.Location = new System.Drawing.Point(13, 126);
            this.tbMass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbMass.Name = "tbMass";
            this.tbMass.Size = new System.Drawing.Size(73, 25);
            this.tbMass.TabIndex = 9;
            this.tbMass.Text = "30";
            this.tbMass.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbMass.TextChanged += new System.EventHandler(this.tbMass_TextChanged);
            // 
            // sbDeg
            // 
            this.sbDeg.Location = new System.Drawing.Point(89, 73);
            this.sbDeg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sbDeg.Maximum = 90;
            this.sbDeg.Minimum = -90;
            this.sbDeg.Name = "sbDeg";
            this.sbDeg.Size = new System.Drawing.Size(119, 56);
            this.sbDeg.TabIndex = 8;
            this.sbDeg.Value = 45;
            this.sbDeg.Scroll += new System.EventHandler(this.sbDeg_Scroll);
            // 
            // sbBar
            // 
            this.sbBar.Location = new System.Drawing.Point(89, 23);
            this.sbBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sbBar.Maximum = 300;
            this.sbBar.Name = "sbBar";
            this.sbBar.Size = new System.Drawing.Size(119, 56);
            this.sbBar.TabIndex = 7;
            this.sbBar.Value = 120;
            this.sbBar.Scroll += new System.EventHandler(this.sbBar_Scroll);
            // 
            // tbDeg
            // 
            this.tbDeg.Location = new System.Drawing.Point(13, 82);
            this.tbDeg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbDeg.Name = "tbDeg";
            this.tbDeg.Size = new System.Drawing.Size(73, 25);
            this.tbDeg.TabIndex = 5;
            this.tbDeg.Text = "45";
            this.tbDeg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbDeg.TextChanged += new System.EventHandler(this.tbDeg_TextChanged);
            // 
            // tbBar
            // 
            this.tbBar.Location = new System.Drawing.Point(13, 34);
            this.tbBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbBar.Name = "tbBar";
            this.tbBar.Size = new System.Drawing.Size(73, 25);
            this.tbBar.TabIndex = 4;
            this.tbBar.Text = "120";
            this.tbBar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbBar.TextChanged += new System.EventHandler(this.tbBar_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lbTER);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(326, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(199, 193);
            this.panel2.TabIndex = 39;
            // 
            // lbTER
            // 
            this.lbTER.AutoSize = true;
            this.lbTER.Location = new System.Drawing.Point(140, 163);
            this.lbTER.Name = "lbTER";
            this.lbTER.Size = new System.Drawing.Size(15, 15);
            this.lbTER.TabIndex = 40;
            this.lbTER.Text = "0";
            this.lbTER.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "시간 오차율[%]";
            // 
            // timer1
            // 
            this.timer1.Interval = 33;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btData
            // 
            this.btData.Location = new System.Drawing.Point(492, 284);
            this.btData.Name = "btData";
            this.btData.Size = new System.Drawing.Size(58, 41);
            this.btData.TabIndex = 6;
            this.btData.Text = "Data\r\n";
            this.btData.UseVisualStyleBackColor = true;
            this.btData.Click += new System.EventHandler(this.btData_Click);
            // 
            // chtDeg
            // 
            this.chtDeg.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.BackwardDiagonal;
            chartArea1.IsSameFontSizeForAllAxes = true;
            chartArea1.Name = "ChartArea1";
            this.chtDeg.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.MaximumAutoSize = 15F;
            legend1.Name = "Legend1";
            this.chtDeg.Legends.Add(legend1);
            this.chtDeg.Location = new System.Drawing.Point(667, 3);
            this.chtDeg.Name = "chtDeg";
            this.chtDeg.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series1.Legend = "Legend1";
            series1.Name = "각도";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chtDeg.Series.Add(series1);
            this.chtDeg.Size = new System.Drawing.Size(300, 240);
            this.chtDeg.TabIndex = 7;
            this.chtDeg.Text = "chart1";
            // 
            // chtKin
            // 
            this.chtKin.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.chtKin.ChartAreas.Add(chartArea2);
            legend2.Alignment = System.Drawing.StringAlignment.Center;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.MaximumAutoSize = 20F;
            legend2.Name = "Legend1";
            this.chtKin.Legends.Add(legend2);
            this.chtKin.Location = new System.Drawing.Point(561, 422);
            this.chtKin.Name = "chtKin";
            this.chtKin.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series2.Legend = "Legend1";
            series2.Name = "운동에너지";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chtKin.Series.Add(series2);
            this.chtKin.Size = new System.Drawing.Size(250, 190);
            this.chtKin.TabIndex = 8;
            this.chtKin.Text = "chart1";
            this.chtKin.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.SystemDefault;
            // 
            // chtAcc
            // 
            this.chtAcc.BackColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartArea1";
            this.chtAcc.ChartAreas.Add(chartArea3);
            legend3.Alignment = System.Drawing.StringAlignment.Center;
            legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend3.MaximumAutoSize = 20F;
            legend3.Name = "Legend1";
            this.chtAcc.Legends.Add(legend3);
            this.chtAcc.Location = new System.Drawing.Point(818, 235);
            this.chtAcc.Name = "chtAcc";
            this.chtAcc.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.Firebrick;
            series3.Legend = "Legend1";
            series3.Name = "가속도";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series3.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chtAcc.Series.Add(series3);
            this.chtAcc.Size = new System.Drawing.Size(250, 190);
            this.chtAcc.TabIndex = 9;
            this.chtAcc.Text = "chart1";
            this.chtAcc.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.SystemDefault;
            // 
            // chtPot
            // 
            this.chtPot.BackColor = System.Drawing.Color.Transparent;
            chartArea4.Name = "ChartArea1";
            this.chtPot.ChartAreas.Add(chartArea4);
            legend4.Alignment = System.Drawing.StringAlignment.Center;
            legend4.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend4.MaximumAutoSize = 20F;
            legend4.Name = "Legend1";
            this.chtPot.Legends.Add(legend4);
            this.chtPot.Location = new System.Drawing.Point(818, 422);
            this.chtPot.Name = "chtPot";
            this.chtPot.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.Navy;
            series4.Legend = "Legend1";
            series4.Name = "위치에너지";
            series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series4.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chtPot.Series.Add(series4);
            this.chtPot.Size = new System.Drawing.Size(250, 190);
            this.chtPot.TabIndex = 10;
            this.chtPot.Text = "chart1";
            this.chtPot.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.SystemDefault;
            // 
            // chtVel
            // 
            this.chtVel.BackColor = System.Drawing.Color.Transparent;
            chartArea5.Name = "ChartArea1";
            this.chtVel.ChartAreas.Add(chartArea5);
            legend5.Alignment = System.Drawing.StringAlignment.Center;
            legend5.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend5.MaximumAutoSize = 20F;
            legend5.Name = "Legend1";
            this.chtVel.Legends.Add(legend5);
            this.chtVel.Location = new System.Drawing.Point(561, 235);
            this.chtVel.Name = "chtVel";
            this.chtVel.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Color = System.Drawing.Color.Olive;
            series5.Legend = "Legend1";
            series5.Name = "속도";
            series5.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series5.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chtVel.Series.Add(series5);
            this.chtVel.Size = new System.Drawing.Size(250, 190);
            this.chtVel.TabIndex = 11;
            this.chtVel.Text = "chart1";
            this.chtVel.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.SystemDefault;
            // 
            // frmPendu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1080, 619);
            this.Controls.Add(this.chtVel);
            this.Controls.Add(this.chtPot);
            this.Controls.Add(this.btData);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chtKin);
            this.Controls.Add(this.chtAcc);
            this.Controls.Add(this.chtDeg);
            this.Controls.Add(this.shapeContainer1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmPendu";
            this.Text = "SimPendu V5";
            this.Load += new System.EventHandler(this.frmPendu_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmPendu_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmPendu_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmPendu_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sbFri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbGrev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbMass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbDeg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbBar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtDeg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtKin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtAcc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtPot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtVel)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
		private Microsoft.VisualBasic.PowerPacks.RectangleShape rsCeiling;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TrackBar sbDeg;
		private System.Windows.Forms.TrackBar sbBar;
		private System.Windows.Forms.TextBox tbDeg;
		private System.Windows.Forms.TextBox tbBar;
		private Microsoft.VisualBasic.PowerPacks.OvalShape osBall;
		private Microsoft.VisualBasic.PowerPacks.LineShape lsBar;
		private System.Windows.Forms.TrackBar sbMass;
		private System.Windows.Forms.TextBox tbMass;
		private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbMsec;
        private System.Windows.Forms.CheckBox cbMars;
        private System.Windows.Forms.CheckBox cbMoon;
        private System.Windows.Forms.CheckBox cbEarth;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.TextBox tbFri;
        private System.Windows.Forms.TextBox tbGrev;
        private System.Windows.Forms.TrackBar sbFri;
        private System.Windows.Forms.TrackBar sbGrev;
        private System.Windows.Forms.Label lbVdeg;
        private System.Windows.Forms.Label lbVvel;
        private System.Windows.Forms.Label lbVacc;
        private System.Windows.Forms.Label lbpDeg;
        private System.Windows.Forms.Label lbVel;
        private System.Windows.Forms.Label lbAcc;
        private System.Windows.Forms.Label lboutput;
        private System.Windows.Forms.Label lbSec;
        private System.Windows.Forms.Label lbFri;
        private System.Windows.Forms.Label lbGrav;
        private System.Windows.Forms.Label lbMass;
        private System.Windows.Forms.Label lbDeg;
        private System.Windows.Forms.Label lbBar;
        private System.Windows.Forms.Label lbT;
        private System.Windows.Forms.Label lbVT;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btData;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtDeg;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtKin;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtAcc;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtPot;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtVel;
        private System.Windows.Forms.Label lbTER;
        private System.Windows.Forms.Label label1;
    }
}

