using learn.net.Model;
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
    public partial class frmSinhVien : Form
    {
    

        public frmSinhVien()
        {
            InitializeComponent();
            NapDanhSachLopHoc();
        }
        void NapDanhSachLopHoc()
        {
            var list = LopHocViewModel.GetList();
            cbbLop.DataSource = list;
            cbbLop.DisplayMember = "TenLop";
        }
        public LopHocViewModel selectedLopHoc
        {
            get
            {
                return cbbLop.SelectedItem as LopHocViewModel; 
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SRMSinhVien_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Kiem tra xem ID Ma Sinh vien co trung khong 
            // Ten , Ma Sinh Vien khong duoc trong
            var sinhvien = new SinhVien
            {
                Ten = txtHoVaTen.Text,
                QueQuan = txtQueQuan.Text , 
                NgaySinh = dtbNgaySinh.Value , 
                MaSinhVien =txtMaSinhVien.Text , 
                GioiTinh = (rbNam.Checked?0: rbNu.Checked?1:2),
                IDLopHoc = selectedLopHoc.ID
              

            };
            if (SinhVienViewModel.AddSinhVien(sinhvien) == KetQua.ThanhCong )
            {
                DialogResult = DialogResult.OK; 
            }
            else
            {
                MessageBox.Show("Ma Sinh Vien trung", "Thong bao");
                txtMaSinhVien.Focus(); 
            }
        
         

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtHoVaTen_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
