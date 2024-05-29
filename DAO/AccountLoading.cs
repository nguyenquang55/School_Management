
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client.NativeInterop;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace test_app.DAO
{
    public class AccountLoading
    {
        private static AccountLoading instance;

        public static AccountLoading Instance
        {
            get { if (instance == null) instance = new AccountLoading(); return instance; }
            set { instance = value; }
        }

        private AccountLoading() { }

        public bool Login(string username, string password)
        {
            return false;
        }

        public bool updateStudent(string username, string name, string sex, string birthdate, string idCard, string bornPlace, string ethnic, string hometown, string nationality, string religion, string phoneNumber, string email)
        {


            string query1 = $@"
                 UPDATE dbo.StudentInfromation
                 SET studentName = N'{name}',
                     Sex = '{sex}',
                     birth = '{birthdate}',
                     IDCardNumber = {idCard},
                     bornPlace = N'{bornPlace}',
                     ethnic = N'{ethnic}',
                     hometown = N'{hometown}',
                     nationality = N'{nationality}',
                     religion = N'{religion}',
                     phoneNumber = {phoneNumber},
                     email = '{email}'
                 WHERE ID = '{username}'";


            int result = DataProvider.Instance1.ExecuteNonQuery(query1);

            return result > 0;

        }

        public bool updateNewStudent(string username, string name, string sex, string birthdate, string idCard, string bornPlace, string ethnic, string hometown, string nationality, string religion, string phoneNumber, string email)
        {


            string query1 = $@"
                    INSERT INTO dbo.StudentInfromation
                    (
                        ID,
                        studentName,
                        Sex,
                        birth,
                        IDCardNumber,
                        bornPlace,
                        ethnic,
                        hometown,
                        nationality,
                        religion,
                        phoneNumber,
                        email,
                        majorID,
                        departmentID
                    )
                    VALUES
                    (
                        {username},         -- ID - numeric(18, 0)
                        N'{name}',       -- studentName - nvarchar(100)
                        '{sex}',        -- Sex - varchar(10)
                        ('{birthdate}'), -- birth - date
                        {idCard},         -- IDCardNumber - numeric(18, 0)
                        N'{bornPlace}',       -- bornPlace - nvarchar(200)
                        N'{ethnic}',       -- ethnic - nvarchar(100)
                        N'{hometown}',       -- hometown - nvarchar(100)
                        N'{nationality}',       -- nationality - nvarchar(100)
                        N'{religion}',       -- religion - nvarchar(100)
                        {phoneNumber},      -- phoneNumber - numeric(20, 0)
                        '{email}',      -- email - varchar(100)
                        NULL,      -- majorID - varchar(10)
                        NULL       -- departmentID - varchar(10)
                    )";


            int result = DataProvider.Instance1.ExecuteNonQuery(query1);

            return result > 0;

        }



        public bool UpdateTeacher(string username, string name, string sex, string birthdate, string idCard, string bornPlace, string ethnic, string hometown, string nationality, string religion, string phoneNumber, string email)
        {

            string teacherQuery = $@"
                UPDATE teacherinformations
                SET
                    teacherName = N'{name}',
                    sex = N'{sex}',
                    birth = '{birthdate}',
                    IDCard = {idCard},
                    bornPlace = N'{bornPlace}',
                    ethnic = N'{ethnic}',
                    hometown = N'{hometown}',
                    nationality = N'{nationality}',
                    religion = N'{religion}',
                    phoneNumber = {phoneNumber},
                    email = '{email}'
                WHERE
                    ID = '{username}'";

            int result = DataProvider.Instance1.ExecuteNonQuery(teacherQuery);

            return result > 0;
        }

        public bool UpdateNewTeacher(string username, string name, string sex, string birthdate, string idCard, string bornPlace, string ethnic, string hometown, string nationality, string religion, string phoneNumber, string email)
        {
            string newTeacherQuery = $@"
                    INSERT INTO dbo.teacherinformations
                    (
                        ID,
                        teacherName,
                        sex,
                        birth,
                        IDCard,
                        bornPlace,
                        ethnic,
                        hometown,
                        nationality,
                        religion,
                        phoneNumber,
                        email,
                        departmentID,
                        majorID
                    )
                    VALUES
                    (
                        '{username}',        -- ID - varchar(10)
                        N'{name}',           -- teacherName - nvarchar(100)
                        N'{sex}',            -- sex - nvarchar(10)
                        '{birthdate}',       -- birth - date
                        {idCard},            -- IDCard - numeric
                        N'{bornPlace}',      -- bornPlace - nvarchar(100)
                        N'{ethnic}',         -- ethnic - nvarchar(100)
                        N'{hometown}',       -- hometown - nvarchar(100)
                        N'{nationality}',    -- nationality - nvarchar(100)
                        N'{religion}',       -- religion - nvarchar(100)
                        {phoneNumber},       -- phoneNumber - numeric
                        '{email}',           -- email - varchar(100)
                        'NULL',              -- departmentID - varchar(10)
                        'NULL'            -- majorID - varchar(10)
                    )";

            int result = DataProvider.Instance1.ExecuteNonQuery(newTeacherQuery);

            return result > 0;
        }

        public bool updateStudentNewPassword(string username , string password)
        {
            string query = $"update StudentAccount\r\nset password='{password}'\r\nwhere username={username}";
            int result = DataProvider.Instance1 .ExecuteNonQuery(query);
            return result > 0;

        }
        public bool updateTeacherNewPasseord(string username , string password)
        {
            string query = $"update db_TeacherAccount\r\nset  userPassword='{password}'\r\nwhere userName='{username}'";
            int result = DataProvider .Instance1 .ExecuteNonQuery(query); return result > 0;
        }

    }
}
