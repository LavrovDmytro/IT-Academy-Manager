using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITAcademyManager.Services
{
    public class GroupService
    {
        public DataTable LoadGroups()
        {
            string query = @"SELECT g.GroupID, g.CourseID, g.GroupName, c.CourseName
                         FROM Groups g
                         INNER JOIN Courses c ON g.CourseID = c.CourseID";
            return DatabaseHelper.ExecuteQuery(query);
        }

        public DataTable LoadCourses()
        {
            return DatabaseHelper.ExecuteQuery("SELECT CourseID, CourseName FROM Courses");
        }

        public DataTable LoadStudentsByGroup(int groupID)
        {
            string query = @"SELECT s.StudentID, 
                         s.FirstName + ' ' + s.LastName AS FullName,
                         ISNULL(FORMAT(AVG(g.Grade), '0.00'), '0.00') AS AverageGrade
                         FROM Students s
                         LEFT JOIN Grades g ON s.StudentID = g.StudentID
                         WHERE s.GroupID = @GroupID
                         GROUP BY s.StudentID, s.FirstName, s.LastName";
            return DatabaseHelper.ExecuteQuery(query, new SqlParameter("@GroupID", groupID));
        }

        public bool IsGroupNameUnique(string groupName, int groupID = -1)
        {
            string query = "SELECT COUNT(*) FROM Groups WHERE GroupName = @GroupName AND GroupID != @GroupID";
            int count = DatabaseHelper.ExecuteScalar(query,
                new SqlParameter("@GroupName", groupName),
                new SqlParameter("@GroupID", groupID));
            return count == 0;
        }

        public void AddGroup(int courseID, string groupName)
        {
            if (!IsGroupNameUnique(groupName))
            {
                throw new Exception("Група з такою назвою вже існує.");
            }

            DatabaseHelper.ExecuteNonQuery(
                "INSERT INTO Groups (CourseID, GroupName) VALUES (@CourseID, @GroupName)",
                new SqlParameter("@CourseID", courseID),
                new SqlParameter("@GroupName", groupName)
            );
        }

        public void EditGroup(int groupID, int courseID, string groupName)
        {
            if (!IsGroupNameUnique(groupName, groupID))
            {
                throw new Exception("Група з такою назвою вже існує.");
            }

            DatabaseHelper.ExecuteNonQuery(
                "UPDATE Groups SET CourseID = @CourseID, GroupName = @GroupName WHERE GroupID = @GroupID",
                new SqlParameter("@CourseID", courseID),
                new SqlParameter("@GroupName", groupName),
                new SqlParameter("@GroupID", groupID)
            );
        }

        public void DeleteGroup(int groupID)
        {
            DatabaseHelper.ExecuteNonQuery(
                "UPDATE Students SET GroupID = NULL WHERE GroupID = @GroupID",
                new SqlParameter("@GroupID", groupID)
            );

            DatabaseHelper.ExecuteNonQuery(
                "DELETE FROM Schedule WHERE GroupID = @GroupID",
                new SqlParameter("@GroupID", groupID)
            );

            DatabaseHelper.ExecuteNonQuery(
                "DELETE FROM Groups WHERE GroupID = @GroupID",
                new SqlParameter("@GroupID", groupID)
            );
        }

        public DataTable FilterGroups(string searchQuery)
        {
            string query = @"SELECT g.GroupID, g.CourseID, g.GroupName, c.CourseName
                         FROM Groups g
                         INNER JOIN Courses c ON g.CourseID = c.CourseID
                         WHERE g.GroupName LIKE @SearchQuery + '%' OR
                               CONVERT(varchar, g.GroupID) LIKE @SearchQuery + '%' OR
                               CONVERT(varchar, g.CourseID) LIKE @SearchQuery + '%' OR
                               c.CourseName LIKE @SearchQuery + '%'";
            return DatabaseHelper.ExecuteQuery(query, new SqlParameter("@SearchQuery", searchQuery));
        }

        public DataTable FilterStudentsByGroup(int groupID, string searchQuery)
        {
            string query = @"SELECT s.StudentID, 
                         s.FirstName + ' ' + s.LastName AS FullName,
                         ISNULL(FORMAT(AVG(g.Grade), '0.00'), '0.00') AS AverageGrade
                         FROM Students s
                         LEFT JOIN Grades g ON s.StudentID = g.StudentID
                         WHERE s.GroupID = @GroupID
                         AND (s.FirstName + ' ' + s.LastName LIKE @SearchQuery + '%' OR
                              CONVERT(varchar, s.StudentID) LIKE @SearchQuery + '%')
                         GROUP BY s.StudentID, s.FirstName, s.LastName";
            return DatabaseHelper.ExecuteQuery(query,
                new SqlParameter("@GroupID", groupID),
                new SqlParameter("@SearchQuery", searchQuery));
        }
    }
}
