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
    public partial class frmDetail : Form
    {
        public frmDetail( String path)
        {
            InitializeComponent();
            pbAnh.ImageLocation = path;
        }

        private void DetailsIamge_Load(object sender, EventArgs e)
        {

        }

        private void pbAnh_Click(object sender, EventArgs e)
        {

        }
    }
}
