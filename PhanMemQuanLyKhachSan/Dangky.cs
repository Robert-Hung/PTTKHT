using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhanMemQuanLyKhachSan.Model;

namespace PhanMemQuanLyKhachSan
{
    public partial class Dangky : Form
    {
        public Dangky()
        {
            InitializeComponent();
        }
        private void txtTendangnhap_Enter(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text == "Tên đăng nhập")
            {
                txtTenDangNhap.Text = "";
                txtTenDangNhap.ForeColor = Color.Black;
            }
        }

        private void txtTendangnhap_Leave(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text == "")
            {
                txtTenDangNhap.Text = "Tên đăng nhập";
                txtTenDangNhap.ForeColor = Color.Silver;
            }
        }

        private void txtMatkhau_Enter(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "Mật khẩu")
            {
                txtMatKhau.UseSystemPasswordChar = true;
                txtMatKhau.Text = "";
                txtMatKhau.ForeColor = Color.Black;
            }
        }

        private void txtMatkhau_Leave(object sender, EventArgs e)
        {

            if (txtMatKhau.Text == "")
            {
                txtMatKhau.UseSystemPasswordChar = false;
                txtMatKhau.Text = "Mật khẩu";
                txtMatKhau.ForeColor = Color.Silver;
            }
        }

        private void btnHienmatkhau_MouseDown(object sender, MouseEventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = false;
        }

        private void btnHienmatkhau_MouseUp(object sender, MouseEventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = true;
        }

        private void BtnDangNhap_Click(object sender, EventArgs e)
        {
            QuanLyKhachSanEntities db = new QuanLyKhachSanEntities();
            //gọi đến class MatKhau
            if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text) &&
             string.IsNullOrWhiteSpace(txtMatKhau.Text) 
             )
            {
                MessageBox.Show("Please Fill All The Fields", "Warning!");
                return;
            }


            MatKhau user = new MatKhau()
            {
                username = txtTenDangNhap.Text,
                password = txtMatKhau.Text,
               
            };

            

           


        }
    

       

       

        private void btnHienMatKhau_Click(object sender, EventArgs e)
        {

        }

        private void lblChuaCoTaiKhoan_Click(object sender, EventArgs e)
        {

        }

        private void pnlMatKhau_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picMatKhau_Click(object sender, EventArgs e)
        {

        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void picTenDangNhap_Click(object sender, EventArgs e)
        {

        }

        private void pnlTenDangNhap_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {

        }
      
        private void frmDangNhap_Load(object sender, EventArgs e)
        {

         
        }

        private void lblDangky_Click(object sender, EventArgs e)
        {

        }
    }
}
