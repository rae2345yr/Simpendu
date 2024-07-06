using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimPendu
{
    public partial class frmData : Form
    {
        public frmData()
        {
            InitializeComponent();
        }

        internal void ClearData()
        {
            tbData.Clear();  // textBoxData는 frmData 폼의 텍스트 박스 이름
        }

        private void frmData_Load(object sender, EventArgs e)
        {

        }
    }
}
