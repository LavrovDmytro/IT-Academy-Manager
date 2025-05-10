using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ITAcademyManager
{
    public class CourseService
    {
        public DataTable LoadCourses()
        {
            return DatabaseHelper.ExecuteQuery("SELECT CourseID, CourseName, Price, StartDate, EndDate FROM Courses");
        }

        public bool IsCourseNameUnique(string courseName, int courseID = -1)
        {
            string query = "SELECT COUNT(*) FROM Courses WHERE CourseName = @CourseName AND CourseID != @CourseID";
            int count = DatabaseHelper.ExecuteScalar(query,
                new SqlParameter("@CourseName", courseName),
                new SqlParameter("@CourseID", courseID));
            return count == 0;
        }

        public void AddCourse(string courseName, decimal price, DateTime startDate, DateTime endDate)
        {
            if (price < 0)
            {
                throw new Exception("Ціна не може бути від'ємною.");
            }

            if (!IsCourseNameUnique(courseName))
            {
                throw new Exception("Курс з такою назвою вже існує.");
            }

            DatabaseHelper.ExecuteNonQuery(
                "INSERT INTO Courses (CourseName, Price, StartDate, EndDate) VALUES (@CourseName, @Price, @StartDate, @EndDate)",
                new SqlParameter("@CourseName", courseName),
                new SqlParameter("@Price", price),
                new SqlParameter("@StartDate", startDate),
                new SqlParameter("@EndDate", endDate)
            );
        }

        public void EditCourse(int courseID, string courseName, decimal price, DateTime startDate, DateTime endDate)
        {
            if (price < 0)
            {
                throw new Exception("Ціна не може бути від'ємною.");
            }

            if (!IsCourseNameUnique(courseName, courseID))
            {
                throw new Exception("Курс з такою назвою вже існує.");
            }

            DatabaseHelper.ExecuteNonQuery(
                "UPDATE Courses SET CourseName = @CourseName, Price = @Price, StartDate = @StartDate, EndDate = @EndDate WHERE CourseID = @CourseID",
                new SqlParameter("@CourseID", courseID),
                new SqlParameter("@CourseName", courseName),
                new SqlParameter("@Price", price),
                new SqlParameter("@StartDate", startDate),
                new SqlParameter("@EndDate", endDate)
            );
        }

        public void DeleteCourse(int courseID)
        {
            DatabaseHelper.ExecuteNonQuery(
                "DELETE FROM Courses WHERE CourseID = @CourseID",
                new SqlParameter("@CourseID", courseID)
            );
        }

        public DataTable FilterCourses(string searchQuery)
        {
            return DatabaseHelper.ExecuteQuery(
                @"SELECT CourseID, CourseName, Price, StartDate, EndDate FROM Courses
                   WHERE CourseName LIKE @SearchQuery + '%' OR
                         CONVERT(varchar, CourseID) LIKE @SearchQuery + '%' OR
                         CONVERT(varchar, Price) LIKE @SearchQuery + '%' OR
                         CONVERT(varchar, StartDate, 103) LIKE @SearchQuery + '%' OR
                         CONVERT(varchar, EndDate, 103) LIKE @SearchQuery + '%'",
                new SqlParameter("@SearchQuery", searchQuery)
            );
        }

        public void DeleteRelatedData(int courseID)
        {
            DatabaseHelper.ExecuteNonQuery(
                "DELETE FROM Schedule WHERE GroupID IN (SELECT GroupID FROM Groups WHERE CourseID = @CourseID)",
                new SqlParameter("@CourseID", courseID)
            );

            DatabaseHelper.ExecuteNonQuery(
                "DELETE FROM Grades WHERE StudentID IN (SELECT StudentID FROM Students WHERE GroupID IN (SELECT GroupID FROM Groups WHERE CourseID = @CourseID))",
                new SqlParameter("@CourseID", courseID)
            );

            DatabaseHelper.ExecuteNonQuery(
                "DELETE FROM Students WHERE GroupID IN (SELECT GroupID FROM Groups WHERE CourseID = @CourseID)",
                new SqlParameter("@CourseID", courseID)
            );

            DatabaseHelper.ExecuteNonQuery(
                "DELETE FROM Groups WHERE CourseID = @CourseID",
                new SqlParameter("@CourseID", courseID)
            );
        }

        public int GetTotalCourses()
        {
            string query = "SELECT COUNT(*) FROM Courses";
            return DatabaseHelper.ExecuteScalar(query);
        }

        public DataTable GetGroupCapacity()
        {
            string query = @"
            SELECT g.GroupName, COUNT(s.StudentID) AS StudentCount
            FROM Groups g
            LEFT JOIN Students s ON g.GroupID = s.GroupID
            GROUP BY g.GroupName";

            return DatabaseHelper.ExecuteQuery(query);
        }
    }
}