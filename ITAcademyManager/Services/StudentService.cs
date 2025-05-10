using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ITAcademyManager
{
    public class StudentService
    {
        public DataTable LoadStudents()
        {
            string query = @"SELECT s.StudentID, 
                    COALESCE(s.GroupID, 0) AS GroupID,
                    s.FirstName, 
                    s.LastName, 
                    s.Email, 
                    s.Phone, 
                    s.DateOfBirth, 
                    COALESCE(g.GroupName, '') AS GroupName
             FROM Students s
             LEFT JOIN Groups g ON s.GroupID = g.GroupID";

            return DatabaseHelper.ExecuteQuery(query);
        }

        public DataTable LoadGroups()
        {
            return DatabaseHelper.ExecuteQuery("SELECT GroupID, GroupName FROM Groups");
        }

        public bool IsEmailValid(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return System.Text.RegularExpressions.Regex.IsMatch(email, pattern);
        }

        public bool IsEmailUnique(string email, int studentID = -1)
        {
            if (!IsEmailValid(email))
            {
                throw new Exception("Невірний формат email. Введіть коректний email.");
            }

            string query = "SELECT COUNT(*) FROM Students WHERE Email = @Email AND StudentID != @StudentID";
            int count = DatabaseHelper.ExecuteScalar(query,
                new SqlParameter("@Email", email),
                new SqlParameter("@StudentID", studentID));
            return count == 0;
        }

        public bool IsPhoneUnique(string phone, int studentID = -1)
        {
            string query = "SELECT COUNT(*) FROM Students WHERE Phone = @Phone AND StudentID != @StudentID";
            int count = DatabaseHelper.ExecuteScalar(query,
                new SqlParameter("@Phone", phone),
                new SqlParameter("@StudentID", studentID));
            return count == 0;
        }

        public void AddStudent(int? groupID, string firstName, string lastName, string email, string phone, DateTime dateOfBirth)
        {
            if (!IsEmailValid(email))
            {
                throw new Exception("Невірний формат email. Введіть коректний email.");
            }

            if (!IsEmailUnique(email))
            {
                throw new Exception("Цей email вже використовується. Введіть інший.");
            }

            if (!IsPhoneUnique(phone))
            {
                throw new Exception("Цей телефонний номер вже використовується. Введіть інший.");
            }

            DatabaseHelper.ExecuteNonQuery(
                "INSERT INTO Students (GroupID, FirstName, LastName, Email, Phone, DateOfBirth) VALUES (@GroupID, @FirstName, @LastName, @Email, @Phone, @DateOfBirth)",
                new SqlParameter("@GroupID", groupID ?? (object)DBNull.Value),
                new SqlParameter("@FirstName", firstName),
                new SqlParameter("@LastName", lastName),
                new SqlParameter("@Email", email),
                new SqlParameter("@Phone", phone),
                new SqlParameter("@DateOfBirth", dateOfBirth)
            );
        }

        public void EditStudent(int studentID, int? groupID, string firstName, string lastName, string email, string phone, DateTime dateOfBirth)
        {
            if (!IsEmailValid(email))
            {
                throw new Exception("Невірний формат email. Введіть коректний email.");
            }

            if (!IsEmailUnique(email, studentID))
            {
                throw new Exception("Цей email вже використовується іншим студентом. Введіть інший.");
            }

            if (!IsPhoneUnique(phone, studentID))
            {
                throw new Exception("Цей телефонний номер вже використовується іншим студентом. Введіть інший.");
            }

            DatabaseHelper.ExecuteNonQuery(
                "UPDATE Students SET GroupID = @GroupID, FirstName = @FirstName, LastName = @LastName, Email = @Email, Phone = @Phone, DateOfBirth = @DateOfBirth WHERE StudentID = @StudentID",
                new SqlParameter("@GroupID", groupID ?? (object)DBNull.Value),
                new SqlParameter("@FirstName", firstName),
                new SqlParameter("@LastName", lastName),
                new SqlParameter("@Email", email),
                new SqlParameter("@Phone", phone),
                new SqlParameter("@DateOfBirth", dateOfBirth),
                new SqlParameter("@StudentID", studentID)
            );
        }

        public void DeleteStudent(int studentID)
        {
            DatabaseHelper.ExecuteNonQuery(
                "DELETE FROM Grades WHERE StudentID = @StudentID",
                new SqlParameter("@StudentID", studentID)
            );

            DatabaseHelper.ExecuteNonQuery(
                "DELETE FROM Students WHERE StudentID = @StudentID",
                new SqlParameter("@StudentID", studentID)
            );
        }

        public DataTable FilterStudents(string searchQuery)
        {
            return DatabaseHelper.ExecuteQuery(
                @"SELECT StudentID, GroupID, FirstName, LastName, Email, Phone, DateOfBirth
                  FROM Students
                  WHERE FirstName LIKE @SearchQuery + '%' OR
                        LastName LIKE @SearchQuery + '%' OR
                        Email LIKE @SearchQuery + '%' OR
                        Phone LIKE @SearchQuery + '%' OR
                        CONVERT(varchar, DateOfBirth, 103) LIKE @SearchQuery + '%' OR
                        CONVERT(varchar, StudentID) LIKE @SearchQuery + '%' OR
                        CONVERT(varchar, GroupID) LIKE @SearchQuery + '%'",
                new SqlParameter("@SearchQuery", searchQuery)
            );
        }

        public int GetTotalStudents()
        {
            string query = "SELECT COUNT(*) FROM Students";
            return DatabaseHelper.ExecuteScalar(query);
        }

        public DataTable GetAverageGradesByCourse()
        {
            string query = @"
                SELECT c.CourseName, AVG(g.Grade) AS AverageGrade
                FROM Grades g
                JOIN Students s ON g.StudentID = s.StudentID
                JOIN Groups gr ON s.GroupID = gr.GroupID
                JOIN Courses c ON gr.CourseID = c.CourseID
                GROUP BY c.CourseName";

            return DatabaseHelper.ExecuteQuery(query);
        }
    }
}