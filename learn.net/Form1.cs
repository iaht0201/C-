using learn.net.Services;
using learn.net.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace learn.net
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            NapDsLopHoc();
        }
        public LopHocViewModel selectedLopHoc
        {
            get
            {
                return cbLopHoc.SelectedItem as LopHocViewModel;
            }
        }
        public SinhVienViewModel selectedSinhVien
        {
            get
            {
                return bdsSinhVien.Current as SinhVienViewModel;
            }
        }
        void NapDsLopHoc()
        {
            var ls = LopHocService.GetList();
            cbLopHoc.DataSource = ls;
       /*     cbLopHoc.ValueMember = "ID"; */
            cbLopHoc.DisplayMember = "TenLop";

        }
        void NapDsSinhVien()
        {


            if (selectedLopHoc != null)
            {
                var ls = SinhVienService.GetList(selectedLopHoc.ID);
                bdsSinhVien.DataSource = ls;
                gridSinhVien.DataSource = bdsSinhVien;
            }

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbLopHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            NapDsSinhVien();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var f = new frmSinhVien();
            var rs = f.ShowDialog();
            if (rs == DialogResult.OK)
            {
                NapDsSinhVien();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(selectedSinhVien != null)
            {
                var f = new frmSinhVien(selectedSinhVien); 
                if(f.ShowDialog() == DialogResult.OK)
                {
                    NapDsSinhVien();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
          if(selectedSinhVien !=null)
            {
               var rs = MessageBox.Show("Ban co chac muon xoa", "Chu y", MessageBoxButtons.OKCancel);
                if (rs == DialogResult.OK)
                {
                    /*   if (SinhVienViewModel.DeleteSinhVien(selectedSinhVien.MaSinhVien) == KetQua.ThanhCong)
                       {
                           MessageBox.Show($"Đã xóa thành công {selectedSinhVien.Ten}");
                           NapDsSinhVien();

                       }
                       else
                       {
                           MessageBox.Show("Lỗi rồi");
                       }*/

                    SinhVienService.RemoveSinhVien(selectedSinhVien);
                    NapDsSinhVien(); 

                }
            }

           
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStrip2_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click_2(object sender, EventArgs e)
        {
           var f = new frmLopHoc();
            var rs = f.ShowDialog();
            if (rs == DialogResult.OK)
            {
                NapDsLopHoc();
            } 
        } 
    }
}
