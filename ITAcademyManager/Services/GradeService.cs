using System;
using System.Data;
using System.Data.SqlClient;

namespace ITAcademyManager
{
    public class GradeService
    {
        public DataTable LoadCourses()
        {
            return DatabaseHelper.ExecuteQuery("SELECT CourseID, CourseName FROM Courses");
        }

        public DataTable LoadGroupsByCourse(int courseID)
        {
            return DatabaseHelper.ExecuteQuery(
                "SELECT GroupID, GroupName FROM Groups WHERE CourseID = @CourseID",
                new SqlParameter("@CourseID", courseID)
            );
        }

        public DataTable LoadStudentsByGroup(int groupID)
        {
            return DatabaseHelper.ExecuteQuery(
                "SELECT StudentID, FirstName + ' ' + LastName AS FullName FROM Students WHERE GroupID = @GroupID",
                new SqlParameter("@GroupID", groupID)
            );
        }

        public DataTable LoadGradesForStudent(int studentID)
        {
            return DatabaseHelper.ExecuteQuery(
                @"SELECT GradeID, StudentID, Grade, Date
                  FROM Grades
                  WHERE StudentID = @StudentID",
                new SqlParameter("@StudentID", studentID)
            );
        }

        public double CalculateAverageGrade(int studentID)
        {
            var grades = LoadGradesForStudent(studentID);
            if (grades.Rows.Count > 0)
            {
                double totalGrade = 0;
                foreach (DataRow row in grades.Rows)
                {
                    totalGrade += Convert.ToDouble(row["Grade"]);
                }
                return totalGrade / grades.Rows.Count;
            }
            return 0;
        }

        public void AddGrade(int studentID, decimal grade, DateTime date)
        {
            DatabaseHelper.ExecuteNonQuery(
                "INSERT INTO Grades (StudentID, Grade, Date) VALUES (@StudentID, @Grade, @Date)",
                new SqlParameter("@StudentID", studentID),
                new SqlParameter("@Grade", grade),
                new SqlParameter("@Date", date)
            );
        }

        public void EditGrade(int gradeID, int studentID, decimal grade, DateTime date)
        {
            DatabaseHelper.ExecuteNonQuery(
                "UPDATE Grades SET StudentID = @StudentID, Grade = @Grade, Date = @Date WHERE GradeID = @GradeID",
                new SqlParameter("@GradeID", gradeID),
                new SqlParameter("@StudentID", studentID),
                new SqlParameter("@Grade", grade),
                new SqlParameter("@Date", date)
            );
        }

        public void DeleteGrade(int gradeID)
        {
            DatabaseHelper.ExecuteNonQuery(
                "DELETE FROM Grades WHERE GradeID = @GradeID",
                new SqlParameter("@GradeID", gradeID)
            );
        }
    }
}