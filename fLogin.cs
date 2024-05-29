using Newtonsoft.Json;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using test_app.DAO;

namespace test_app
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void fLogin_Load(object sender, EventArgs e)
        {
        }

        private void texbpassword_Click(object sender, EventArgs e)
        {
        }

        public class User
        {
            public string name { get; set; }
            public string password { get; set; }
        }

        private void btmSignIn_Click(object sender, EventArgs e)
        {
            string userName = txnLoginName.Text;
            string passWord = textPassWord.Text;

            User user = new User
            {
                name = userName,
                password = passWord
            };

            string json = JsonConvert.SerializeObject(user, Formatting.Indented);
            File.WriteAllText("Account.json", json);

            if (cbConduct.Text == "Admin" && LoginAsAdmin(userName, passWord))
            {
                OpenForm(new fAdmin());
            }
            else if (cbConduct.Text == "Giảng viên" && LoginAsTeacher(userName, passWord))
            {
                OpenForm(new fteacher());
            }
            else if (cbConduct.Text == "Sinh viên " && LoginAsStudent(userName, passWord))
            {
                OpenForm(new fStudent());
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu hoặc tư cách đăng nhập.");
            }
        }

        private bool LoginAsAdmin(string userName, string passWord)
        {
            string query = $"SELECT * FROM dbo.db_AdiminAccount WHERE UserName='{userName}' AND UserPassword='{passWord}'";
            DataTable dataTable = DataProvider.Instance1.ExecuteQuery(query);
            return dataTable.Rows.Count > 0;
        }

        private bool LoginAsTeacher(string userName, string passWord)
        {
            string query = $"SELECT * FROM dbo.db_TeacherAccount WHERE userName='{userName}' AND userPassword='{passWord}'";
            DataTable data = DataProvider.Instance1.ExecuteQuery(query);
            return data.Rows.Count > 0;
        }

        private bool LoginAsStudent(string userName, string passWord)
        {
            string query = $"SELECT * FROM dbo.StudentAccount WHERE username='{userName}' AND password='{passWord}'";
            DataTable data = DataProvider.Instance1.ExecuteQuery(query);
            return data.Rows.Count > 0;
        }

        private void OpenForm(Form form)
        {
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void textPassWord_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
        }

        private void textname_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnFogetPassWord_Click(object sender, EventArgs e)
        {
            OpenForm(new fRecoverPassWord());
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn thoát khỏi chương trình không?", "Warning", MessageBoxButtons.YesNo);
                if (result != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }

        private void cbConduct_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textPassWord.UseSystemPasswordChar = false;
        }
    }
}
