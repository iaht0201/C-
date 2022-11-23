namespace TreeFolder
{
    partial class frnCaiDat
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
            this.numThoiGian = new System.Windows.Forms.NumericUpDown();
            this.rbNgauNhien = new System.Windows.Forms.RadioButton();
            this.rbLapLai = new System.Windows.Forms.RadioButton();
            this.btnDongY = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numThoiGian)).BeginInit();
            this.SuspendLayout();
            // 
            // numThoiGian
            // 
            this.numThoiGian.Location = new System.Drawing.Point(156, 49);
            this.numThoiGian.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numThoiGian.Name = "numThoiGian";
            this.numThoiGian.Size = new System.Drawing.Size(120, 23);
            this.numThoiGian.TabIndex = 0;
            this.numThoiGian.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numThoiGian.ValueChanged += new System.EventHandler(this.numTimer_ValueChanged);
            // 
            // rbNgauNhien
            // 
            this.rbNgauNhien.AutoSize = true;
            this.rbNgauNhien.Location = new System.Drawing.Point(156, 129);
            this.rbNgauNhien.Name = "rbNgauNhien";
            this.rbNgauNhien.Size = new System.Drawing.Size(89, 19);
            this.rbNgauNhien.TabIndex = 2;
            this.rbNgauNhien.Text = "Ngẫu Nhiên";
            this.rbNgauNhien.UseVisualStyleBackColor = true;
            this.rbNgauNhien.CheckedChanged += new System.EventHandler(this.rbNgauNhien_CheckedChanged);
            // 
            // rbLapLai
            // 
            this.rbLapLai.AutoSize = true;
            this.rbLapLai.Checked = true;
            this.rbLapLai.Location = new System.Drawing.Point(156, 93);
            this.rbLapLai.Name = "rbLapLai";
            this.rbLapLai.Size = new System.Drawing.Size(59, 19);
            this.rbLapLai.TabIndex = 3;
            this.rbLapLai.TabStop = true;
            this.rbLapLai.Text = "Lặp lại";
            this.rbLapLai.UseVisualStyleBackColor = true;
            this.rbLapLai.CheckedChanged += new System.EventHandler(this.rbLapLai_CheckedChanged);
            // 
            // btnDongY
            // 
            this.btnDongY.Location = new System.Drawing.Point(226, 215);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(75, 23);
            this.btnDongY.TabIndex = 4;
            this.btnDongY.Text = "Đồng Ý";
            this.btnDongY.UseVisualStyleBackColor = true;
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(332, 215);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 5;
            this.btnHuy.Text = "Huy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // frnCaiDat
            // 
            this.AcceptButton = this.btnDongY;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnHuy;
            this.ClientSize = new System.Drawing.Size(432, 248);
            this.ControlBox = false;
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnDongY);
            this.Controls.Add(this.rbLapLai);
            this.Controls.Add(this.rbNgauNhien);
            this.Controls.Add(this.numThoiGian);
            this.Name = "frnCaiDat";
            this.Text = "Setting";
            ((System.ComponentModel.ISupportInitialize)(this.numThoiGian)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown numThoiGian;
        private RadioButton rbNgauNhien;
        private RadioButton rbLapLai;
        private Button btnDongY;
        private Button btnHuy;
    }
}