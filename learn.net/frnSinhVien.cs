using learn.net.Model;
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
    public partial class frmSinhVien : Form
    {
        SinhVienViewModel sinhVien;

        public frmSinhVien(SinhVienViewModel sinhVien = null)
        {
            InitializeComponent();
            NapDanhSachLopHoc();
            this.sinhVien = sinhVien;
            if (sinhVien != null)
            {
                cbbLop.SelectedValue = sinhVien.IDLopHoc;
                txtMaSinhVien.Text = sinhVien.MaSinhVien;
                txtHoVaTen.Text = sinhVien.Ten;
                dtbNgaySinh.Value = sinhVien.NgaySinh ?? DateTime.Now;
                if (sinhVien.GioiTinh == 0)
                {
                    rbNam.Checked = true;
                }
                else if (sinhVien.GioiTinh == 1)
                {
                    rbNu.Checked = true;
                }
                else
                {
                    rbKhac.Checked = true;
                }
                txtQueQuan.Text = sinhVien.QueQuan;


            }

        }
        void NapDanhSachLopHoc()
        {
            var list = LopHocService.GetList();
            cbbLop.DataSource = list;
            cbbLop.ValueMember = "ID";
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
            if (this.sinhVien == null)
            {
                var sv = new SinhVien
                {
                    Ten = txtHoVaTen.Text,
                    QueQuan = txtQueQuan.Text,
                    NgaySinh = dtbNgaySinh.Value,
                    MaSinhVien = txtMaSinhVien.Text,
                    GioiTinh = (rbNam.Checked ? 0 : rbNu.Checked ? 1 : 2),
                    IDLopHoc = selectedLopHoc.ID


                };
                if (SinhVienService.AddSinhVien(sv) == KetQua.ThanhCong)
                {
                    DialogResult = DialogResult.OK;
                }

                else
                {
                    MessageBox.Show("Ma Sinh Vien trung", "Thong bao");
                    txtMaSinhVien.Focus();
                }
            }
            // Caapj nhaapj thong tin
            else
            {
                sinhVien.QueQuan = txtQueQuan.Text;
                sinhVien.Ten = txtHoVaTen.Text;
                sinhVien.NgaySinh = dtbNgaySinh.Value;
                sinhVien.GioiTinh = (rbNam.Checked ? 0 : rbNu.Checked ? 1 : 2);
                sinhVien.MaSinhVien = txtMaSinhVien.Text;
                sinhVien.IDLopHoc = selectedLopHoc.ID;
                SinhVienService.UpdateSinhVien(sinhVien);
                DialogResult = DialogResult.OK;
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
