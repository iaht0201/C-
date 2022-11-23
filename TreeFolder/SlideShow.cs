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
    public partial class frmSlideShow : Form
    {
        private bool isRandom { get; set; } 
        private ListView lwThuMuc;
        public frmSlideShow(ListView lwThuMuc)
        {
            InitializeComponent();
            this.lwThuMuc = lwThuMuc;
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        static int count = 0;
       
        private void timer1_Tick(object sender, EventArgs e)
        {
          
           if(isRandom == true )
            {
                if(count >= lwThuMuc.Items.Count)
                {
                    return; 
                }
              
                pbSlide.ImageLocation = lwThuMuc.Items[count].SubItems[1].Text;
                count++;
                
            }
           else
            {
              
                if (count < lwThuMuc.Items.Count)
                {
                 
                    pbSlide.ImageLocation = lwThuMuc.Items[count].SubItems[1].Text;
                    count++;
                }
                else
                {
                    count = 0;
                }
            }
        }

        private void frmSlideShow_Load(object sender, EventArgs e)
        {

        }

        private void càiĐặtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frnCaiDat fr= new frnCaiDat();
            var rs = fr.ShowDialog();
            if (rs == DialogResult.OK)
            {
                timer1.Interval = fr.ThoiGian;
                isRandom = fr.isRandom;
                MessageBox.Show($"Random {fr.isRandom}");
            }
        }
    }
}
