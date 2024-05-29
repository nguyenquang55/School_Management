namespace test_app
{
    partial class fteacher
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
            non = new TabControl();
            tabTeacherInformation = new TabPage();
            tbBirth = new TextBox();
            label13 = new Label();
            button1 = new Button();
            tbEmail = new TextBox();
            label11 = new Label();
            tbPhoneNumber = new TextBox();
            label10 = new Label();
            tbReligion = new TextBox();
            label9 = new Label();
            tbNationality = new TextBox();
            label8 = new Label();
            label7 = new Label();
            tbHometown = new TextBox();
            label6 = new Label();
            tbEthnic = new TextBox();
            label5 = new Label();
            txBornPlace = new TextBox();
            tbIDCard = new TextBox();
            label4 = new Label();
            tbSex = new TextBox();
            label3 = new Label();
            txbID = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txbName = new TextBox();
            TabManageClass = new TabPage();
            dtgvStudentData = new DataGridView();
            STT = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            button2 = new Button();
            comboBox1 = new ComboBox();
            label12 = new Label();
            tabChangeTeacherInfor = new TabPage();
            bUpDate = new Button();
            dateBirth = new DateTimePicker();
            cbSex = new ComboBox();
            textBoxEmail = new TextBox();
            textBoxPhoneNumber = new TextBox();
            textBoxReligion = new TextBox();
            textBoxNationality = new TextBox();
            textBoxHometown = new TextBox();
            textBoxEthnic = new TextBox();
            tbBornPlace = new TextBox();
            textBoxIDCARD = new TextBox();
            tbName = new TextBox();
            label25 = new Label();
            label24 = new Label();
            label23 = new Label();
            label22 = new Label();
            label21 = new Label();
            label20 = new Label();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label14 = new Label();
            tabPage1 = new TabPage();
            bConfirm = new Button();
            label30 = new Label();
            label29 = new Label();
            label28 = new Label();
            label27 = new Label();
            label26 = new Label();
            textBoxConfirmNewPassword = new TextBox();
            textBoxNewPassword = new TextBox();
            textBoxPreviousPassword = new TextBox();
            textBoxID = new TextBox();
            textBoxName = new TextBox();
            label15 = new Label();
            non.SuspendLayout();
            tabTeacherInformation.SuspendLayout();
            TabManageClass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvStudentData).BeginInit();
            tabChangeTeacherInfor.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // non
            // 
            non.Controls.Add(tabTeacherInformation);
            non.Controls.Add(TabManageClass);
            non.Controls.Add(tabChangeTeacherInfor);
            non.Controls.Add(tabPage1);
            non.Location = new Point(3, 4);
            non.Name = "non";
            non.SelectedIndex = 0;
            non.Size = new Size(992, 753);
            non.TabIndex = 0;
            non.MouseClick += clickToLoad;
            // 
            // tabTeacherInformation
            // 
            tabTeacherInformation.Controls.Add(tbBirth);
            tabTeacherInformation.Controls.Add(label13);
            tabTeacherInformation.Controls.Add(button1);
            tabTeacherInformation.Controls.Add(tbEmail);
            tabTeacherInformation.Controls.Add(label11);
            tabTeacherInformation.Controls.Add(tbPhoneNumber);
            tabTeacherInformation.Controls.Add(label10);
            tabTeacherInformation.Controls.Add(tbReligion);
            tabTeacherInformation.Controls.Add(label9);
            tabTeacherInformation.Controls.Add(tbNationality);
            tabTeacherInformation.Controls.Add(label8);
            tabTeacherInformation.Controls.Add(label7);
            tabTeacherInformation.Controls.Add(tbHometown);
            tabTeacherInformation.Controls.Add(label6);
            tabTeacherInformation.Controls.Add(tbEthnic);
            tabTeacherInformation.Controls.Add(label5);
            tabTeacherInformation.Controls.Add(txBornPlace);
            tabTeacherInformation.Controls.Add(tbIDCard);
            tabTeacherInformation.Controls.Add(label4);
            tabTeacherInformation.Controls.Add(tbSex);
            tabTeacherInformation.Controls.Add(label3);
            tabTeacherInformation.Controls.Add(txbID);
            tabTeacherInformation.Controls.Add(label2);
            tabTeacherInformation.Controls.Add(label1);
            tabTeacherInformation.Controls.Add(txbName);
            tabTeacherInformation.Location = new Point(4, 29);
            tabTeacherInformation.Name = "tabTeacherInformation";
            tabTeacherInformation.Padding = new Padding(3);
            tabTeacherInformation.Size = new Size(984, 720);
            tabTeacherInformation.TabIndex = 0;
            tabTeacherInformation.Text = "Thông tin giảng viên";
            tabTeacherInformation.UseVisualStyleBackColor = true;
            tabTeacherInformation.Click += tabTeacherInformation_Click;
            // 
            // tbBirth
            // 
            tbBirth.Location = new Point(208, 245);
            tbBirth.Multiline = true;
            tbBirth.Name = "tbBirth";
            tbBirth.ReadOnly = true;
            tbBirth.Size = new Size(729, 27);
            tbBirth.TabIndex = 38;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(32, 240);
            label13.Name = "label13";
            label13.Size = new Size(129, 29);
            label13.TabIndex = 37;
            label13.Text = "Ngày sinh:";
            // 
            // button1
            // 
            button1.Location = new Point(391, 658);
            button1.Name = "button1";
            button1.Size = new Size(159, 56);
            button1.TabIndex = 36;
            button1.Text = "Xem thông tin";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(208, 620);
            tbEmail.Multiline = true;
            tbEmail.Name = "tbEmail";
            tbEmail.ReadOnly = true;
            tbEmail.Size = new Size(729, 27);
            tbEmail.TabIndex = 35;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(30, 620);
            label11.Name = "label11";
            label11.Size = new Size(85, 29);
            label11.TabIndex = 34;
            label11.Text = "Email:";
            // 
            // tbPhoneNumber
            // 
            tbPhoneNumber.Location = new Point(208, 566);
            tbPhoneNumber.Multiline = true;
            tbPhoneNumber.Name = "tbPhoneNumber";
            tbPhoneNumber.ReadOnly = true;
            tbPhoneNumber.Size = new Size(729, 27);
            tbPhoneNumber.TabIndex = 33;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(28, 561);
            label10.Name = "label10";
            label10.Size = new Size(158, 29);
            label10.TabIndex = 32;
            label10.Text = "Số điện thoại:";
            // 
            // tbReligion
            // 
            tbReligion.Location = new Point(208, 510);
            tbReligion.Multiline = true;
            tbReligion.Name = "tbReligion";
            tbReligion.ReadOnly = true;
            tbReligion.Size = new Size(729, 27);
            tbReligion.TabIndex = 31;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(28, 508);
            label9.Name = "label9";
            label9.Size = new Size(115, 29);
            label9.TabIndex = 30;
            label9.Text = "Tôn giáo:";
            // 
            // tbNationality
            // 
            tbNationality.Location = new Point(208, 461);
            tbNationality.Multiline = true;
            tbNationality.Name = "tbNationality";
            tbNationality.ReadOnly = true;
            tbNationality.Size = new Size(729, 27);
            tbNationality.TabIndex = 29;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(28, 461);
            label8.Name = "label8";
            label8.Size = new Size(124, 29);
            label8.TabIndex = 28;
            label8.Text = "Quốc tịch:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(28, 405);
            label7.Name = "label7";
            label7.Size = new Size(127, 29);
            label7.TabIndex = 27;
            label7.Text = "Quê quán:";
            // 
            // tbHometown
            // 
            tbHometown.Location = new Point(208, 405);
            tbHometown.Multiline = true;
            tbHometown.Name = "tbHometown";
            tbHometown.ReadOnly = true;
            tbHometown.Size = new Size(729, 27);
            tbHometown.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(30, 350);
            label6.Name = "label6";
            label6.Size = new Size(103, 29);
            label6.TabIndex = 25;
            label6.Text = "Dân tộc:";
            // 
            // tbEthnic
            // 
            tbEthnic.Location = new Point(208, 350);
            tbEthnic.Multiline = true;
            tbEthnic.Name = "tbEthnic";
            tbEthnic.ReadOnly = true;
            tbEthnic.Size = new Size(729, 27);
            tbEthnic.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(33, 294);
            label5.Name = "label5";
            label5.Size = new Size(112, 29);
            label5.TabIndex = 23;
            label5.Text = "Nơi sinh:";
            // 
            // txBornPlace
            // 
            txBornPlace.Location = new Point(208, 299);
            txBornPlace.Multiline = true;
            txBornPlace.Name = "txBornPlace";
            txBornPlace.ReadOnly = true;
            txBornPlace.Size = new Size(729, 27);
            txBornPlace.TabIndex = 22;
            // 
            // tbIDCard
            // 
            tbIDCard.Location = new Point(208, 188);
            tbIDCard.Multiline = true;
            tbIDCard.Name = "tbIDCard";
            tbIDCard.ReadOnly = true;
            tbIDCard.Size = new Size(729, 27);
            tbIDCard.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(30, 188);
            label4.Name = "label4";
            label4.Size = new Size(108, 29);
            label4.TabIndex = 20;
            label4.Text = "Số CMT:";
            // 
            // tbSex
            // 
            tbSex.Location = new Point(208, 134);
            tbSex.Multiline = true;
            tbSex.Name = "tbSex";
            tbSex.ReadOnly = true;
            tbSex.Size = new Size(729, 27);
            tbSex.TabIndex = 19;
            tbSex.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(28, 134);
            label3.Name = "label3";
            label3.Size = new Size(117, 29);
            label3.TabIndex = 18;
            label3.Text = "Giới tính:";
            // 
            // txbID
            // 
            txbID.Location = new Point(208, 86);
            txbID.Multiline = true;
            txbID.Name = "txbID";
            txbID.ReadOnly = true;
            txbID.Size = new Size(729, 27);
            txbID.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(28, 86);
            label2.Name = "label2";
            label2.Size = new Size(174, 29);
            label2.TabIndex = 16;
            label2.Text = "Mã giảng viên:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 31);
            label1.Name = "label1";
            label1.Size = new Size(122, 29);
            label1.TabIndex = 15;
            label1.Text = "Họ và tên:";
            // 
            // txbName
            // 
            txbName.Location = new Point(208, 31);
            txbName.Multiline = true;
            txbName.Name = "txbName";
            txbName.ReadOnly = true;
            txbName.Size = new Size(729, 27);
            txbName.TabIndex = 14;
            // 
            // TabManageClass
            // 
            TabManageClass.Controls.Add(dtgvStudentData);
            TabManageClass.Controls.Add(button2);
            TabManageClass.Controls.Add(comboBox1);
            TabManageClass.Controls.Add(label12);
            TabManageClass.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TabManageClass.Location = new Point(4, 29);
            TabManageClass.Name = "TabManageClass";
            TabManageClass.Padding = new Padding(3);
            TabManageClass.Size = new Size(984, 720);
            TabManageClass.TabIndex = 1;
            TabManageClass.Text = "Học phần quản lý ";
            TabManageClass.UseVisualStyleBackColor = true;
            TabManageClass.Click += TabManageClass_Click;
            // 
            // dtgvStudentData
            // 
            dtgvStudentData.AllowUserToAddRows = false;
            dtgvStudentData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvStudentData.Columns.AddRange(new DataGridViewColumn[] { STT, Column1, Column2, Column3, Column4 });
            dtgvStudentData.Location = new Point(75, 125);
            dtgvStudentData.Name = "dtgvStudentData";
            dtgvStudentData.RowHeadersVisible = false;
            dtgvStudentData.RowHeadersWidth = 51;
            dtgvStudentData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvStudentData.Size = new Size(819, 482);
            dtgvStudentData.TabIndex = 8;
            // 
            // STT
            // 
            STT.HeaderText = "STT";
            STT.MinimumWidth = 6;
            STT.Name = "STT";
            STT.Width = 70;
            // 
            // Column1
            // 
            Column1.HeaderText = "Mã sinh viên";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 170;
            // 
            // Column2
            // 
            Column2.HeaderText = "Họ và tên";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 250;
            // 
            // Column3
            // 
            Column3.HeaderText = "Ngày sinh";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 200;
            // 
            // Column4
            // 
            Column4.HeaderText = "Khoa";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // button2
            // 
            button2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(752, 42);
            button2.Name = "button2";
            button2.Size = new Size(100, 41);
            button2.TabIndex = 2;
            button2.Text = "Tìm kiếm";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "CSE3011", "JPS30021", "VJU2012", "VJU20241" });
            comboBox1.Location = new Point(345, 58);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(200, 28);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(21, 58);
            label12.Name = "label12";
            label12.Size = new Size(248, 25);
            label12.TabIndex = 0;
            label12.Text = "Chọn mã lớp học phần:";
            // 
            // tabChangeTeacherInfor
            // 
            tabChangeTeacherInfor.Controls.Add(bUpDate);
            tabChangeTeacherInfor.Controls.Add(dateBirth);
            tabChangeTeacherInfor.Controls.Add(cbSex);
            tabChangeTeacherInfor.Controls.Add(textBoxEmail);
            tabChangeTeacherInfor.Controls.Add(textBoxPhoneNumber);
            tabChangeTeacherInfor.Controls.Add(textBoxReligion);
            tabChangeTeacherInfor.Controls.Add(textBoxNationality);
            tabChangeTeacherInfor.Controls.Add(textBoxHometown);
            tabChangeTeacherInfor.Controls.Add(textBoxEthnic);
            tabChangeTeacherInfor.Controls.Add(tbBornPlace);
            tabChangeTeacherInfor.Controls.Add(textBoxIDCARD);
            tabChangeTeacherInfor.Controls.Add(tbName);
            tabChangeTeacherInfor.Controls.Add(label25);
            tabChangeTeacherInfor.Controls.Add(label24);
            tabChangeTeacherInfor.Controls.Add(label23);
            tabChangeTeacherInfor.Controls.Add(label22);
            tabChangeTeacherInfor.Controls.Add(label21);
            tabChangeTeacherInfor.Controls.Add(label20);
            tabChangeTeacherInfor.Controls.Add(label19);
            tabChangeTeacherInfor.Controls.Add(label18);
            tabChangeTeacherInfor.Controls.Add(label17);
            tabChangeTeacherInfor.Controls.Add(label16);
            tabChangeTeacherInfor.Controls.Add(label14);
            tabChangeTeacherInfor.Location = new Point(4, 29);
            tabChangeTeacherInfor.Name = "tabChangeTeacherInfor";
            tabChangeTeacherInfor.Padding = new Padding(3);
            tabChangeTeacherInfor.Size = new Size(984, 720);
            tabChangeTeacherInfor.TabIndex = 2;
            tabChangeTeacherInfor.Text = "Cập nhật thông tin";
            tabChangeTeacherInfor.UseVisualStyleBackColor = true;
            // 
            // bUpDate
            // 
            bUpDate.Location = new Point(685, 524);
            bUpDate.Name = "bUpDate";
            bUpDate.Size = new Size(132, 49);
            bUpDate.TabIndex = 57;
            bUpDate.Text = "Cập Nhật";
            bUpDate.UseVisualStyleBackColor = true;
            bUpDate.Click += bUpDate_Click;
            // 
            // dateBirth
            // 
            dateBirth.Format = DateTimePickerFormat.Short;
            dateBirth.Location = new Point(198, 318);
            dateBirth.Name = "dateBirth";
            dateBirth.Size = new Size(273, 27);
            dateBirth.TabIndex = 56;
            dateBirth.Value = new DateTime(2024, 5, 25, 0, 0, 0, 0);
            // 
            // cbSex
            // 
            cbSex.FormattingEnabled = true;
            cbSex.Items.AddRange(new object[] { "Nam", "Nữ", "Khác" });
            cbSex.Location = new Point(198, 119);
            cbSex.Name = "cbSex";
            cbSex.Size = new Size(273, 28);
            cbSex.TabIndex = 55;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(197, 524);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(274, 27);
            textBoxEmail.TabIndex = 54;
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.Location = new Point(670, 431);
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.Size = new Size(274, 27);
            textBoxPhoneNumber.TabIndex = 53;
            textBoxPhoneNumber.TextChanged += textBox8_TextChanged;
            // 
            // textBoxReligion
            // 
            textBoxReligion.Location = new Point(670, 318);
            textBoxReligion.Name = "textBoxReligion";
            textBoxReligion.Size = new Size(274, 27);
            textBoxReligion.TabIndex = 52;
            // 
            // textBoxNationality
            // 
            textBoxNationality.Location = new Point(670, 215);
            textBoxNationality.Name = "textBoxNationality";
            textBoxNationality.Size = new Size(274, 27);
            textBoxNationality.TabIndex = 51;
            // 
            // textBoxHometown
            // 
            textBoxHometown.Location = new Point(670, 120);
            textBoxHometown.Name = "textBoxHometown";
            textBoxHometown.Size = new Size(274, 27);
            textBoxHometown.TabIndex = 50;
            // 
            // textBoxEthnic
            // 
            textBoxEthnic.Location = new Point(670, 34);
            textBoxEthnic.Name = "textBoxEthnic";
            textBoxEthnic.Size = new Size(274, 27);
            textBoxEthnic.TabIndex = 49;
            // 
            // tbBornPlace
            // 
            tbBornPlace.Location = new Point(197, 434);
            tbBornPlace.Name = "tbBornPlace";
            tbBornPlace.Size = new Size(274, 27);
            tbBornPlace.TabIndex = 48;
            // 
            // textBoxIDCARD
            // 
            textBoxIDCARD.Location = new Point(197, 215);
            textBoxIDCARD.Name = "textBoxIDCARD";
            textBoxIDCARD.Size = new Size(274, 27);
            textBoxIDCARD.TabIndex = 47;
            // 
            // tbName
            // 
            tbName.Location = new Point(197, 36);
            tbName.Name = "tbName";
            tbName.Size = new Size(274, 27);
            tbName.TabIndex = 46;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label25.Location = new Point(56, 524);
            label25.Name = "label25";
            label25.Size = new Size(85, 29);
            label25.TabIndex = 45;
            label25.Text = "Email:";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label24.Location = new Point(506, 429);
            label24.Name = "label24";
            label24.Size = new Size(158, 29);
            label24.TabIndex = 44;
            label24.Text = "Số điện thoại:";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label23.Location = new Point(523, 313);
            label23.Name = "label23";
            label23.Size = new Size(115, 29);
            label23.TabIndex = 43;
            label23.Text = "Tôn giáo:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.Location = new Point(523, 215);
            label22.Name = "label22";
            label22.Size = new Size(124, 29);
            label22.TabIndex = 42;
            label22.Text = "Quốc tịch:";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.Location = new Point(523, 120);
            label21.Name = "label21";
            label21.Size = new Size(127, 29);
            label21.TabIndex = 41;
            label21.Text = "Quê quán:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.Location = new Point(523, 34);
            label20.Name = "label20";
            label20.Size = new Size(103, 29);
            label20.TabIndex = 40;
            label20.Text = "Dân tộc:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.Location = new Point(56, 429);
            label19.Name = "label19";
            label19.Size = new Size(112, 29);
            label19.TabIndex = 39;
            label19.Text = "Nơi sinh:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(56, 313);
            label18.Name = "label18";
            label18.Size = new Size(129, 29);
            label18.TabIndex = 38;
            label18.Text = "Ngày sinh:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(56, 215);
            label17.Name = "label17";
            label17.Size = new Size(108, 29);
            label17.TabIndex = 21;
            label17.Text = "Số CMT:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(56, 120);
            label16.Name = "label16";
            label16.Size = new Size(117, 29);
            label16.TabIndex = 19;
            label16.Text = "Giới tính:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(56, 34);
            label14.Name = "label14";
            label14.Size = new Size(122, 29);
            label14.TabIndex = 16;
            label14.Text = "Họ và tên:";
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(bConfirm);
            tabPage1.Controls.Add(label30);
            tabPage1.Controls.Add(label29);
            tabPage1.Controls.Add(label28);
            tabPage1.Controls.Add(label27);
            tabPage1.Controls.Add(label26);
            tabPage1.Controls.Add(textBoxConfirmNewPassword);
            tabPage1.Controls.Add(textBoxNewPassword);
            tabPage1.Controls.Add(textBoxPreviousPassword);
            tabPage1.Controls.Add(textBoxID);
            tabPage1.Controls.Add(textBoxName);
            tabPage1.Controls.Add(label15);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(984, 720);
            tabPage1.TabIndex = 3;
            tabPage1.Text = "Sửa mật khẩu";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.MouseClick += clickToShow;
            // 
            // bConfirm
            // 
            bConfirm.Location = new Point(615, 481);
            bConfirm.Name = "bConfirm";
            bConfirm.Size = new Size(143, 51);
            bConfirm.TabIndex = 15;
            bConfirm.Text = "Xác nhận";
            bConfirm.UseVisualStyleBackColor = true;
            bConfirm.Click += bConfirm_Click;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label30.Location = new Point(205, 347);
            label30.Name = "label30";
            label30.Size = new Size(217, 31);
            label30.TabIndex = 14;
            label30.Text = "Nhập lại mật khẩu:";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label29.Location = new Point(205, 347);
            label29.Name = "label29";
            label29.Size = new Size(0, 31);
            label29.TabIndex = 13;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label28.Location = new Point(205, 265);
            label28.Name = "label28";
            label28.Size = new Size(170, 31);
            label28.TabIndex = 12;
            label28.Text = "Mật khẩu mới:";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label27.Location = new Point(205, 187);
            label27.Name = "label27";
            label27.Size = new Size(153, 31);
            label27.TabIndex = 11;
            label27.Text = "Mật khẩu cũ:";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label26.Location = new Point(205, 107);
            label26.Name = "label26";
            label26.Size = new Size(172, 31);
            label26.TabIndex = 10;
            label26.Text = "Mã giảng viên:";
            // 
            // textBoxConfirmNewPassword
            // 
            textBoxConfirmNewPassword.Location = new Point(437, 347);
            textBoxConfirmNewPassword.Name = "textBoxConfirmNewPassword";
            textBoxConfirmNewPassword.Size = new Size(253, 27);
            textBoxConfirmNewPassword.TabIndex = 9;
            // 
            // textBoxNewPassword
            // 
            textBoxNewPassword.Location = new Point(437, 265);
            textBoxNewPassword.Name = "textBoxNewPassword";
            textBoxNewPassword.Size = new Size(253, 27);
            textBoxNewPassword.TabIndex = 8;
            // 
            // textBoxPreviousPassword
            // 
            textBoxPreviousPassword.Location = new Point(437, 187);
            textBoxPreviousPassword.Name = "textBoxPreviousPassword";
            textBoxPreviousPassword.Size = new Size(253, 27);
            textBoxPreviousPassword.TabIndex = 7;
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(437, 107);
            textBoxID.Name = "textBoxID";
            textBoxID.ReadOnly = true;
            textBoxID.Size = new Size(253, 27);
            textBoxID.TabIndex = 2;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(437, 41);
            textBoxName.Name = "textBoxName";
            textBoxName.ReadOnly = true;
            textBoxName.Size = new Size(253, 27);
            textBoxName.TabIndex = 1;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(205, 41);
            label15.Name = "label15";
            label15.Size = new Size(123, 31);
            label15.TabIndex = 0;
            label15.Text = "Họ và tên:";
            // 
            // fteacher
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(997, 755);
            Controls.Add(non);
            Name = "fteacher";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Teacher";
            Load += fteacher_Load;
            non.ResumeLayout(false);
            tabTeacherInformation.ResumeLayout(false);
            tabTeacherInformation.PerformLayout();
            TabManageClass.ResumeLayout(false);
            TabManageClass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvStudentData).EndInit();
            tabChangeTeacherInfor.ResumeLayout(false);
            tabChangeTeacherInfor.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl non;
        private TabPage tabTeacherInformation;
        private TabPage TabManageClass;
        private TextBox txbName;
        private Label label1;
        private TextBox txbID;
        private Label label2;
        private TextBox tbIDCard;
        private Label label4;
        private TextBox tbSex;
        private Label label3;
        private TextBox txBornPlace;
        private Label label5;
        private Label label6;
        private TextBox tbEthnic;
        private Label label7;
        private TextBox tbHometown;
        private TextBox tbNationality;
        private Label label8;
        private TextBox tbReligion;
        private Label label9;
        private Label label10;
        private Button button1;
        private TextBox tbEmail;
        private Label label11;
        private TextBox tbPhoneNumber;
        private Button button2;
        private ComboBox comboBox1;
        private Label label12;
        private DataGridView dtgvStudentData;
        private DataGridViewTextBoxColumn STT;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private TextBox tbBirth;
        private Label label13;
        private TabPage tabChangeTeacherInfor;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label14;
        private Label label25;
        private Label label24;
        private Label label23;
        private Label label22;
        private Label label21;
        private Label label20;
        private Label label19;
        private TextBox textBoxIDCARD;
        private TextBox tbName;
        private TextBox textBoxEmail;
        private TextBox textBoxPhoneNumber;
        private TextBox textBoxReligion;
        private TextBox textBoxNationality;
        private TextBox textBoxHometown;
        private TextBox textBoxEthnic;
        private TextBox tbBornPlace;
        private DateTimePicker dateBirth;
        private ComboBox cbSex;
        private Button bUpDate;
        private TabPage tabPage1;
        private TextBox textBoxID;
        private TextBox textBoxName;
        private Label label15;
        private TextBox textBoxConfirmNewPassword;
        private TextBox textBoxNewPassword;
        private TextBox textBoxPreviousPassword;
        private Label label29;
        private Label label28;
        private Label label27;
        private Label label26;
        private Button bConfirm;
        private Label label30;
    }
}