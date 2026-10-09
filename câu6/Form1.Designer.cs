namespace câu6
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
            groupBox1 = new GroupBox();
            txtMessage = new TextBox();
            txtName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            radGreen = new RadioButton();
            radBlue = new RadioButton();
            radBlack = new RadioButton();
            radRed = new RadioButton();
            groupBox3 = new GroupBox();
            btnExit = new Button();
            btnClear = new Button();
            btnDisplay = new Button();
            lblText = new Label();
            picSmall = new PictureBox();
            picBig = new PictureBox();
            checkBox1 = new CheckBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picSmall).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBig).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtMessage);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(91, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(557, 132);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Input Name & Message";
            // 
            // txtMessage
            // 
            txtMessage.BackColor = Color.FromArgb(255, 224, 192);
            txtMessage.Location = new Point(199, 81);
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(286, 27);
            txtMessage.TabIndex = 3;
            // 
            // txtName
            // 
            txtName.BackColor = Color.FromArgb(255, 224, 192);
            txtName.Location = new Point(199, 37);
            txtName.Name = "txtName";
            txtName.Size = new Size(286, 27);
            txtName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 84);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 1;
            label2.Text = "Message";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 37);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.GradientInactiveCaption;
            groupBox2.Controls.Add(radGreen);
            groupBox2.Controls.Add(radBlue);
            groupBox2.Controls.Add(radBlack);
            groupBox2.Controls.Add(radRed);
            groupBox2.Location = new Point(33, 208);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(163, 158);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Color";
            // 
            // radGreen
            // 
            radGreen.AutoSize = true;
            radGreen.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radGreen.ForeColor = Color.FromArgb(0, 192, 0);
            radGreen.Location = new Point(27, 64);
            radGreen.Name = "radGreen";
            radGreen.Size = new Size(72, 24);
            radGreen.TabIndex = 3;
            radGreen.TabStop = true;
            radGreen.Text = "Green";
            radGreen.UseVisualStyleBackColor = true;
            // 
            // radBlue
            // 
            radBlue.AutoSize = true;
            radBlue.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radBlue.ForeColor = Color.Blue;
            radBlue.Location = new Point(27, 94);
            radBlue.Name = "radBlue";
            radBlue.Size = new Size(61, 24);
            radBlue.TabIndex = 2;
            radBlue.TabStop = true;
            radBlue.Text = "Blue";
            radBlue.UseVisualStyleBackColor = true;
            // 
            // radBlack
            // 
            radBlack.AutoSize = true;
            radBlack.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radBlack.Location = new Point(27, 124);
            radBlack.Name = "radBlack";
            radBlack.Size = new Size(67, 24);
            radBlack.TabIndex = 1;
            radBlack.TabStop = true;
            radBlack.Text = "Black";
            radBlack.UseVisualStyleBackColor = true;
            // 
            // radRed
            // 
            radRed.AutoSize = true;
            radRed.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radRed.ForeColor = Color.Red;
            radRed.Location = new Point(27, 38);
            radRed.Name = "radRed";
            radRed.Size = new Size(57, 24);
            radRed.TabIndex = 0;
            radRed.TabStop = true;
            radRed.Text = "Red";
            radRed.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.GradientInactiveCaption;
            groupBox3.Controls.Add(btnExit);
            groupBox3.Controls.Add(btnClear);
            groupBox3.Controls.Add(btnDisplay);
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(536, 220);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(151, 160);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Action";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(36, 117);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(84, 29);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(36, 80);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(84, 29);
            btnClear.TabIndex = 1;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnDisplay
            // 
            btnDisplay.Location = new Point(36, 42);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(84, 29);
            btnDisplay.TabIndex = 0;
            btnDisplay.Text = "Display";
            btnDisplay.UseVisualStyleBackColor = true;
            // 
            // lblText
            // 
            lblText.BackColor = Color.FromArgb(255, 192, 255);
            lblText.BorderStyle = BorderStyle.FixedSingle;
            lblText.Location = new Point(-4, 407);
            lblText.Name = "lblText";
            lblText.Size = new Size(803, 48);
            lblText.TabIndex = 3;
            // 
            // picSmall
            // 
            picSmall.BackColor = Color.Honeydew;
            picSmall.Image = Properties.Resources.dep;
            picSmall.Location = new Point(310, 220);
            picSmall.Name = "picSmall";
            picSmall.Size = new Size(103, 94);
            picSmall.SizeMode = PictureBoxSizeMode.StretchImage;
            picSmall.TabIndex = 4;
            picSmall.TabStop = false;
            // 
            // picBig
            // 
            picBig.Image = Properties.Resources.dep;
            picBig.Location = new Point(290, 272);
            picBig.Name = "picBig";
            picBig.Size = new Size(167, 120);
            picBig.SizeMode = PictureBoxSizeMode.StretchImage;
            picBig.TabIndex = 5;
            picBig.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(310, 179);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(141, 24);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Message Visable";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 450);
            Controls.Add(checkBox1);
            Controls.Add(picBig);
            Controls.Add(picSmall);
            Controls.Add(lblText);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picSmall).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBig).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private TextBox txtMessage;
        private TextBox txtName;
        private GroupBox groupBox2;
        private RadioButton radRed;
        private RadioButton radGreen;
        private RadioButton radBlue;
        private RadioButton radBlack;
        private GroupBox groupBox3;
        private Button btnExit;
        private Button btnClear;
        private Button btnDisplay;
        private Label lblText;
        private PictureBox picSmall;
        private PictureBox picBig;
        private CheckBox checkBox1;
    }
}
