using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClockApp
{
    public partial class Form1 : Form
    {
       
     
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 100;
        }

        int count = 0;  

        private void timer1_Tick(object sender, EventArgs e)
        {
            count--;
            lblDongHo.Text = convert(count);
         
            if (count == 0)
                timer1.Stop();
            if(count < 10)
            {
                lblDongHo.ForeColor = Color.Red;
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (count > 0)
            {
                timer1.Start();
                btnStart.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                btnStart.Enabled = true; 
                timer1.Stop();
          

        }

        
        private void caiDatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmCaidat();
            var rs = f.ShowDialog();
            if(rs == DialogResult.OK)
            {
               
                count = f.SoPhut * 60;
                lblDongHo.Text = convert(f.SoPhut*60);
                
            }
        }
       
        string convert(int soGiay)
        {
            int p = soGiay / 60;
            int s = soGiay % 60;
            return $"{p:0#} : {s:0#} "; 
        }
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
