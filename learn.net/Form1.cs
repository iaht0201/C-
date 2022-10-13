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
            var ls = LopHocViewModel.GetList();
            cbLopHoc.DataSource = ls;
            cbLopHoc.DisplayMember = "TenLop";

        }
        void NapDsSinhVien()
        {


            if (selectedLopHoc != null)
            {
                var ls = SinhVienViewModel.GetList(selectedLopHoc.ID);
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

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (SinhVienViewModel.DeleteSinhVien(selectedSinhVien.MaSinhVien) == KetQua.ThanhCong)
            {
                MessageBox.Show($"Đã xóa thành công {selectedSinhVien.Ten}");
                NapDsSinhVien();
             
            }
            else
            {
                MessageBox.Show("Lỗi rồi");
            }
        }


    }
}
