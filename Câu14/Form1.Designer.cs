namespace Câu14
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


        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            cậpNhậtToolStripMenuItem = new ToolStripMenuItem();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            lblName = new Label();
            txtName = new TextBox();
            btnCapNhat = new Button();
            lstLopA = new ListBox();
            lstLopB = new ListBox();
            btnXoaLopA = new Button();
            btnKetThuc = new Button();
            btnXoaLopB = new Button();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            btnSangPhai = new Button();
            btnSangPhaiTatca = new Button();
            btnSangTrai = new Button();
            btnSangTraiTatca = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Cyan;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cậpNhậtToolStripMenuItem, hệThốngToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cậpNhậtToolStripMenuItem
            // 
            cậpNhậtToolStripMenuItem.Name = "cậpNhậtToolStripMenuItem";
            cậpNhậtToolStripMenuItem.Size = new Size(85, 24);
            cậpNhậtToolStripMenuItem.Text = "Cập Nhật";
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(88, 24);
            hệThốngToolStripMenuItem.Text = "Hệ Thống";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(89, 73);
            lblName.Name = "lblName";
            lblName.Size = new Size(69, 25);
            lblName.TabIndex = 1;
            lblName.Text = "Tên SV";
            // 
            // txtName
            // 
            txtName.Location = new Point(218, 73);
            txtName.Name = "txtName";
            txtName.Size = new Size(288, 27);
            txtName.TabIndex = 2;
            // 
            // btnCapNhat
            // 
            btnCapNhat.BackColor = SystemColors.ButtonFace;
            btnCapNhat.Location = new Point(572, 73);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(102, 35);
            btnCapNhat.TabIndex = 3;
            btnCapNhat.Text = "Cập Nhật";
            btnCapNhat.UseVisualStyleBackColor = false;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // lstLopA
            // 
            lstLopA.FormattingEnabled = true;
            lstLopA.Location = new Point(63, 170);
            lstLopA.Name = "lstLopA";
            lstLopA.SelectionMode = SelectionMode.MultiExtended;
            lstLopA.Size = new Size(150, 184);
            lstLopA.TabIndex = 4;
            // 
            // lstLopB
            // 
            lstLopB.FormattingEnabled = true;
            lstLopB.Location = new Point(533, 170);
            lstLopB.Name = "lstLopB";
            lstLopB.SelectionMode = SelectionMode.MultiExtended;
            lstLopB.Size = new Size(158, 184);
            lstLopB.TabIndex = 5;
            // 
            // btnXoaLopA
            // 
            btnXoaLopA.Location = new Point(89, 375);
            btnXoaLopA.Name = "btnXoaLopA";
            btnXoaLopA.Size = new Size(94, 29);
            btnXoaLopA.TabIndex = 6;
            btnXoaLopA.Text = "Xóa Lớp A";
            btnXoaLopA.UseVisualStyleBackColor = true;
            btnXoaLopA.Click += btnXoaLopA_Click;
            // 
            // btnKetThuc
            // 
            btnKetThuc.Location = new Point(330, 375);
            btnKetThuc.Name = "btnKetThuc";
            btnKetThuc.Size = new Size(94, 29);
            btnKetThuc.TabIndex = 7;
            btnKetThuc.Text = "Kết Thúc";
            btnKetThuc.UseVisualStyleBackColor = true;
            // 
            // btnXoaLopB
            // 
            btnXoaLopB.Location = new Point(572, 375);
            btnXoaLopB.Name = "btnXoaLopB";
            btnXoaLopB.Size = new Size(94, 29);
            btnXoaLopB.TabIndex = 8;
            btnXoaLopB.Text = "Xóa Lớp B";
            btnXoaLopB.UseVisualStyleBackColor = true;
            btnXoaLopB.Click += btnXoaLopB_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 424);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 26);
            statusStrip1.TabIndex = 9;
            statusStrip1.Text = "lblStatus";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(151, 20);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // btnSangPhai
            // 
            btnSangPhai.Location = new Point(337, 170);
            btnSangPhai.Name = "btnSangPhai";
            btnSangPhai.Size = new Size(67, 29);
            btnSangPhai.TabIndex = 10;
            btnSangPhai.Text = ">";
            btnSangPhai.UseVisualStyleBackColor = true;
            btnSangPhai.Click += btnSangPhai_Click;
            // 
            // btnSangPhaiTatca
            // 
            btnSangPhaiTatca.Location = new Point(337, 217);
            btnSangPhaiTatca.Name = "btnSangPhaiTatca";
            btnSangPhaiTatca.Size = new Size(67, 29);
            btnSangPhaiTatca.TabIndex = 11;
            btnSangPhaiTatca.Text = ">>";
            btnSangPhaiTatca.UseVisualStyleBackColor = true;
            btnSangPhaiTatca.Click += btnSangPhaiTatca_Click;
            // 
            // btnSangTrai
            // 
            btnSangTrai.Location = new Point(344, 264);
            btnSangTrai.Name = "btnSangTrai";
            btnSangTrai.Size = new Size(60, 29);
            btnSangTrai.TabIndex = 12;
            btnSangTrai.Text = "<";
            btnSangTrai.UseVisualStyleBackColor = true;
            btnSangTrai.Click += btnSangTrai_Click;
            // 
            // btnSangTraiTatca
            // 
            btnSangTraiTatca.Location = new Point(344, 310);
            btnSangTraiTatca.Name = "btnSangTraiTatca";
            btnSangTraiTatca.Size = new Size(60, 29);
            btnSangTraiTatca.TabIndex = 13;
            btnSangTraiTatca.Text = "<<";
            btnSangTraiTatca.UseVisualStyleBackColor = true;
            btnSangTraiTatca.Click += btnSangTraiTatca_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AcceptButton = btnCapNhat;
            ClientSize = new Size(800, 450);
            Controls.Add(txtName);
            Controls.Add(btnCapNhat);
            Controls.Add(lstLopA);
            Controls.Add(btnSangTrai);
            Controls.Add(btnSangTraiTatca);
            Controls.Add(btnSangPhai);
            Controls.Add(btnSangPhaiTatca);
            Controls.Add(lstLopB);
            Controls.Add(statusStrip1);
            Controls.Add(btnXoaLopA);
            Controls.Add(btnXoaLopB);
            Controls.Add(btnKetThuc);
            Controls.Add(lblName);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cậpNhậtToolStripMenuItem;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private Label lblName;
        private TextBox txtName;
        private Button btnCapNhat;
        private ListBox lstLopA;
        private ListBox lstLopB;
        private Button btnXoaLopA;
        private Button btnKetThuc;
        private Button btnXoaLopB;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private Button btnSangPhai;
        private Button btnSangPhaiTatca;
        private Button btnSangTrai;
        private Button btnSangTraiTatca;
        private System.Windows.Forms.Timer timer1;
    }
}
