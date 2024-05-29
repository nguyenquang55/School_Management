using Azure.Identity;
using Microsoft.Identity.Client.NativeInterop;
using Newtonsoft.Json;
using System;
using System.Data;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using test_app.DAO;
using static test_app.fAdmin;

namespace test_app
{
    public partial class fStudent : Form
    {
        public fStudent()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void tabStudentInformation_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void fStudent_Load(object sender, EventArgs e)
        {
        }

        private void tabStudentInformation_Scroll(object sender, ScrollEventArgs e)
        {
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
        }

        public class User
        {
            public string name { get; set; }
            public string password { get; set; }
        }

        private void btmShowInformation_Click(object sender, EventArgs e)
        {
            try
            {
                string read = File.ReadAllText("Account.json");
                User account = JsonConvert.DeserializeObject<User>(read);

                string query = $"SELECT * FROM dbo.StudentInfromation WHERE ID='{account.name}'";
                DataTable data = DataProvider.Instance1.ExecuteQuery(query);

                if (data.Rows.Count > 0)
                {
                    DataRow row = data.Rows[0];
                    txbStudentName.Text = row["studentName"].ToString();
                    txbStudentID.Text = row["ID"].ToString();
                    txbSex.Text = row["sex"].ToString();
                    txbBirth.Text = row["birth"].ToString();
                    txbSTudentIDCard.Text = row["IDCardNumber"].ToString();
                    txbBirthPlace.Text = row["bornPlace"].ToString();
                    txbEthnic.Text = row["ethnic"].ToString();
                    txbHometown.Text = row["hometown"].ToString();
                    txbNationality.Text = row["nationality"].ToString();
                    txbReligion.Text = row["religion"].ToString();
                    txbPhoneNumber.Text = row["phoneNumber"].ToString();
                    txbEmail.Text = row["email"].ToString();
                }
                else
                {
                    ClearStudentInformation();
                    txbStudentName.Text = "No data found";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving data: " + ex.Message);
            }
        }

        private void ClearStudentInformation()
        {
            txbStudentID.Clear();
            txbSex.Clear();
            txbBirth.Clear();
            txbSTudentIDCard.Clear();
            txbBirthPlace.Clear();
            txbEthnic.Clear();
            txbHometown.Clear();
            txbNationality.Clear();
            txbReligion.Clear();
            txbPhoneNumber.Clear();
            txbEmail.Clear();
        }

        private void bUpgrade_Click(object sender, EventArgs e)
        {
            string read = File.ReadAllText("Account.json");
            User account = JsonConvert.DeserializeObject<User>(read);

            string query = $"SELECT ID FROM dbo.StudentInfromation";

            DataTable dt = DataProvider.Instance1.ExecuteQuery(query);
            List<string> IDList = new List<string>();
            foreach (DataRow item in dt.Rows)
            {
                IDList.Add(item["ID"].ToString());
            }
            if (IDList.Contains(account.name))
            {
                string date = dateBirth.Value.ToString("yyyy-MM-dd");

                if (AccountLoading.Instance.updateStudent(account.name, txName.Text, cbSex.Text, date, tbIDCard.Text, tbBornPlace.Text, tbEthnic.Text, tbHometown.Text, tbNationality.Text, tbReligion.Text, tbPhoneNumber.Text, tbEmail.Text))
                {
                    MessageBox.Show("Cập nhật thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại,bạn cần nhập đầy đủ thông tin");
                }
            }
            else
            {
                string date = dateBirth.Value.ToString("yyyy-MM-dd");

                if (AccountLoading.Instance.updateNewStudent(account.name, txName.Text, cbSex.Text, date, tbIDCard.Text, tbBornPlace.Text, tbEthnic.Text, tbHometown.Text, tbNationality.Text, tbReligion.Text, tbPhoneNumber.Text, tbEmail.Text))
                {
                    MessageBox.Show("Cập nhật thành công");
                }

                else
                {
                    MessageBox.Show("Cập nhật thất bại,bạn cần nhập đầy đủ thông tin");
                }

            }
        }

        private void clickToLoad(object sender, MouseEventArgs e)
        {
            string read = File.ReadAllText("Account.json");
            User account = JsonConvert.DeserializeObject<User>(read);
            string query = $@"
                    SELECT 
                        G.finalGrade,
                        G.letterGrade,
                        G.majorID,
                        M.majorName,
                        M.credit
                    FROM 
                        Grade AS G
                    JOIN 
                        major AS M ON M.majorID = G.majorID
                    WHERE 
                        G.studentID = '{account.name}'";

            DataTable data = DataProvider.Instance1.ExecuteQuery(query);

            dtgvStudentResult.Rows.Clear();

            int totalcredit = 0;
            double totalGPA = 0;

            foreach (DataRow item in data.Rows)
            {
                int n = dtgvStudentResult.Rows.Add();
                dtgvStudentResult.Rows[n].Cells[0].Value = (n + 1).ToString();
                dtgvStudentResult.Rows[n].Cells[1].Value = item["majorID"].ToString();
                dtgvStudentResult.Rows[n].Cells[2].Value = item["majorName"].ToString();
                dtgvStudentResult.Rows[n].Cells[3].Value = item["credit"].ToString();
                dtgvStudentResult.Rows[n].Cells[4].Value = (Convert.ToDouble(item["finalGrade"]) * 2.5).ToString();
                dtgvStudentResult.Rows[n].Cells[5].Value = item["letterGrade"].ToString();
                dtgvStudentResult.Rows[n].Cells[6].Value = item["finalGrade"].ToString();

                totalcredit += Convert.ToInt32(item["credit"]);
                totalGPA += Convert.ToDouble(item["finalGrade"]);
            }
            double averageGPA = totalGPA / data.Rows.Count;
            tbtotalCreadits.Text = totalcredit.ToString();
            tbGPAAvrage.Text = averageGPA.ToString();


            string query1 = $"select * from studentNameAndID\r\nwhere ID = {account.name}";
            DataTable data1 = DataProvider.Instance1.ExecuteQuery(query1);
            if (data.Rows.Count > 0)
            {
                tbname.Text = data1.Rows[0]["StudentName"].ToString();
                txbID.Text = data1.Rows[0]["ID"].ToString();
            }
        }

        private void bChange_Click(object sender, EventArgs e)
        {
            string query = "select * from StudentAccount";
            DataTable data = DataProvider.Instance1.ExecuteQuery(query);
            List<User> listusersPassword = new List<User>();
            foreach (DataRow row in data.Rows)
            {
                User Userpassword = new User()
                {
                    name = row["username"].ToString(),
                    password = row["password"].ToString()
                };
                listusersPassword.Add(Userpassword);
            }
            User userIndex = new User()
            {
                name = txbID.Text,
                password = txbPreviousPassword.Text,
            };

            bool passwordExist = listusersPassword.Any(u => u.name == userIndex.name && u.password == userIndex.password);
            if (passwordExist)
            {
               
                if(!is_ValidNewPassword(txbNewPassword.Text)) 
                {
                    MessageBox.Show("Mật khẩu mới cần có ít nhất 1 kí tự đặc biệt 1 kí tự viết hoa 1 chữ số và nhiều hơn 8 kí tự");
                }
                else if(txbConfirmNewPassword.Text!= txbNewPassword.Text)
                {
                    MessageBox.Show("Nhập lại mật khâu sai!!");
                }
                else
                {
                    if (AccountLoading.Instance.updateStudentNewPassword(txbID.Text, txbConfirmNewPassword.Text))
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
        private void clickToShow(object sender, EventArgs e) { }
        private void label26_Click(object sender, EventArgs e) { }

        private void txbNewPassword_TextChanged(object sender, EventArgs e)
       {
           
        }

        public bool is_ValidNewPassword(string newPassword)
        {
            
            Regex regex = new Regex(@"^(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*()_+\-=\[\]{};':""\\|,.<>/?]).{8,}$");
            return regex.IsMatch(newPassword);
        }
    }
}
 