namespace BTBuoi6
{
    partial class Form1
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
            this.gbTimNV = new System.Windows.Forms.GroupBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.rbTimTheoTen = new System.Windows.Forms.RadioButton();
            this.rbtTimTheoHo = new System.Windows.Forms.RadioButton();
            this.rbtTimTheoMa = new System.Windows.Forms.RadioButton();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.lbNhap = new System.Windows.Forms.Label();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.gbTimNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // gbTimNV
            // 
            this.gbTimNV.Controls.Add(this.btnTim);
            this.gbTimNV.Controls.Add(this.rbTimTheoTen);
            this.gbTimNV.Controls.Add(this.rbtTimTheoHo);
            this.gbTimNV.Controls.Add(this.rbtTimTheoMa);
            this.gbTimNV.Controls.Add(this.txtNhap);
            this.gbTimNV.Controls.Add(this.lbNhap);
            this.gbTimNV.Location = new System.Drawing.Point(12, 25);
            this.gbTimNV.Name = "gbTimNV";
            this.gbTimNV.Size = new System.Drawing.Size(755, 139);
            this.gbTimNV.TabIndex = 0;
            this.gbTimNV.TabStop = false;
            this.gbTimNV.Text = "TÌM KIẾM NHÂN VIÊN";
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(340, 106);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 5;
            this.btnTim.Text = "TÌM KIẾM";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // rbTimTheoTen
            // 
            this.rbTimTheoTen.AutoSize = true;
            this.rbTimTheoTen.Location = new System.Drawing.Point(570, 67);
            this.rbTimTheoTen.Name = "rbTimTheoTen";
            this.rbTimTheoTen.Size = new System.Drawing.Size(109, 17);
            this.rbTimTheoTen.TabIndex = 4;
            this.rbTimTheoTen.TabStop = true;
            this.rbTimTheoTen.Text = "Tìm kiếm theo tên";
            this.rbTimTheoTen.UseVisualStyleBackColor = true;
            // 
            // rbtTimTheoHo
            // 
            this.rbtTimTheoHo.AutoSize = true;
            this.rbtTimTheoHo.Location = new System.Drawing.Point(324, 67);
            this.rbtTimTheoHo.Name = "rbtTimTheoHo";
            this.rbtTimTheoHo.Size = new System.Drawing.Size(106, 17);
            this.rbtTimTheoHo.TabIndex = 3;
            this.rbtTimTheoHo.TabStop = true;
            this.rbtTimTheoHo.Text = "Tìm kiếm theo họ";
            this.rbtTimTheoHo.UseVisualStyleBackColor = true;
            // 
            // rbtTimTheoMa
            // 
            this.rbtTimTheoMa.AutoSize = true;
            this.rbtTimTheoMa.Location = new System.Drawing.Point(62, 67);
            this.rbtTimTheoMa.Name = "rbtTimTheoMa";
            this.rbtTimTheoMa.Size = new System.Drawing.Size(108, 17);
            this.rbtTimTheoMa.TabIndex = 2;
            this.rbtTimTheoMa.TabStop = true;
            this.rbtTimTheoMa.Text = "Tìm kiếm theo mã";
            this.rbtTimTheoMa.UseVisualStyleBackColor = true;
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(62, 29);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(668, 20);
            this.txtNhap.TabIndex = 1;
            // 
            // lbNhap
            // 
            this.lbNhap.AutoSize = true;
            this.lbNhap.Location = new System.Drawing.Point(23, 32);
            this.lbNhap.Name = "lbNhap";
            this.lbNhap.Size = new System.Drawing.Size(33, 13);
            this.lbNhap.TabIndex = 0;
            this.lbNhap.Text = "Nhập";
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Location = new System.Drawing.Point(12, 170);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.Size = new System.Drawing.Size(755, 249);
            this.dgvNhanVien.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 431);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.gbTimNV);
            this.Name = "Form1";
            this.Text = "TÌM KIẾM NHÂN VIÊN";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.gbTimNV.ResumeLayout(false);
            this.gbTimNV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTimNV;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.RadioButton rbTimTheoTen;
        private System.Windows.Forms.RadioButton rbtTimTheoHo;
        private System.Windows.Forms.RadioButton rbtTimTheoMa;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.Label lbNhap;
        private System.Windows.Forms.DataGridView dgvNhanVien;
    }
}

