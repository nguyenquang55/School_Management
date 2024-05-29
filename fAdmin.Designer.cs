namespace test_app
{
    partial class fAdmin
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
            panel1 = new Panel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            grbStudentInformation = new GroupBox();
            dtgvStudentData = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            bSearching = new Button();
            tbFindStudentID = new TextBox();
            label1 = new Label();
            texbFindStudentName = new TextBox();
            TXFindStudent = new Label();
            tabPage2 = new TabPage();
            grbNormalTeacherInformation = new GroupBox();
            dtgvTeacherInformation = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            btFindTeacher = new Button();
            tbFindTeacherID = new TextBox();
            lTeacherID = new Label();
            tbFindTeacherName = new TextBox();
            lTeacherName = new Label();
            tabPage3 = new TabPage();
            tabStudentAccount = new TabControl();
            tabSTAccount = new TabPage();
            bShowAccount = new Button();
            dtgvStudentAccountData = new DataGridView();
            dataGridViewTextBoxColumn16 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn17 = new DataGridViewTextBoxColumn();
            tabPage5 = new TabPage();
            panel3 = new Panel();
            button1 = new Button();
            dtgvTeacherAccount = new DataGridView();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            grbStudentInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvStudentData).BeginInit();
            tabPage2.SuspendLayout();
            grbNormalTeacherInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvTeacherInformation).BeginInit();
            tabPage3.SuspendLayout();
            tabStudentAccount.SuspendLayout();
            tabSTAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvStudentAccountData).BeginInit();
            tabPage5.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvTeacherAccount).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tabControl1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1097, 594);
            panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(167, 8);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(930, 586);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(grbStudentInformation);
            tabPage1.Controls.Add(bSearching);
            tabPage1.Controls.Add(tbFindStudentID);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(texbFindStudentName);
            tabPage1.Controls.Add(TXFindStudent);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(922, 553);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Sinh viên ";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // grbStudentInformation
            // 
            grbStudentInformation.Controls.Add(dtgvStudentData);
            grbStudentInformation.Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            grbStudentInformation.Location = new Point(65, 210);
            grbStudentInformation.Name = "grbStudentInformation";
            grbStudentInformation.Size = new Size(819, 202);
            grbStudentInformation.TabIndex = 8;
            grbStudentInformation.TabStop = false;
            grbStudentInformation.Text = "Thông tin cơ bản:";
            grbStudentInformation.Visible = false;
            // 
            // dtgvStudentData
            // 
            dtgvStudentData.AllowUserToAddRows = false;
            dtgvStudentData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvStudentData.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column9, Column4, Column5, Column6, Column7 });
            dtgvStudentData.Location = new Point(15, 26);
            dtgvStudentData.Name = "dtgvStudentData";
            dtgvStudentData.RowHeadersVisible = false;
            dtgvStudentData.RowHeadersWidth = 51;
            dtgvStudentData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvStudentData.Size = new Size(775, 144);
            dtgvStudentData.TabIndex = 7;
            dtgvStudentData.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // Column1
            // 
            Column1.HeaderText = "Họ và Tên";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 150;
            // 
            // Column2
            // 
            Column2.HeaderText = "Mã sinh viên";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Ngày sinh";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column9
            // 
            Column9.HeaderText = "Khóa ";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Ngành học";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 250;
            // 
            // Column5
            // 
            Column5.HeaderText = "Khoa";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Số điện thoại";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 150;
            // 
            // Column7
            // 
            Column7.HeaderText = "Email";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 250;
            // 
            // bSearching
            // 
            bSearching.Location = new Point(652, 137);
            bSearching.Name = "bSearching";
            bSearching.Size = new Size(104, 36);
            bSearching.TabIndex = 6;
            bSearching.Text = "Tìm kiếm ";
            bSearching.UseVisualStyleBackColor = true;
            bSearching.Click += bSearching_Click;
            // 
            // tbFindStudentID
            // 
            tbFindStudentID.Location = new Point(370, 73);
            tbFindStudentID.Name = "tbFindStudentID";
            tbFindStudentID.Size = new Size(386, 27);
            tbFindStudentID.TabIndex = 5;
            tbFindStudentID.Text = "   ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(132, 73);
            label1.Name = "label1";
            label1.Size = new Size(191, 24);
            label1.TabIndex = 4;
            label1.Text = "Nhập mã sinh viên:";
            // 
            // texbFindStudentName
            // 
            texbFindStudentName.Location = new Point(370, 13);
            texbFindStudentName.Name = "texbFindStudentName";
            texbFindStudentName.Size = new Size(386, 27);
            texbFindStudentName.TabIndex = 3;
            texbFindStudentName.TextChanged += texbFindStudentName_TextChanged;
            // 
            // TXFindStudent
            // 
            TXFindStudent.AutoSize = true;
            TXFindStudent.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TXFindStudent.Location = new Point(132, 13);
            TXFindStudent.Name = "TXFindStudent";
            TXFindStudent.Size = new Size(193, 24);
            TXFindStudent.TabIndex = 1;
            TXFindStudent.Text = "Nhập tên sinh viên:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(grbNormalTeacherInformation);
            tabPage2.Controls.Add(btFindTeacher);
            tabPage2.Controls.Add(tbFindTeacherID);
            tabPage2.Controls.Add(lTeacherID);
            tabPage2.Controls.Add(tbFindTeacherName);
            tabPage2.Controls.Add(lTeacherName);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(922, 553);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Giảng viên";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // grbNormalTeacherInformation
            // 
            grbNormalTeacherInformation.Controls.Add(dtgvTeacherInformation);
            grbNormalTeacherInformation.Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            grbNormalTeacherInformation.Location = new Point(59, 201);
            grbNormalTeacherInformation.Name = "grbNormalTeacherInformation";
            grbNormalTeacherInformation.Size = new Size(820, 220);
            grbNormalTeacherInformation.TabIndex = 8;
            grbNormalTeacherInformation.TabStop = false;
            grbNormalTeacherInformation.Text = "Thông tin cơ bản:";
            grbNormalTeacherInformation.Visible = false;
            grbNormalTeacherInformation.Enter += groupBox1_Enter;
            // 
            // dtgvTeacherInformation
            // 
            dtgvTeacherInformation.AllowUserToAddRows = false;
            dtgvTeacherInformation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvTeacherInformation.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8 });
            dtgvTeacherInformation.Location = new Point(23, 33);
            dtgvTeacherInformation.Name = "dtgvTeacherInformation";
            dtgvTeacherInformation.RowHeadersVisible = false;
            dtgvTeacherInformation.RowHeadersWidth = 51;
            dtgvTeacherInformation.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvTeacherInformation.Size = new Size(779, 143);
            dtgvTeacherInformation.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Họ và Tên";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Mã giảng viên";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Ngày sinh";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Khoa";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Học hàm";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "Số điện thoại";
            dataGridViewTextBoxColumn7.MinimumWidth = 6;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.HeaderText = "Email";
            dataGridViewTextBoxColumn8.MinimumWidth = 6;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            dataGridViewTextBoxColumn8.Width = 125;
            // 
            // btFindTeacher
            // 
            btFindTeacher.Location = new Point(640, 141);
            btFindTeacher.Name = "btFindTeacher";
            btFindTeacher.Size = new Size(104, 36);
            btFindTeacher.TabIndex = 7;
            btFindTeacher.Text = "Tìm kiếm ";
            btFindTeacher.UseVisualStyleBackColor = true;
            btFindTeacher.Click += btFindTeacher_Click;
            // 
            // tbFindTeacherID
            // 
            tbFindTeacherID.Location = new Point(358, 83);
            tbFindTeacherID.Name = "tbFindTeacherID";
            tbFindTeacherID.Size = new Size(386, 27);
            tbFindTeacherID.TabIndex = 6;
            tbFindTeacherID.Text = "   ";
            // 
            // lTeacherID
            // 
            lTeacherID.AutoSize = true;
            lTeacherID.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lTeacherID.Location = new Point(147, 86);
            lTeacherID.Name = "lTeacherID";
            lTeacherID.Size = new Size(203, 24);
            lTeacherID.TabIndex = 5;
            lTeacherID.Text = "Nhập mã giảng viên:";
            // 
            // tbFindTeacherName
            // 
            tbFindTeacherName.Location = new Point(358, 19);
            tbFindTeacherName.Name = "tbFindTeacherName";
            tbFindTeacherName.Size = new Size(386, 27);
            tbFindTeacherName.TabIndex = 4;
            tbFindTeacherName.TextChanged += textBox2_TextChanged;
            // 
            // lTeacherName
            // 
            lTeacherName.AutoSize = true;
            lTeacherName.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lTeacherName.Location = new Point(147, 22);
            lTeacherName.Name = "lTeacherName";
            lTeacherName.Size = new Size(205, 24);
            lTeacherName.TabIndex = 2;
            lTeacherName.Text = "Nhập tên giảng viên:";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(tabStudentAccount);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(922, 553);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Quản lý tài khoản";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabStudentAccount
            // 
            tabStudentAccount.Controls.Add(tabSTAccount);
            tabStudentAccount.Controls.Add(tabPage5);
            tabStudentAccount.Location = new Point(6, 6);
            tabStudentAccount.Name = "tabStudentAccount";
            tabStudentAccount.SelectedIndex = 0;
            tabStudentAccount.Size = new Size(910, 541);
            tabStudentAccount.TabIndex = 0;
            // 
            // tabSTAccount
            // 
            tabSTAccount.Controls.Add(bShowAccount);
            tabSTAccount.Controls.Add(dtgvStudentAccountData);
            tabSTAccount.Location = new Point(4, 29);
            tabSTAccount.Name = "tabSTAccount";
            tabSTAccount.Padding = new Padding(3);
            tabSTAccount.Size = new Size(902, 508);
            tabSTAccount.TabIndex = 0;
            tabSTAccount.Text = "Tài khoản sinh viên";
            tabSTAccount.UseVisualStyleBackColor = true;
            tabSTAccount.Click += tabPage4_Click;
            // 
            // bShowAccount
            // 
            bShowAccount.Location = new Point(679, 411);
            bShowAccount.Name = "bShowAccount";
            bShowAccount.Size = new Size(151, 58);
            bShowAccount.TabIndex = 9;
            bShowAccount.Text = "Xem tài khoản";
            bShowAccount.UseVisualStyleBackColor = true;
            bShowAccount.Click += bShowAccount_Click;
            // 
            // dtgvStudentAccountData
            // 
            dtgvStudentAccountData.AllowUserToAddRows = false;
            dtgvStudentAccountData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvStudentAccountData.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn16, dataGridViewTextBoxColumn17 });
            dtgvStudentAccountData.Location = new Point(3, 6);
            dtgvStudentAccountData.Name = "dtgvStudentAccountData";
            dtgvStudentAccountData.RowHeadersVisible = false;
            dtgvStudentAccountData.RowHeadersWidth = 51;
            dtgvStudentAccountData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvStudentAccountData.Size = new Size(890, 374);
            dtgvStudentAccountData.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn16
            // 
            dataGridViewTextBoxColumn16.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn16.HeaderText = "Tên tài khoản";
            dataGridViewTextBoxColumn16.MinimumWidth = 6;
            dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn17
            // 
            dataGridViewTextBoxColumn17.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn17.HeaderText = "mật khẩu";
            dataGridViewTextBoxColumn17.MinimumWidth = 6;
            dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            dataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(panel3);
            tabPage5.Location = new Point(4, 29);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(902, 508);
            tabPage5.TabIndex = 1;
            tabPage5.Text = "Tài khoản giảng viên";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(button1);
            panel3.Controls.Add(dtgvTeacherAccount);
            panel3.Location = new Point(6, 6);
            panel3.Name = "panel3";
            panel3.Size = new Size(890, 496);
            panel3.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(681, 405);
            button1.Name = "button1";
            button1.Size = new Size(151, 58);
            button1.TabIndex = 10;
            button1.Text = "Xem tài khoản";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dtgvTeacherAccount
            // 
            dtgvTeacherAccount.AllowUserToAddRows = false;
            dtgvTeacherAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvTeacherAccount.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10 });
            dtgvTeacherAccount.Location = new Point(3, 3);
            dtgvTeacherAccount.Name = "dtgvTeacherAccount";
            dtgvTeacherAccount.RowHeadersVisible = false;
            dtgvTeacherAccount.RowHeadersWidth = 51;
            dtgvTeacherAccount.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvTeacherAccount.Size = new Size(884, 374);
            dtgvTeacherAccount.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn9.HeaderText = "Tên tài khoản";
            dataGridViewTextBoxColumn9.MinimumWidth = 6;
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn10.HeaderText = "mật khẩu";
            dataGridViewTextBoxColumn10.MinimumWidth = 6;
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // panel2
            // 
            panel2.Location = new Point(8, 8);
            panel2.Name = "panel2";
            panel2.Size = new Size(153, 583);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // fAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1106, 598);
            Controls.Add(panel1);
            Name = "fAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            Load += fAdmin_Load;
            panel1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            grbStudentInformation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvStudentData).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            grbNormalTeacherInformation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvTeacherInformation).EndInit();
            tabPage3.ResumeLayout(false);
            tabStudentAccount.ResumeLayout(false);
            tabSTAccount.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvStudentAccountData).EndInit();
            tabPage5.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvTeacherAccount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label TXFindStudent;
        private TextBox texbFindStudentName;
        private TextBox tbFindStudentID;
        private Label label1;
        private Button bSearching;
        private DataGridView dtgvStudentData;
        private TabControl tabStudentAccount;
        private TabPage tabSTAccount;
        private TabPage tabPage5;
        private TextBox tbFindTeacherName;
        private Label lTeacherName;
        private Button btFindTeacher;
        private TextBox tbFindTeacherID;
        private Label lTeacherID;
        private GroupBox grbNormalTeacherInformation;
        private DataGridView dtgvTeacherInformation;
        private DataGridView dtgvStudentAccountData;
        private Button bShowAccount;
        private Panel panel3;
        private GroupBox grbStudentInformation;
        private Button button1;
        private DataGridView dtgvTeacherAccount;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
    }
}