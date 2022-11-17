using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slider_Show
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
          /*  pictureBox.ImageLocation = @"..\Image\3.jpg";*/
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        int intNum = 0; 
        private void timer1_Tick(object sender, EventArgs e)
        {
            /*Slide();*/
          pbImage.Image = imageList1.Images[intNum];
            if(intNum == imageList1.Images.Count-1)
            {
                intNum = 0; 
            }
           else
            {
                intNum++;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pbImage_Click(object sender, EventArgs e)
        {

        }
    }
}
