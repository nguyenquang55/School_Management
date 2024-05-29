namespace test_app
{
    partial class fLogin
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
            panel2 = new Panel();
            button1 = new Button();
            cbConduct = new ComboBox();
            label1 = new Label();
            textPassWord = new TextBox();
            texbpassword = new Label();
            txnLoginName = new TextBox();
            texbName = new Label();
            btmSignIn = new Button();
            btnFogetPassWord = new Button();
            panel1 = new Panel();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Controls.Add(cbConduct);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(textPassWord);
            panel2.Controls.Add(texbpassword);
            panel2.Controls.Add(txnLoginName);
            panel2.Controls.Add(texbName);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(591, 192);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            // 
            // button1
            // 
            button1.Location = new Point(505, 83);
            button1.Name = "button1";
            button1.Size = new Size(71, 27);
            button1.TabIndex = 6;
            button1.Text = "Xem";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cbConduct
            // 
            cbConduct.FormattingEnabled = true;
            cbConduct.Items.AddRange(new object[] { "Sinh viên ", "Giảng viên", "Admin" });
            cbConduct.Location = new Point(238, 136);
            cbConduct.Name = "cbConduct";
            cbConduct.Size = new Size(329, 28);
            cbConduct.TabIndex = 5;
            cbConduct.SelectedIndexChanged += cbConduct_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 136);
            label1.Name = "label1";
            label1.Size = new Size(201, 24);
            label1.TabIndex = 5;
            label1.Text = "Tư cách đăng nhập:";
            label1.Click += label1_Click_1;
            // 
            // textPassWord
            // 
            textPassWord.Location = new Point(181, 83);
            textPassWord.Name = "textPassWord";
            textPassWord.Size = new Size(318, 27);
            textPassWord.TabIndex = 4;
            textPassWord.UseSystemPasswordChar = true;
            textPassWord.TextChanged += textPassWord_TextChanged;
            // 
            // texbpassword
            // 
            texbpassword.AutoSize = true;
            texbpassword.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            texbpassword.Location = new Point(12, 86);
            texbpassword.Name = "texbpassword";
            texbpassword.Size = new Size(107, 24);
            texbpassword.TabIndex = 3;
            texbpassword.Text = "Mật Khẩu:";
            texbpassword.Click += texbpassword_Click;
            // 
            // txnLoginName
            // 
            txnLoginName.Location = new Point(181, 22);
            txnLoginName.Name = "txnLoginName";
            txnLoginName.Size = new Size(386, 27);
            txnLoginName.TabIndex = 2;
            txnLoginName.TextChanged += textname_TextChanged;
            // 
            // texbName
            // 
            texbName.AutoSize = true;
            texbName.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            texbName.Location = new Point(12, 25);
            texbName.Name = "texbName";
            texbName.Size = new Size(163, 24);
            texbName.TabIndex = 0;
            texbName.Text = "Tên Đăng Nhập:";
            texbName.Click += label1_Click;
            // 
            // btmSignIn
            // 
            btmSignIn.Location = new Point(279, 212);
            btmSignIn.Name = "btmSignIn";
            btmSignIn.Size = new Size(94, 29);
            btmSignIn.TabIndex = 1;
            btmSignIn.Text = "Đăng nhập";
            btmSignIn.UseVisualStyleBackColor = true;
            btmSignIn.Click += btmSignIn_Click;
            // 
            // btnFogetPassWord
            // 
            btnFogetPassWord.Location = new Point(420, 212);
            btnFogetPassWord.Name = "btnFogetPassWord";
            btnFogetPassWord.Size = new Size(150, 29);
            btnFogetPassWord.TabIndex = 2;
            btnFogetPassWord.Text = "Quên mật khẩu";
            btnFogetPassWord.UseVisualStyleBackColor = true;
            btnFogetPassWord.Click += btnFogetPassWord_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnFogetPassWord);
            panel1.Controls.Add(btmSignIn);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 246);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // fLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(618, 270);
            Controls.Add(panel1);
            Name = "fLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            FormClosing += fLogin_FormClosing;
            Load += fLogin_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private ComboBox cbConduct;
        private Label label1;
        private TextBox textPassWord;
        private Label texbpassword;
        private TextBox txnLoginName;
        private Label texbName;
        private Button btmSignIn;
        private Button btnFogetPassWord;
        private Panel panel1;
        private Button button1;
    }
}
