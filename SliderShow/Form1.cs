using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SliderShow
{
    public partial class Form1 : Form
    {
        private int ImageNumber = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Slider()
        {
            if(ImageNumber == 4)
            {
                ImageNumber = 1;
                pictureBox.ImageLocation = String.Format(@"Images\{0}.jpg",ImageNumber);
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Slider();
        }
    }
}
