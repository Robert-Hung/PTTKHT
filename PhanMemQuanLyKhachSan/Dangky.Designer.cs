
namespace PhanMemQuanLyKhachSan
{
    partial class Dangky
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDangky = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.pnlTenDangNhap = new System.Windows.Forms.Panel();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.btnDAngky = new System.Windows.Forms.Button();
            this.pnlMatKhau = new System.Windows.Forms.Panel();
            this.btnHienMatKhau = new System.Windows.Forms.Button();
            this.picMatKhau = new System.Windows.Forms.PictureBox();
            this.picTenDangNhap = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picMatKhau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTenDangNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDangky
            // 
            this.lblDangky.BackColor = System.Drawing.Color.Transparent;
            this.lblDangky.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDangky.Font = new System.Drawing.Font("Palatino Linotype", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDangky.ForeColor = System.Drawing.Color.IndianRed;
            this.lblDangky.Location = new System.Drawing.Point(0, 0);
            this.lblDangky.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDangky.Name = "lblDangky";
            this.lblDangky.Size = new System.Drawing.Size(365, 58);
            this.lblDangky.TabIndex = 0;
            this.lblDangky.Text = "Đăng ký ";
            this.lblDangky.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDangky.Click += new System.EventHandler(this.lblDangky_Click);
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.BackColor = System.Drawing.SystemColors.Control;
            this.txtTenDangNhap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenDangNhap.Font = new System.Drawing.Font("Palatino Linotype", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDangNhap.ForeColor = System.Drawing.Color.DimGray;
            this.txtTenDangNhap.Location = new System.Drawing.Point(69, 101);
            this.txtTenDangNhap.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(281, 24);
            this.txtTenDangNhap.TabIndex = 1;
            this.txtTenDangNhap.Text = "Tên đăng nhập";
            this.txtTenDangNhap.TextChanged += new System.EventHandler(this.txtTenDangNhap_TextChanged);
            this.txtTenDangNhap.Enter += new System.EventHandler(this.txtTendangnhap_Enter);
            this.txtTenDangNhap.Leave += new System.EventHandler(this.txtTendangnhap_Leave);
            // 
            // pnlTenDangNhap
            // 
            this.pnlTenDangNhap.BackColor = System.Drawing.Color.DarkRed;
            this.pnlTenDangNhap.ForeColor = System.Drawing.Color.Peru;
            this.pnlTenDangNhap.Location = new System.Drawing.Point(69, 124);
            this.pnlTenDangNhap.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTenDangNhap.Name = "pnlTenDangNhap";
            this.pnlTenDangNhap.Size = new System.Drawing.Size(281, 2);
            this.pnlTenDangNhap.TabIndex = 2;
            this.pnlTenDangNhap.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTenDangNhap_Paint);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BackColor = System.Drawing.SystemColors.Control;
            this.txtMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMatKhau.Font = new System.Drawing.Font("Palatino Linotype", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.ForeColor = System.Drawing.Color.DimGray;
            this.txtMatKhau.Location = new System.Drawing.Point(60, 204);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(2);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(251, 24);
            this.txtMatKhau.TabIndex = 4;
            this.txtMatKhau.Text = "Mật khẩu";
            this.txtMatKhau.TextChanged += new System.EventHandler(this.txtMatKhau_TextChanged);
            this.txtMatKhau.Enter += new System.EventHandler(this.txtMatkhau_Enter);
            this.txtMatKhau.Leave += new System.EventHandler(this.txtMatkhau_Leave);
            // 
            // btnDAngky
            // 
            this.btnDAngky.BackColor = System.Drawing.Color.IndianRed;
            this.btnDAngky.Font = new System.Drawing.Font("Palatino Linotype", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDAngky.Location = new System.Drawing.Point(94, 319);
            this.btnDAngky.Margin = new System.Windows.Forms.Padding(2);
            this.btnDAngky.Name = "btnDAngky";
            this.btnDAngky.Size = new System.Drawing.Size(166, 37);
            this.btnDAngky.TabIndex = 8;
            this.btnDAngky.Text = "Đăng ký";
            this.btnDAngky.UseVisualStyleBackColor = false;
            this.btnDAngky.Click += new System.EventHandler(this.BtnDangNhap_Click);
            // 
            // pnlMatKhau
            // 
            this.pnlMatKhau.BackColor = System.Drawing.Color.DarkRed;
            this.pnlMatKhau.ForeColor = System.Drawing.Color.Peru;
            this.pnlMatKhau.Location = new System.Drawing.Point(60, 233);
            this.pnlMatKhau.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMatKhau.Name = "pnlMatKhau";
            this.pnlMatKhau.Size = new System.Drawing.Size(281, 2);
            this.pnlMatKhau.TabIndex = 12;
            this.pnlMatKhau.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMatKhau_Paint);
            // 
            // btnHienMatKhau
            // 
            this.btnHienMatKhau.BackgroundImage = global::PhanMemQuanLyKhachSan.Properties.Resources.iconShow;
            this.btnHienMatKhau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHienMatKhau.FlatAppearance.BorderSize = 0;
            this.btnHienMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHienMatKhau.Location = new System.Drawing.Point(316, 215);
            this.btnHienMatKhau.Margin = new System.Windows.Forms.Padding(2);
            this.btnHienMatKhau.Name = "btnHienMatKhau";
            this.btnHienMatKhau.Size = new System.Drawing.Size(26, 17);
            this.btnHienMatKhau.TabIndex = 7;
            this.btnHienMatKhau.UseVisualStyleBackColor = true;
            this.btnHienMatKhau.Click += new System.EventHandler(this.btnHienMatKhau_Click);
            this.btnHienMatKhau.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnHienmatkhau_MouseDown);
            this.btnHienMatKhau.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnHienmatkhau_MouseUp);
            // 
            // picMatKhau
            // 
            this.picMatKhau.Image = global::PhanMemQuanLyKhachSan.Properties.Resources.iconPassword;
            this.picMatKhau.Location = new System.Drawing.Point(13, 204);
            this.picMatKhau.Margin = new System.Windows.Forms.Padding(2);
            this.picMatKhau.Name = "picMatKhau";
            this.picMatKhau.Size = new System.Drawing.Size(30, 31);
            this.picMatKhau.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMatKhau.TabIndex = 6;
            this.picMatKhau.TabStop = false;
            this.picMatKhau.Click += new System.EventHandler(this.picMatKhau_Click);
            // 
            // picTenDangNhap
            // 
            this.picTenDangNhap.Image = global::PhanMemQuanLyKhachSan.Properties.Resources.iconUser;
            this.picTenDangNhap.Location = new System.Drawing.Point(22, 101);
            this.picTenDangNhap.Margin = new System.Windows.Forms.Padding(2);
            this.picTenDangNhap.Name = "picTenDangNhap";
            this.picTenDangNhap.Size = new System.Drawing.Size(30, 31);
            this.picTenDangNhap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTenDangNhap.TabIndex = 3;
            this.picTenDangNhap.TabStop = false;
            this.picTenDangNhap.Click += new System.EventHandler(this.picTenDangNhap_Click);
            // 
            // Dangky
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 521);
            this.Controls.Add(this.pnlMatKhau);
            this.Controls.Add(this.btnDAngky);
            this.Controls.Add(this.btnHienMatKhau);
            this.Controls.Add(this.picMatKhau);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.picTenDangNhap);
            this.Controls.Add(this.pnlTenDangNhap);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.lblDangky);
            this.Name = "Dangky";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMatKhau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTenDangNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDangky;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Panel pnlTenDangNhap;
        private System.Windows.Forms.PictureBox picTenDangNhap;
        private System.Windows.Forms.PictureBox picMatKhau;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Button btnHienMatKhau;
        private System.Windows.Forms.Button btnDAngky;
        private System.Windows.Forms.Panel pnlMatKhau;
    }
}