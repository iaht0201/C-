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
    public partial class frmLopHoc : Form
    {
        LopHocViewModel lopHoc;
        public frmLopHoc()
        {
            InitializeComponent();
            NapDanhSachLopHoc();

           
            
        }
       
        private void Form2_Load(object sender, EventArgs e)
        {
           
        }
        void NapDanhSachLopHoc()
        {
            var ls = LopHocService.GetList();
            bdsLopHoc.DataSource = ls;
            gridLopHoc.DataSource = bdsLopHoc;
        }
        public LopHocViewModel selectedLopHoc
        {
            get
            {
                return bdsLopHoc.Current as LopHocViewModel;
            }
        }
        void NapTenLop()
        {


            if (selectedLopHoc != null)
            {
                var tenLop = LopHocService.GetTenLopHoc(selectedLopHoc.ID);
                txtTenLopHoc.Text = tenLop;
               /* gridSinhVien.DataSource = bdsSinhVien;*/
            }

        }

      
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         

          

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
          if(String.IsNullOrEmpty(txtTenLopHoc.Text))
            {
                MessageBox.Show("Tên lớp không được trống", "Thong bao");
                txtTenLopHoc.Focus();
                

            }
          else
            {
                var lh = new LopHoc
                {
                    TenLop = txtTenLopHoc.Text,

                };
                if (LopHocService.AddLopHocs(lh) == KetQua.ThanhCong)
                {
                    NapDanhSachLopHoc();
                    MessageBox.Show("Đã theem lớp", "Thong bao");
                   


                }

                else
                {
                    MessageBox.Show("Ten lop trung", "Thong bao");
                    txtTenLopHoc.Focus();
                }

            
            }
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (selectedLopHoc != null)
            {
                var rs = MessageBox.Show("Bạn có chắc muốn xóa", "Chu y", MessageBoxButtons.OKCancel);
                if (rs == DialogResult.OK)
                {
                  
                    if (LopHocService.RemoveLopHoc(selectedLopHoc) == KetQua.TrungMa)
                    {
                        MessageBox.Show("Lớp này hiện tồn tại sinh viên không thể xóa !");

                    }
                    else
                    {
                        NapDanhSachLopHoc();
                    }
            
                }
            }
        }

        private void txtTenLopHoc_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLuaChon_Click(object sender, EventArgs e)
        {  
            txtTenLopHoc.Clear() ;
            txtTenLopHoc.SelectedText = selectedLopHoc.TenLop;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            selectedLopHoc.TenLop = txtTenLopHoc.Text;
          
             

            if (String.IsNullOrEmpty(txtTenLopHoc.Text))
            {
                MessageBox.Show("Tên lớp không được trống", "Thong bao");
                txtTenLopHoc.Focus();


            }
            else if (LopHocService.UpdateLopHoc(selectedLopHoc) == KetQua.TrungMa)
            {
                MessageBox.Show("Lớp này đã tồn tại!");
                txtTenLopHoc.Focus();

            }
            else
            {
                
                NapDanhSachLopHoc(); 
            }
        }

        private void btnHoanTat_Click(object sender, EventArgs e)
        {
            /*DialogResult = DialogResult.OK;*/
            DialogResult = DialogResult.OK;
        }
    }
}
