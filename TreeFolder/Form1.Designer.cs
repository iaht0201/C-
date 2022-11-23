namespace TreeFolder
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.twThuMuc = new System.Windows.Forms.TreeView();
            this.lwThuMuc = new System.Windows.Forms.ListView();
            this.tenanh = new System.Windows.Forms.ColumnHeader();
            this.path = new System.Windows.Forms.ColumnHeader();
            this.size = new System.Windows.Forms.ColumnHeader();
            this.cbbThuMuc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // twThuMuc
            // 
            this.twThuMuc.Location = new System.Drawing.Point(23, 59);
            this.twThuMuc.Name = "twThuMuc";
            this.twThuMuc.Size = new System.Drawing.Size(215, 357);
            this.twThuMuc.TabIndex = 0;
            this.twThuMuc.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.twThuMuc_AfterSelect);
            // 
            // lwThuMuc
            // 
            this.lwThuMuc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.tenanh,
            this.path,
            this.size});
            this.lwThuMuc.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lwThuMuc.Location = new System.Drawing.Point(268, 59);
            this.lwThuMuc.Name = "lwThuMuc";
            this.lwThuMuc.Size = new System.Drawing.Size(491, 349);
            this.lwThuMuc.TabIndex = 1;
            this.lwThuMuc.UseCompatibleStateImageBehavior = false;
            this.lwThuMuc.View = System.Windows.Forms.View.Details;
            this.lwThuMuc.SelectedIndexChanged += new System.EventHandler(this.lwThuMuc_SelectedIndexChanged);
            this.lwThuMuc.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lwThuMuc_MouseDoubleClick);
            // 
            // tenanh
            // 
            this.tenanh.Text = "Tên Ảnh";
            // 
            // path
            // 
            this.path.Text = "Path";
            // 
            // size
            // 
            this.size.Text = "Size";
            // 
            // cbbThuMuc
            // 
            this.cbbThuMuc.FormattingEnabled = true;
            this.cbbThuMuc.Location = new System.Drawing.Point(88, 12);
            this.cbbThuMuc.Name = "cbbThuMuc";
            this.cbbThuMuc.Size = new System.Drawing.Size(121, 23);
            this.cbbThuMuc.TabIndex = 2;
            this.cbbThuMuc.Text = "Chọn ổ đĩa ";
            this.cbbThuMuc.SelectedIndexChanged += new System.EventHandler(this.cbbThuMuc_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ổ đĩa";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(658, 417);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 4;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbThuMuc);
            this.Controls.Add(this.lwThuMuc);
            this.Controls.Add(this.twThuMuc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TreeView twThuMuc;
        private ListView lwThuMuc;
        private ComboBox cbbThuMuc;
        private Label label1;
        private ColumnHeader tenanh;
        private ColumnHeader path;
        private ColumnHeader size;
        private Button btnShow;
    }
}