namespace test_app
{
    partial class fStudent
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
            tabChangeStudentInformation = new TabControl();
            tabStudentInformation = new TabPage();
            txbEmail = new TextBox();
            txbPhoneNumber = new TextBox();
            txbReligion = new TextBox();
            txbNationality = new TextBox();
            txbHometown = new TextBox();
            txbEthnic = new TextBox();
            txbBirthPlace = new TextBox();
            txbSTudentIDCard = new TextBox();
            txbBirth = new TextBox();
            txbStudentID = new TextBox();
            txbSex = new TextBox();
            txbStudentName = new TextBox();
            btmShowInformation = new Button();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabResult = new TabPage();
            tbGPAAvrage = new TextBox();
            label25 = new Label();
            tbtotalCreadits = new TextBox();
            label24 = new Label();
            dtgvStudentResult = new DataGridView();
            Column3 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            tabChangeStudentInformatin = new TabPage();
            bUpgrade = new Button();
            dateBirth = new DateTimePicker();
            cbSex = new ComboBox();
            tbEmail = new TextBox();
            tbPhoneNumber = new TextBox();
            tbReligion = new TextBox();
            tbNationality = new TextBox();
            tbHometown = new TextBox();
            tbEthnic = new TextBox();
            tbBornPlace = new TextBox();
            tbIDCard = new TextBox();
            txName = new TextBox();
            label23 = new Label();
            label22 = new Label();
            label21 = new Label();
            label20 = new Label();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            tabPage1 = new TabPage();
            bChange = new Button();
            txbConfirmNewPassword = new TextBox();
            txbNewPassword = new TextBox();
            txbPreviousPassword = new TextBox();
            label30 = new Label();
            label29 = new Label();
            label28 = new Label();
            txbID = new TextBox();
            tbname = new TextBox();
            label27 = new Label();
            label26 = new Label();
            tabChangeStudentInformation.SuspendLayout();
            tabStudentInformation.SuspendLayout();
            tabResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvStudentResult).BeginInit();
            tabChangeStudentInformatin.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // tabChangeStudentInformation
            // 
            tabChangeStudentInformation.Controls.Add(tabStudentInformation);
            tabChangeStudentInformation.Controls.Add(tabResult);
            tabChangeStudentInformation.Controls.Add(tabChangeStudentInformatin);
            tabChangeStudentInformation.Controls.Add(tabPage1);
            tabChangeStudentInformation.Location = new Point(2, 1);
            tabChangeStudentInformation.Name = "tabChangeStudentInformation";
            tabChangeStudentInformation.SelectedIndex = 0;
            tabChangeStudentInformation.Size = new Size(960, 716);
            tabChangeStudentInformation.TabIndex = 0;
            tabChangeStudentInformation.MouseClick += clickToLoad;
            // 
            // tabStudentInformation
            // 
            tabStudentInformation.Controls.Add(txbEmail);
            tabStudentInformation.Controls.Add(txbPhoneNumber);
            tabStudentInformation.Controls.Add(txbReligion);
            tabStudentInformation.Controls.Add(txbNationality);
            tabStudentInformation.Controls.Add(txbHometown);
            tabStudentInformation.Controls.Add(txbEthnic);
            tabStudentInformation.Controls.Add(txbBirthPlace);
            tabStudentInformation.Controls.Add(txbSTudentIDCard);
            tabStudentInformation.Controls.Add(txbBirth);
            tabStudentInformation.Controls.Add(txbStudentID);
            tabStudentInformation.Controls.Add(txbSex);
            tabStudentInformation.Controls.Add(txbStudentName);
            tabStudentInformation.Controls.Add(btmShowInformation);
            tabStudentInformation.Controls.Add(label12);
            tabStudentInformation.Controls.Add(label11);
            tabStudentInformation.Controls.Add(label10);
            tabStudentInformation.Controls.Add(label9);
            tabStudentInformation.Controls.Add(label8);
            tabStudentInformation.Controls.Add(label7);
            tabStudentInformation.Controls.Add(label6);
            tabStudentInformation.Controls.Add(label5);
            tabStudentInformation.Controls.Add(label4);
            tabStudentInformation.Controls.Add(label3);
            tabStudentInformation.Controls.Add(label2);
            tabStudentInformation.Controls.Add(label1);
            tabStudentInformation.Location = new Point(4, 29);
            tabStudentInformation.Name = "tabStudentInformation";
            tabStudentInformation.Padding = new Padding(3);
            tabStudentInformation.Size = new Size(952, 683);
            tabStudentInformation.TabIndex = 0;
            tabStudentInformation.Text = "Thông tin sinh viên";
            tabStudentInformation.UseVisualStyleBackColor = true;
            tabStudentInformation.Scroll += tabStudentInformation_Scroll;
            tabStudentInformation.Click += tabStudentInformation_Click;
            // 
            // txbEmail
            // 
            txbEmail.Location = new Point(203, 573);
            txbEmail.Name = "txbEmail";
            txbEmail.ReadOnly = true;
            txbEmail.Size = new Size(729, 27);
            txbEmail.TabIndex = 25;
            // 
            // txbPhoneNumber
            // 
            txbPhoneNumber.Location = new Point(203, 526);
            txbPhoneNumber.Name = "txbPhoneNumber";
            txbPhoneNumber.ReadOnly = true;
            txbPhoneNumber.Size = new Size(729, 27);
            txbPhoneNumber.TabIndex = 24;
            // 
            // txbReligion
            // 
            txbReligion.Location = new Point(203, 478);
            txbReligion.Name = "txbReligion";
            txbReligion.ReadOnly = true;
            txbReligion.Size = new Size(729, 27);
            txbReligion.TabIndex = 23;
            // 
            // txbNationality
            // 
            txbNationality.Location = new Point(203, 430);
            txbNationality.Name = "txbNationality";
            txbNationality.ReadOnly = true;
            txbNationality.Size = new Size(729, 27);
            txbNationality.TabIndex = 22;
            // 
            // txbHometown
            // 
            txbHometown.Location = new Point(203, 382);
            txbHometown.Name = "txbHometown";
            txbHometown.ReadOnly = true;
            txbHometown.Size = new Size(729, 27);
            txbHometown.TabIndex = 21;
            // 
            // txbEthnic
            // 
            txbEthnic.Location = new Point(203, 334);
            txbEthnic.Name = "txbEthnic";
            txbEthnic.ReadOnly = true;
            txbEthnic.Size = new Size(729, 27);
            txbEthnic.TabIndex = 20;
            // 
            // txbBirthPlace
            // 
            txbBirthPlace.Location = new Point(203, 283);
            txbBirthPlace.Name = "txbBirthPlace";
            txbBirthPlace.ReadOnly = true;
            txbBirthPlace.Size = new Size(729, 27);
            txbBirthPlace.TabIndex = 19;
            // 
            // txbSTudentIDCard
            // 
            txbSTudentIDCard.Location = new Point(203, 238);
            txbSTudentIDCard.Name = "txbSTudentIDCard";
            txbSTudentIDCard.ReadOnly = true;
            txbSTudentIDCard.Size = new Size(729, 27);
            txbSTudentIDCard.TabIndex = 18;
            // 
            // txbBirth
            // 
            txbBirth.Location = new Point(203, 187);
            txbBirth.Name = "txbBirth";
            txbBirth.ReadOnly = true;
            txbBirth.Size = new Size(729, 27);
            txbBirth.TabIndex = 17;
            // 
            // txbStudentID
            // 
            txbStudentID.Location = new Point(203, 95);
            txbStudentID.Name = "txbStudentID";
            txbStudentID.ReadOnly = true;
            txbStudentID.Size = new Size(729, 27);
            txbStudentID.TabIndex = 16;
            // 
            // txbSex
            // 
            txbSex.Location = new Point(203, 142);
            txbSex.Name = "txbSex";
            txbSex.ReadOnly = true;
            txbSex.Size = new Size(729, 27);
            txbSex.TabIndex = 15;
            // 
            // txbStudentName
            // 
            txbStudentName.Location = new Point(203, 46);
            txbStudentName.Multiline = true;
            txbStudentName.Name = "txbStudentName";
            txbStudentName.ReadOnly = true;
            txbStudentName.Size = new Size(729, 27);
            txbStudentName.TabIndex = 13;
            // 
            // btmShowInformation
            // 
            btmShowInformation.Location = new Point(373, 619);
            btmShowInformation.Name = "btmShowInformation";
            btmShowInformation.Size = new Size(149, 55);
            btmShowInformation.TabIndex = 1;
            btmShowInformation.Text = "Xem thông tin ";
            btmShowInformation.UseVisualStyleBackColor = true;
            btmShowInformation.Click += btmShowInformation_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(25, 571);
            label12.Name = "label12";
            label12.Size = new Size(85, 29);
            label12.TabIndex = 12;
            label12.Text = "Email:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(25, 521);
            label11.Name = "label11";
            label11.Size = new Size(158, 29);
            label11.TabIndex = 11;
            label11.Text = "Số điện thoại:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(25, 473);
            label10.Name = "label10";
            label10.Size = new Size(121, 29);
            label10.TabIndex = 10;
            label10.Text = "Tôn giáo: ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(25, 425);
            label9.Name = "label9";
            label9.Size = new Size(124, 29);
            label9.TabIndex = 9;
            label9.Text = "Quốc tịch:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(25, 377);
            label8.Name = "label8";
            label8.Size = new Size(127, 29);
            label8.TabIndex = 8;
            label8.Text = "Quê quán:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(25, 329);
            label7.Name = "label7";
            label7.Size = new Size(103, 29);
            label7.TabIndex = 7;
            label7.Text = "Dân tộc:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(25, 281);
            label6.Name = "label6";
            label6.Size = new Size(115, 29);
            label6.TabIndex = 6;
            label6.Text = "Nơi Sinh:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(25, 233);
            label5.Name = "label5";
            label5.Size = new Size(108, 29);
            label5.TabIndex = 5;
            label5.Text = "Số CMT:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(25, 185);
            label4.Name = "label4";
            label4.Size = new Size(129, 29);
            label4.TabIndex = 4;
            label4.Text = "Ngày sinh:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(25, 137);
            label3.Name = "label3";
            label3.Size = new Size(117, 29);
            label3.TabIndex = 3;
            label3.Text = "Giới tính:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 89);
            label2.Name = "label2";
            label2.Size = new Size(161, 29);
            label2.TabIndex = 2;
            label2.Text = "Mã sinh viên:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 41);
            label1.Name = "label1";
            label1.Size = new Size(122, 29);
            label1.TabIndex = 1;
            label1.Text = "Họ và tên:";
            // 
            // tabResult
            // 
            tabResult.Controls.Add(tbGPAAvrage);
            tabResult.Controls.Add(label25);
            tabResult.Controls.Add(tbtotalCreadits);
            tabResult.Controls.Add(label24);
            tabResult.Controls.Add(dtgvStudentResult);
            tabResult.Location = new Point(4, 29);
            tabResult.Name = "tabResult";
            tabResult.Padding = new Padding(3);
            tabResult.Size = new Size(952, 683);
            tabResult.TabIndex = 1;
            tabResult.Text = "Kết quả học tập";
            tabResult.UseVisualStyleBackColor = true;
            // 
            // tbGPAAvrage
            // 
            tbGPAAvrage.Location = new Point(229, 442);
            tbGPAAvrage.Name = "tbGPAAvrage";
            tbGPAAvrage.ReadOnly = true;
            tbGPAAvrage.Size = new Size(204, 27);
            tbGPAAvrage.TabIndex = 12;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label25.Location = new Point(29, 444);
            label25.Name = "label25";
            label25.Size = new Size(179, 25);
            label25.TabIndex = 11;
            label25.Text = "GPA trung bình:";
            // 
            // tbtotalCreadits
            // 
            tbtotalCreadits.Location = new Point(229, 380);
            tbtotalCreadits.Name = "tbtotalCreadits";
            tbtotalCreadits.ReadOnly = true;
            tbtotalCreadits.Size = new Size(204, 27);
            tbtotalCreadits.TabIndex = 10;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label24.Location = new Point(29, 380);
            label24.Name = "label24";
            label24.Size = new Size(169, 25);
            label24.TabIndex = 9;
            label24.Text = "Tín chỉ tích lũy:";
            // 
            // dtgvStudentResult
            // 
            dtgvStudentResult.AllowUserToAddRows = false;
            dtgvStudentResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvStudentResult.Columns.AddRange(new DataGridViewColumn[] { Column3, Column1, Column2, Column4, Column5, Column6, Column7 });
            dtgvStudentResult.Location = new Point(3, 48);
            dtgvStudentResult.Name = "dtgvStudentResult";
            dtgvStudentResult.RowHeadersVisible = false;
            dtgvStudentResult.RowHeadersWidth = 51;
            dtgvStudentResult.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvStudentResult.Size = new Size(943, 270);
            dtgvStudentResult.TabIndex = 8;
            // 
            // Column3
            // 
            Column3.HeaderText = "STT";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 75;
            // 
            // Column1
            // 
            Column1.HeaderText = "Mã học phần";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Tên học phần";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 260;
            // 
            // Column4
            // 
            Column4.HeaderText = "Số tín chỉ ";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Hệ 10";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Điểm chữ";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // Column7
            // 
            Column7.HeaderText = "Hệ 4";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 104;
            // 
            // tabChangeStudentInformatin
            // 
            tabChangeStudentInformatin.Controls.Add(bUpgrade);
            tabChangeStudentInformatin.Controls.Add(dateBirth);
            tabChangeStudentInformatin.Controls.Add(cbSex);
            tabChangeStudentInformatin.Controls.Add(tbEmail);
            tabChangeStudentInformatin.Controls.Add(tbPhoneNumber);
            tabChangeStudentInformatin.Controls.Add(tbReligion);
            tabChangeStudentInformatin.Controls.Add(tbNationality);
            tabChangeStudentInformatin.Controls.Add(tbHometown);
            tabChangeStudentInformatin.Controls.Add(tbEthnic);
            tabChangeStudentInformatin.Controls.Add(tbBornPlace);
            tabChangeStudentInformatin.Controls.Add(tbIDCard);
            tabChangeStudentInformatin.Controls.Add(txName);
            tabChangeStudentInformatin.Controls.Add(label23);
            tabChangeStudentInformatin.Controls.Add(label22);
            tabChangeStudentInformatin.Controls.Add(label21);
            tabChangeStudentInformatin.Controls.Add(label20);
            tabChangeStudentInformatin.Controls.Add(label19);
            tabChangeStudentInformatin.Controls.Add(label18);
            tabChangeStudentInformatin.Controls.Add(label17);
            tabChangeStudentInformatin.Controls.Add(label16);
            tabChangeStudentInformatin.Controls.Add(label15);
            tabChangeStudentInformatin.Controls.Add(label14);
            tabChangeStudentInformatin.Controls.Add(label13);
            tabChangeStudentInformatin.Location = new Point(4, 29);
            tabChangeStudentInformatin.Name = "tabChangeStudentInformatin";
            tabChangeStudentInformatin.Padding = new Padding(3);
            tabChangeStudentInformatin.Size = new Size(952, 683);
            tabChangeStudentInformatin.TabIndex = 2;
            tabChangeStudentInformatin.Text = "Cập nhật thông tin sinh viên";
            tabChangeStudentInformatin.UseVisualStyleBackColor = true;
            // 
            // bUpgrade
            // 
            bUpgrade.Location = new Point(721, 566);
            bUpgrade.Name = "bUpgrade";
            bUpgrade.Size = new Size(122, 47);
            bUpgrade.TabIndex = 27;
            bUpgrade.Text = "Cập nhật";
            bUpgrade.UseVisualStyleBackColor = true;
            bUpgrade.Click += bUpgrade_Click;
            // 
            // dateBirth
            // 
            dateBirth.CustomFormat = "yyyy-MM-dd";
            dateBirth.Format = DateTimePickerFormat.Custom;
            dateBirth.Location = new Point(213, 237);
            dateBirth.Name = "dateBirth";
            dateBirth.Size = new Size(226, 27);
            dateBirth.TabIndex = 26;
            dateBirth.Value = new DateTime(2024, 5, 24, 0, 0, 0, 0);
            // 
            // cbSex
            // 
            cbSex.FormattingEnabled = true;
            cbSex.Items.AddRange(new object[] { "Nam", "Nữ", "Khác" });
            cbSex.Location = new Point(213, 145);
            cbSex.Name = "cbSex";
            cbSex.Size = new Size(226, 28);
            cbSex.TabIndex = 25;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(675, 419);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(245, 27);
            tbEmail.TabIndex = 24;
            // 
            // tbPhoneNumber
            // 
            tbPhoneNumber.Location = new Point(675, 321);
            tbPhoneNumber.Name = "tbPhoneNumber";
            tbPhoneNumber.Size = new Size(245, 27);
            tbPhoneNumber.TabIndex = 23;
            // 
            // tbReligion
            // 
            tbReligion.Location = new Point(675, 232);
            tbReligion.Name = "tbReligion";
            tbReligion.Size = new Size(245, 27);
            tbReligion.TabIndex = 22;
            // 
            // tbNationality
            // 
            tbNationality.Location = new Point(675, 145);
            tbNationality.Name = "tbNationality";
            tbNationality.Size = new Size(245, 27);
            tbNationality.TabIndex = 21;
            // 
            // tbHometown
            // 
            tbHometown.Location = new Point(675, 54);
            tbHometown.Name = "tbHometown";
            tbHometown.Size = new Size(245, 27);
            tbHometown.TabIndex = 20;
            // 
            // tbEthnic
            // 
            tbEthnic.Location = new Point(213, 513);
            tbEthnic.Name = "tbEthnic";
            tbEthnic.Size = new Size(226, 27);
            tbEthnic.TabIndex = 19;
            // 
            // tbBornPlace
            // 
            tbBornPlace.Location = new Point(213, 417);
            tbBornPlace.Name = "tbBornPlace";
            tbBornPlace.Size = new Size(226, 27);
            tbBornPlace.TabIndex = 18;
            // 
            // tbIDCard
            // 
            tbIDCard.Location = new Point(213, 326);
            tbIDCard.Name = "tbIDCard";
            tbIDCard.Size = new Size(226, 27);
            tbIDCard.TabIndex = 17;
            // 
            // txName
            // 
            txName.Location = new Point(213, 49);
            txName.Name = "txName";
            txName.Size = new Size(226, 27);
            txName.TabIndex = 14;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label23.Location = new Point(505, 417);
            label23.Name = "label23";
            label23.Size = new Size(85, 29);
            label23.TabIndex = 13;
            label23.Text = "Email:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.Location = new Point(502, 321);
            label22.Name = "label22";
            label22.Size = new Size(158, 29);
            label22.TabIndex = 12;
            label22.Text = "Số điện thoại:";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.Location = new Point(505, 232);
            label21.Name = "label21";
            label21.Size = new Size(121, 29);
            label21.TabIndex = 11;
            label21.Text = "Tôn giáo: ";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.Location = new Point(502, 143);
            label20.Name = "label20";
            label20.Size = new Size(124, 29);
            label20.TabIndex = 10;
            label20.Text = "Quốc tịch:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.Location = new Point(505, 49);
            label19.Name = "label19";
            label19.Size = new Size(127, 29);
            label19.TabIndex = 9;
            label19.Text = "Quê quán:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(66, 513);
            label18.Name = "label18";
            label18.Size = new Size(103, 29);
            label18.TabIndex = 8;
            label18.Text = "Dân tộc:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(66, 417);
            label17.Name = "label17";
            label17.Size = new Size(115, 29);
            label17.TabIndex = 7;
            label17.Text = "Nơi Sinh:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(66, 326);
            label16.Name = "label16";
            label16.Size = new Size(108, 29);
            label16.TabIndex = 6;
            label16.Text = "Số CMT:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(66, 237);
            label15.Name = "label15";
            label15.Size = new Size(138, 29);
            label15.TabIndex = 5;
            label15.Text = "Ngày Sinh: ";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(66, 145);
            label14.Name = "label14";
            label14.Size = new Size(117, 29);
            label14.TabIndex = 4;
            label14.Text = "Giới tính:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(66, 49);
            label13.Name = "label13";
            label13.Size = new Size(122, 29);
            label13.TabIndex = 2;
            label13.Text = "Họ và tên:";
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(bChange);
            tabPage1.Controls.Add(txbConfirmNewPassword);
            tabPage1.Controls.Add(txbNewPassword);
            tabPage1.Controls.Add(txbPreviousPassword);
            tabPage1.Controls.Add(label30);
            tabPage1.Controls.Add(label29);
            tabPage1.Controls.Add(label28);
            tabPage1.Controls.Add(txbID);
            tabPage1.Controls.Add(tbname);
            tabPage1.Controls.Add(label27);
            tabPage1.Controls.Add(label26);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(952, 683);
            tabPage1.TabIndex = 3;
            tabPage1.Text = "Sửa mật khẩu";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += clickToShow;
            // 
            // bChange
            // 
            bChange.Location = new Point(570, 464);
            bChange.Name = "bChange";
            bChange.Size = new Size(120, 49);
            bChange.TabIndex = 10;
            bChange.Text = "Xác  Nhận";
            bChange.UseVisualStyleBackColor = true;
            bChange.Click += bChange_Click;
            // 
            // txbConfirmNewPassword
            // 
            txbConfirmNewPassword.Location = new Point(392, 372);
            txbConfirmNewPassword.Name = "txbConfirmNewPassword";
            txbConfirmNewPassword.Size = new Size(298, 27);
            txbConfirmNewPassword.TabIndex = 9;
            // 
            // txbNewPassword
            // 
            txbNewPassword.Location = new Point(392, 291);
            txbNewPassword.Name = "txbNewPassword";
            txbNewPassword.Size = new Size(298, 27);
            txbNewPassword.TabIndex = 8;
            txbNewPassword.TextChanged += txbNewPassword_TextChanged;
            // 
            // txbPreviousPassword
            // 
            txbPreviousPassword.Location = new Point(392, 213);
            txbPreviousPassword.Name = "txbPreviousPassword";
            txbPreviousPassword.Size = new Size(298, 27);
            txbPreviousPassword.TabIndex = 7;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label30.Location = new Point(146, 366);
            label30.Name = "label30";
            label30.Size = new Size(223, 31);
            label30.TabIndex = 6;
            label30.Text = "Nhập lại mật khẩu :";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label29.Location = new Point(146, 285);
            label29.Name = "label29";
            label29.Size = new Size(172, 31);
            label29.TabIndex = 5;
            label29.Text = "Mật Khẩu mới:";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label28.Location = new Point(146, 207);
            label28.Name = "label28";
            label28.Size = new Size(155, 31);
            label28.TabIndex = 4;
            label28.Text = "Mật Khẩu cũ:";
            // 
            // txbID
            // 
            txbID.Location = new Point(392, 141);
            txbID.Name = "txbID";
            txbID.ReadOnly = true;
            txbID.Size = new Size(298, 27);
            txbID.TabIndex = 3;
            // 
            // tbname
            // 
            tbname.Location = new Point(392, 75);
            tbname.Name = "tbname";
            tbname.ReadOnly = true;
            tbname.Size = new Size(298, 27);
            tbname.TabIndex = 2;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label27.Location = new Point(146, 135);
            label27.Name = "label27";
            label27.Size = new Size(156, 31);
            label27.TabIndex = 1;
            label27.Text = "Mã sinh viên:";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label26.Location = new Point(146, 69);
            label26.Name = "label26";
            label26.Size = new Size(123, 31);
            label26.TabIndex = 0;
            label26.Text = "Họ và tên:";
            label26.Click += label26_Click;
            // 
            // fStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(964, 716);
            Controls.Add(tabChangeStudentInformation);
            Name = "fStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student";
            Load += fStudent_Load;
            tabChangeStudentInformation.ResumeLayout(false);
            tabStudentInformation.ResumeLayout(false);
            tabStudentInformation.PerformLayout();
            tabResult.ResumeLayout(false);
            tabResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvStudentResult).EndInit();
            tabChangeStudentInformatin.ResumeLayout(false);
            tabChangeStudentInformatin.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabChangeStudentInformation;
        private TabPage tabStudentInformation;
        private TabPage tabResult;
        private TabPage tabChangeStudentInformatin;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dtgvStudentID;
        private DataGridView dtgvStudentSex;
        private DataGridView dtgvStudentBirth;
        private DataGridView dtgvStudentIDCard;
        private DataGridView dtgvStudentBirthPlace;
        private DataGridView dtgvStudentEthnic;
        private DataGridView dtgvStudentHomeTown;
        private DataGridView dtgvStudentNationality;
        private DataGridView dtgvStudentReligion;
        private DataGridView dtgvStudentPhoneNumber;
        private DataGridView dtgvStudentEmail;
        private Label label2;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label12;
        private Button btmShowInformation;
        private DataGridView dtgvStudentResult;
        private TextBox txbStudentName;
        private TextBox txbSex;
        private TextBox txbEmail;
        private TextBox txbPhoneNumber;
        private TextBox txbReligion;
        private TextBox txbNationality;
        private TextBox txbHometown;
        private TextBox txbEthnic;
        private TextBox txbBirthPlace;
        private TextBox txbSTudentIDCard;
        private TextBox txbStudentID;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label17;
        private Label label16;
        private TextBox tbEmail;
        private TextBox tbPhoneNumber;
        private TextBox tbReligion;
        private TextBox tbNationality;
        private TextBox tbHometown;
        private TextBox tbEthnic;
        private TextBox tbBornPlace;
        private TextBox tbIDCard;
        private TextBox txName;
        private Label label23;
        private Label label22;
        private Label label21;
        private Label label20;
        private Label label19;
        private Label label18;
        private ComboBox cbSex;
        private Button bUpgrade;
        private DateTimePicker dateBirth;
        private TextBox txbBirth;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private TextBox tbGPAAvrage;
        private Label label25;
        private TextBox tbtotalCreadits;
        private Label label24;
        private TabPage tabPage1;
        private TextBox txbID;
        private TextBox tbname;
        private Label label27;
        private Label label26;
        private Label label30;
        private Label label29;
        private Label label28;
        private TextBox txbPreviousPassword;
        private Button bChange;
        private TextBox txbConfirmNewPassword;
        private TextBox txbNewPassword;
    }
}