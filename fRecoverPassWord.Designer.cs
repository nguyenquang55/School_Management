namespace test_app
{
    partial class fRecoverPassWord
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
            grbRecoverIndormation = new GroupBox();
            button1 = new Button();
            txRecoverEmail = new TextBox();
            label4 = new Label();
            label3 = new Label();
            cb_RecoverrConduct = new ComboBox();
            tbRecoverID = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tbRecoverName = new TextBox();
            grbRecoverIndormation.SuspendLayout();
            SuspendLayout();
            // 
            // grbRecoverIndormation
            // 
            grbRecoverIndormation.Controls.Add(button1);
            grbRecoverIndormation.Controls.Add(txRecoverEmail);
            grbRecoverIndormation.Controls.Add(label4);
            grbRecoverIndormation.Controls.Add(label3);
            grbRecoverIndormation.Controls.Add(cb_RecoverrConduct);
            grbRecoverIndormation.Controls.Add(tbRecoverID);
            grbRecoverIndormation.Controls.Add(label2);
            grbRecoverIndormation.Controls.Add(label1);
            grbRecoverIndormation.Controls.Add(tbRecoverName);
            grbRecoverIndormation.Location = new Point(12, 12);
            grbRecoverIndormation.Name = "grbRecoverIndormation";
            grbRecoverIndormation.Size = new Size(776, 426);
            grbRecoverIndormation.TabIndex = 0;
            grbRecoverIndormation.TabStop = false;
            grbRecoverIndormation.Text = "Nhập thông tin";
            // 
            // button1
            // 
            button1.Location = new Point(338, 368);
            button1.Name = "button1";
            button1.Size = new Size(122, 39);
            button1.TabIndex = 8;
            button1.Text = "Xác nhận";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txRecoverEmail
            // 
            txRecoverEmail.Location = new Point(312, 313);
            txRecoverEmail.Name = "txRecoverEmail";
            txRecoverEmail.Size = new Size(323, 27);
            txRecoverEmail.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(86, 315);
            label4.Name = "label4";
            label4.Size = new Size(186, 25);
            label4.TabIndex = 6;
            label4.Text = "Email khôi phục: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(86, 236);
            label3.Name = "label3";
            label3.Size = new Size(105, 25);
            label3.TabIndex = 5;
            label3.Text = "Chức vụ:";
            // 
            // cb_RecoverrConduct
            // 
            cb_RecoverrConduct.FormattingEnabled = true;
            cb_RecoverrConduct.Items.AddRange(new object[] { "Sinh viên ", "Giảng viên  ", "Admin " });
            cb_RecoverrConduct.Location = new Point(312, 237);
            cb_RecoverrConduct.Name = "cb_RecoverrConduct";
            cb_RecoverrConduct.Size = new Size(247, 28);
            cb_RecoverrConduct.TabIndex = 4;
            // 
            // tbRecoverID
            // 
            tbRecoverID.Location = new Point(312, 164);
            tbRecoverID.Name = "tbRecoverID";
            tbRecoverID.Size = new Size(414, 27);
            tbRecoverID.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(86, 163);
            label2.Name = "label2";
            label2.Size = new Size(82, 25);
            label2.TabIndex = 2;
            label2.Text = "Mã số:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(86, 93);
            label1.Name = "label1";
            label1.Size = new Size(134, 25);
            label1.TabIndex = 1;
            label1.Text = "Họ Và  Tên:";
            // 
            // tbRecoverName
            // 
            tbRecoverName.Location = new Point(312, 93);
            tbRecoverName.Name = "tbRecoverName";
            tbRecoverName.Size = new Size(414, 27);
            tbRecoverName.TabIndex = 0;
            // 
            // fRecoverPassWord
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grbRecoverIndormation);
            Name = "fRecoverPassWord";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lấy lại mật khẩu";
            Load += fRecoverPassWord_Load;
            grbRecoverIndormation.ResumeLayout(false);
            grbRecoverIndormation.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbRecoverIndormation;
        private Label label1;
        private TextBox tbRecoverName;
        private Label label3;
        private ComboBox cb_RecoverrConduct;
        private TextBox tbRecoverID;
        private Label label2;
        private Button button1;
        private TextBox txRecoverEmail;
        private Label label4;
    }
}