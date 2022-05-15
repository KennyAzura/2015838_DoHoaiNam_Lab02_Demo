
namespace Lab02_Demo
{
    partial class frmGiaoVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiaoVien));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblMaSo = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblNgoaiNgu = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.cboMaSo = new System.Windows.Forms.ComboBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.mtxtSoDT = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.chkNgoaiNgu = new System.Windows.Forms.CheckedListBox();
            this.lblDSMonHoc = new System.Windows.Forms.Label();
            this.lbDSMonHoc = new System.Windows.Forms.ListBox();
            this.lblMHGVGiangDay = new System.Windows.Forms.Label();
            this.lbMHGVGiangDay = new System.Windows.Forms.ListBox();
            this.btnChon = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblWebsite = new System.Windows.Forms.Label();
            this.llbLienHe = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Navy;
            this.lblTitle.Location = new System.Drawing.Point(82, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(603, 38);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "THÔNG TIN GIÁO VIÊN KHOA CNTT";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMaSo
            // 
            this.lblMaSo.AutoSize = true;
            this.lblMaSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaSo.Location = new System.Drawing.Point(32, 72);
            this.lblMaSo.Name = "lblMaSo";
            this.lblMaSo.Size = new System.Drawing.Size(75, 25);
            this.lblMaSo.TabIndex = 0;
            this.lblMaSo.Text = "Mã Số";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.Location = new System.Drawing.Point(32, 119);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(83, 25);
            this.lblHoTen.TabIndex = 0;
            this.lblHoTen.Text = "Họ Tên";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaySinh.Location = new System.Drawing.Point(32, 170);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(112, 25);
            this.lblNgaySinh.TabIndex = 0;
            this.lblNgaySinh.Text = "Ngày Sinh";
            // 
            // lblNgoaiNgu
            // 
            this.lblNgoaiNgu.AutoSize = true;
            this.lblNgoaiNgu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgoaiNgu.Location = new System.Drawing.Point(32, 228);
            this.lblNgoaiNgu.Name = "lblNgoaiNgu";
            this.lblNgoaiNgu.Size = new System.Drawing.Size(113, 25);
            this.lblNgoaiNgu.TabIndex = 0;
            this.lblNgoaiNgu.Text = "Ngoại Ngữ";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioiTinh.Location = new System.Drawing.Point(423, 72);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(99, 25);
            this.lblGioiTinh.TabIndex = 0;
            this.lblGioiTinh.Text = "Giới Tính";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDT.Location = new System.Drawing.Point(423, 119);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(74, 25);
            this.lblSDT.TabIndex = 0;
            this.lblSDT.Text = "Số ĐT";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(423, 170);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(135, 25);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Địa chỉ email";
            // 
            // cboMaSo
            // 
            this.cboMaSo.FormattingEnabled = true;
            this.cboMaSo.Items.AddRange(new object[] {
            "001",
            "002",
            "003",
            "004",
            "005"});
            this.cboMaSo.Location = new System.Drawing.Point(153, 73);
            this.cboMaSo.Name = "cboMaSo";
            this.cboMaSo.Size = new System.Drawing.Size(121, 24);
            this.cboMaSo.TabIndex = 1;
            this.cboMaSo.Text = "001";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(153, 121);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(244, 22);
            this.txtHoTen.TabIndex = 4;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Location = new System.Drawing.Point(153, 172);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(244, 22);
            this.dtpNgaySinh.TabIndex = 6;
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Checked = true;
            this.rdNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdNam.Location = new System.Drawing.Point(574, 74);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(61, 21);
            this.rdNam.TabIndex = 2;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdNu.Location = new System.Drawing.Point(664, 74);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(49, 21);
            this.rdNu.TabIndex = 3;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // mtxtSoDT
            // 
            this.mtxtSoDT.Location = new System.Drawing.Point(574, 121);
            this.mtxtSoDT.Mask = "(0633) 000-0000";
            this.mtxtSoDT.Name = "mtxtSoDT";
            this.mtxtSoDT.Size = new System.Drawing.Size(100, 22);
            this.mtxtSoDT.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(574, 170);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(214, 22);
            this.txtEmail.TabIndex = 7;
            // 
            // chkNgoaiNgu
            // 
            this.chkNgoaiNgu.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNgoaiNgu.FormattingEnabled = true;
            this.chkNgoaiNgu.Items.AddRange(new object[] {
            "Tiếng Anh",
            "Tiếng Pháp",
            "Tiếng Nhật",
            "Tiếng Nga",
            "Tiếng Việt"});
            this.chkNgoaiNgu.Location = new System.Drawing.Point(159, 228);
            this.chkNgoaiNgu.Name = "chkNgoaiNgu";
            this.chkNgoaiNgu.Size = new System.Drawing.Size(141, 114);
            this.chkNgoaiNgu.TabIndex = 8;
            this.chkNgoaiNgu.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // lblDSMonHoc
            // 
            this.lblDSMonHoc.AutoSize = true;
            this.lblDSMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDSMonHoc.Location = new System.Drawing.Point(152, 377);
            this.lblDSMonHoc.Name = "lblDSMonHoc";
            this.lblDSMonHoc.Size = new System.Drawing.Size(203, 25);
            this.lblDSMonHoc.TabIndex = 0;
            this.lblDSMonHoc.Text = "Danh sách môn học";
            this.lblDSMonHoc.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lbDSMonHoc
            // 
            this.lbDSMonHoc.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbDSMonHoc.FormattingEnabled = true;
            this.lbDSMonHoc.ItemHeight = 22;
            this.lbDSMonHoc.Items.AddRange(new object[] {
            "Tin học cơ sở",
            "Lập trình cấu trúc C/C++",
            "Cơ sở dữ iệu",
            "Tiếng Anh B1",
            "Tiếng Anh B2",
            "Lập trình hướng đối tượng",
            "Mạng máy tinh",
            "Công nghề phần mềm",
            "Phân tích TKHDT"});
            this.lbDSMonHoc.Location = new System.Drawing.Point(159, 423);
            this.lbDSMonHoc.Name = "lbDSMonHoc";
            this.lbDSMonHoc.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbDSMonHoc.Size = new System.Drawing.Size(229, 202);
            this.lbDSMonHoc.TabIndex = 9;
            // 
            // lblMHGVGiangDay
            // 
            this.lblMHGVGiangDay.AutoSize = true;
            this.lblMHGVGiangDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMHGVGiangDay.Location = new System.Drawing.Point(504, 377);
            this.lblMHGVGiangDay.Name = "lblMHGVGiangDay";
            this.lblMHGVGiangDay.Size = new System.Drawing.Size(229, 25);
            this.lblMHGVGiangDay.TabIndex = 0;
            this.lblMHGVGiangDay.Text = "Môn học giáo viên dạy";
            this.lblMHGVGiangDay.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lbMHGVGiangDay
            // 
            this.lbMHGVGiangDay.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbMHGVGiangDay.FormattingEnabled = true;
            this.lbMHGVGiangDay.ItemHeight = 22;
            this.lbMHGVGiangDay.Items.AddRange(new object[] {
            " "});
            this.lbMHGVGiangDay.Location = new System.Drawing.Point(509, 423);
            this.lbMHGVGiangDay.Name = "lbMHGVGiangDay";
            this.lbMHGVGiangDay.Size = new System.Drawing.Size(229, 202);
            this.lbMHGVGiangDay.TabIndex = 12;
            // 
            // btnChon
            // 
            this.btnChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChon.Location = new System.Drawing.Point(423, 452);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(55, 50);
            this.btnChon.TabIndex = 10;
            this.btnChon.Text = ">>";
            this.btnChon.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(423, 541);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(55, 50);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "<<";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.Navy;
            this.btnLuu.Location = new System.Drawing.Point(157, 673);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(129, 48);
            this.btnLuu.TabIndex = 13;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Red;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(368, 673);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 48);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Navy;
            this.btnExit.Location = new System.Drawing.Point(580, 673);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(129, 48);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // lblWebsite
            // 
            this.lblWebsite.AutoSize = true;
            this.lblWebsite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWebsite.Location = new System.Drawing.Point(618, 763);
            this.lblWebsite.Name = "lblWebsite";
            this.lblWebsite.Size = new System.Drawing.Size(77, 20);
            this.lblWebsite.TabIndex = 0;
            this.lblWebsite.Text = "Website";
            // 
            // llbLienHe
            // 
            this.llbLienHe.AutoSize = true;
            this.llbLienHe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbLienHe.Location = new System.Drawing.Point(709, 763);
            this.llbLienHe.Name = "llbLienHe";
            this.llbLienHe.Size = new System.Drawing.Size(71, 20);
            this.llbLienHe.TabIndex = 16;
            this.llbLienHe.TabStop = true;
            this.llbLienHe.Text = "Liên hệ";
            // 
            // frmGiaoVien
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 831);
            this.Controls.Add(this.llbLienHe);
            this.Controls.Add(this.lblWebsite);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.lbMHGVGiangDay);
            this.Controls.Add(this.lbDSMonHoc);
            this.Controls.Add(this.chkNgoaiNgu);
            this.Controls.Add(this.mtxtSoDT);
            this.Controls.Add(this.rdNu);
            this.Controls.Add(this.rdNam);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.cboMaSo);
            this.Controls.Add(this.lblMHGVGiangDay);
            this.Controls.Add(this.lblDSMonHoc);
            this.Controls.Add(this.lblNgoaiNgu);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblSDT);
            this.Controls.Add(this.lblGioiTinh);
            this.Controls.Add(this.lblMaSo);
            this.Controls.Add(this.lblTitle);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.Name = "frmGiaoVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin giáo viên khoa CNTT";
            this.Load += new System.EventHandler(this.TTGiaoVien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblMaSo;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblNgoaiNgu;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.ComboBox cboMaSo;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.MaskedTextBox mtxtSoDT;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.CheckedListBox chkNgoaiNgu;
        private System.Windows.Forms.Label lblDSMonHoc;
        private System.Windows.Forms.ListBox lbDSMonHoc;
        private System.Windows.Forms.Label lblMHGVGiangDay;
        private System.Windows.Forms.ListBox lbMHGVGiangDay;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblWebsite;
        private System.Windows.Forms.LinkLabel llbLienHe;
    }
}