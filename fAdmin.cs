using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test_app.DAO;

namespace test_app
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();

        }

        private void fAdmin_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bSearching_Click(object sender, EventArgs e)
        {
            string query = "select ID,studentName from StudentInfromation";
            DataTable data = DataProvider.Instance1.ExecuteQuery(query);

            UserInfor userInfroIndex = new UserInfor()
            {
                Name = texbFindStudentName.Text.Replace(" ", ""),
                ID = tbFindStudentID.Text.Replace(" ", ""),
            };
            List<UserInfor> listInforData = new List<UserInfor>();
            foreach (DataRow row in data.Rows)
            {
                UserInfor userInforData = new UserInfor()
                {
                    ID = row["ID"].ToString().Replace(" ", ""),
                    Name = row["studentName"].ToString().Replace(" ", "")
                };
                listInforData.Add(userInforData);
            }

            bool studentExists = listInforData.Any(u => u.ID == userInfroIndex.ID && u.Name == userInfroIndex.Name);

            if (studentExists)
            {
                string query1 = $"select * from StudentInfromation\r\nwhere ID= {tbFindStudentID.Text} and studentName=N'{texbFindStudentName.Text}'";
                DataTable dataInfor = DataProvider.Instance1.ExecuteQuery(query1);
                if (dataInfor.Rows.Count > 0)
                {
                    dtgvStudentData.Rows.Clear();

                    foreach (DataRow item in dataInfor.Rows)
                    {
                        dtgvStudentData.Rows.Add(
                            item["studentName"].ToString(),
                            item["ID"].ToString(),
                            item["birth"].ToString(),
                            item["course"].ToString(),
                            item["nganh"].ToString(),
                            item["departmentID"].ToString(),
                            item["phoneNumber"].ToString(),
                            item["email"].ToString()
                        );
                    }
                    grbStudentInformation.Show();
                }
            }
            else
            {
                MessageBox.Show("Không có sinh viên này trong danh sách hoặc thông tin bạn nhập không chính xác");
            }

        }


        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void tabPage4_Click(object sender, EventArgs e)
        {


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        public class UserInfor
        {
            public string Name { get; set; }
            public string ID { get; set; }
        }
        private void btFindTeacher_Click(object sender, EventArgs e)
        {
            string query = "SELECT ID, teacherName FROM teacherinformations";
            DataTable data = DataProvider.Instance1.ExecuteQuery(query);


            UserInfor userInforIndex = new UserInfor()
            {
                Name = tbFindTeacherName.Text.Replace(" ", ""),
                ID = tbFindTeacherID.Text.Replace(" ", "")
            };


            List<UserInfor> listInforData = new List<UserInfor>();
            foreach (DataRow row in data.Rows)
            {
                UserInfor userInforData = new UserInfor()
                {
                    ID = row["ID"].ToString().Replace(" ", ""),
                    Name = row["teacherName"].ToString().Replace(" ", "")
                };
                listInforData.Add(userInforData);
            }


            bool teacherExists = listInforData.Any(u => u.ID == userInforIndex.ID && u.Name == userInforIndex.Name);

            if (teacherExists)
            {

                string query1 = $"select * from teacherinformations \r\nwhere ID='{tbFindTeacherID.Text}' and teacherName=N'{tbFindTeacherName.Text}'";


                DataTable dataInfor = DataProvider.Instance1.ExecuteQuery(query1);


                if (dataInfor.Rows.Count > 0)
                {
                    dtgvTeacherInformation.Rows.Clear();

                    foreach (DataRow item in dataInfor.Rows)
                    {
                        dtgvTeacherInformation.Rows.Add(
                            item["teacherName"].ToString(),
                            item["ID"].ToString(),
                            item["birth"].ToString(),
                            item["departmentID"].ToString(),
                            item["academicRank"].ToString(),
                            item["phoneNumber"].ToString(),
                            item["email"].ToString()
                        );
                    }
                }

                grbNormalTeacherInformation.Show();
            }
            else
            {
                MessageBox.Show("Không có giáo viên này trong danh sách hoặc thông tin bạn nhập không chính xác");
            }
        }



        private void bShowAccount_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM dbo.StudentAccount";
                DataTable dataTable = DataProvider.Instance1.ExecuteQuery(query);


                dtgvStudentAccountData.Rows.Clear();


                foreach (DataRow item in dataTable.Rows)
                {
                    dtgvStudentAccountData.Rows.Add(item["username"].ToString(), item["password"].ToString());
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("An error occurred while loading data: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM dbo.db_TeacherAccount";
            DataTable data = DataProvider.Instance1.ExecuteQuery(query);
            dtgvTeacherAccount.Rows.Clear();
            foreach (DataRow item in data.Rows)
            {
                int n = dtgvTeacherAccount.Rows.Add();
                dtgvTeacherAccount.Rows[n].Cells[0].Value = item["userName"].ToString();
                dtgvTeacherAccount.Rows[n].Cells[1].Value = item["userPassword"].ToString();
            }
        }

        private void texbFindStudentName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
