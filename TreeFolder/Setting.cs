using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeFolder
{
    public partial class frnCaiDat : Form
    {
        public bool isRandom = false;
        public int ThoiGian { get; set; }
        public frnCaiDat()
        {
            InitializeComponent();
        }

        private void rbNgauNhien_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void numTimer_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            ThoiGian = (int)numThoiGian.Value;
            if(rbLapLai.Checked == true)
            {
                isRandom = false; 
            }
            else
            {
                isRandom = true;
            }
            DialogResult = DialogResult.OK;
        }

        private void rbLapLai_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
