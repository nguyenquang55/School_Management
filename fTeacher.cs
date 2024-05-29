using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Linq;
using test_app.DAO;
using static Azure.Core.HttpHeader;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace test_app
{
    public partial class fteacher : Form
    {
        private User Account;

        public fteacher()
        {
            InitializeComponent();
            LoadAccount();
        }

        private void fteacher_Load(object sender, EventArgs e)
        {

        }

        private void LoadAccount()
        {
            try
            {
                string read = File.ReadAllText("Account.json");
                Account = JsonConvert.DeserializeObject<User>(read);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi đọc tệp Account.json: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Account == null)
            {
                MessageBox.Show("Tài khoản không được tải.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = $"SELECT * FROM teacherinformations WHERE ID = '{Account.name}'";
            DataTable data = DataProvider.Instance1.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0];
                txbName.Text = row["teacherName"].ToString();
                txbID.Text = row["ID"].ToString();
                tbSex.Text = row["sex"].ToString();
                tbBirth.Text = row["birth"].ToString();
                tbIDCard.Text = row["IDCard"].ToString();
                txBornPlace.Text = row["bornPlace"].ToString();
                tbEthnic.Text = row["ethnic"].ToString();
                tbHometown.Text = row["hometown"].ToString();
                tbNationality.Text = row["nationality"].ToString();
                tbReligion.Text = row["religion"].ToString();
                tbPhoneNumber.Text = row["phoneNumber"].ToString();
                tbEmail.Text = row["email"].ToString();
            }
            else
            {
                txbName.Text = "Không có dữ liệu";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Account == null)
            {
                MessageBox.Show("Tài khoản không được tải.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = $@"
                            SELECT DISTINCT 
                            S.ID, 
                            S.studentName, 
                            M.majorName, 
                            M.departmentID, 
                            SI.birth 
                        FROM dbo.major AS M 
                        JOIN dbo.Grade AS G ON M.majorID = G.majorID 
                        JOIN dbo.studentNameAndID AS S ON G.studentID = S.ID 
                        LEFT JOIN dbo.StudentInfromation AS SI ON SI.ID = S.ID
                        WHERE M.teacherID = '{Account.name}' 
                        AND M.majorID = '{comboBox1.Text}'";

            DataTable data = DataProvider.Instance1.ExecuteQuery(query);

            if (data != null && data.Rows.Count > 0)
            {
                dtgvStudentData.Rows.Clear();
                foreach (DataRow item in data.Rows)
                {
                    int n = dtgvStudentData.Rows.Add();
                    dtgvStudentData.Rows[n].Cells[0].Value = (n + 1).ToString();
                    dtgvStudentData.Rows[n].Cells[1].Value = item["ID"].ToString();
                    dtgvStudentData.Rows[n].Cells[2].Value = item["studentName"].ToString();
                    dtgvStudentData.Rows[n].Cells[3].Value = item["birth"].ToString();
                    dtgvStudentData.Rows[n].Cells[4].Value = item["departmentID"].ToString();
                }
            }
            else
            {
                MessageBox.Show("Bạn không quản lý học phần này", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void bUpDate_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            string query = "select ID from teacherinformations";
            DataTable dt = DataProvider.Instance1.ExecuteQuery(query);

            foreach (DataRow item in dt.Rows)
            {
                list.Add(item["ID"].ToString());
            }

            string date = dateBirth.Value.ToString("yyyy-MM-dd");
            bool success = false;

            if (list.Contains(Account.name))
            {
                success = AccountLoading.Instance.UpdateTeacher(Account.name, tbName.Text, cbSex.Text, date, textBoxIDCARD.Text, tbBornPlace.Text, textBoxEthnic.Text, textBoxHometown.Text, textBoxNationality.Text, textBoxReligion.Text, textBoxPhoneNumber.Text, textBoxEmail.Text);
            }
            else
            {
                success = AccountLoading.Instance.UpdateNewTeacher(Account.name, tbName.Text, cbSex.Text, date, textBoxIDCARD.Text, tbBornPlace.Text, textBoxEthnic.Text, textBoxHometown.Text, textBoxNationality.Text, textBoxReligion.Text, textBoxPhoneNumber.Text, textBoxEmail.Text);
            }

            if (success)
            {
                MessageBox.Show("Cập nhật thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại, bạn cần nhật đầy đủ thông tin");
            }
        }

        public class User
        {
            public string name { get; set; }
            public string password { get; set; }
        }


        private void label2_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void tabTeacherInformation_Click(object sender, EventArgs e) { }
        private void TabManageClass_Click(object sender, EventArgs e) { }
        private void textBox8_TextChanged(object sender, EventArgs e) { }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clickToShow(object sender, MouseEventArgs e)
        {

        }

        private void clickToLoad(object sender, MouseEventArgs e)
        {
            string read = File.ReadAllText("Account.json");
            User account = JsonConvert.DeserializeObject<User>(read);
            string query = $"select * from db_TeacherAccount \r\nwhere userName='{account.name}'";
            DataTable data = DataProvider.Instance1.ExecuteQuery(query);
            if (data.Rows.Count > 0)
            {
                textBoxName.Text = data.Rows[0]["teacherName"].ToString();
                textBoxID.Text = data.Rows[0]["userName"].ToString();
            }
        }

        private void bConfirm_Click(object sender, EventArgs e)
        {
            string query = "select * from db_TeacherAccount";
            DataTable data = DataProvider.Instance1.ExecuteQuery(query);
            List<User> listUsersPassword = new List<User>();
            foreach (DataRow row in data.Rows)
            {
                User Userpassword = new User()
                {
                    name = row["userName"].ToString(),
                    password = row["userPassword"].ToString()
                };
                listUsersPassword.Add(Userpassword);
            }
            User userIndex = new User()
            {
                name = textBoxID.Text,
                password = textBoxPreviousPassword.Text,
            };

            bool passwordExist = listUsersPassword.Any(u => u.name == userIndex.name && u.password == userIndex.password);

            if (passwordExist)
            {
                if (!is_ValidNewPassword(textBoxNewPassword.Text))
                {
                    MessageBox.Show("Mật khẩu mới cần có ít nhất 1 kí tự đặc biệt 1 kí tự viết hoa 1 chữ số và nhiều hơn 8 kí tự");
                }
                else if (textBoxNewPassword.Text != textBoxNewPassword.Text)
                {
                    MessageBox.Show("Nhập lại mật khâu sai!!");
                }
                else
                {
                    if (AccountLoading.Instance.updateTeacherNewPasseord(textBoxID.Text, textBoxNewPassword.Text))
                    {
                        MessageBox.Show("Đổi mật khẩu thành công");
                    }
                    else
                    {
                        MessageBox.Show("Thay đổi thất bãi!!");
                    }

                }
            }
            else
            {
                MessageBox.Show("Mật khẩu cũ của bạn sai!!");
            }

        }

        public bool is_ValidNewPassword(string newPassword)
        {

            Regex regex = new Regex(@"^(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*()_+\-=\[\]{};':""\\|,.<>/?]).{8,}$");
            return regex.IsMatch(newPassword);
        }


    }
}
