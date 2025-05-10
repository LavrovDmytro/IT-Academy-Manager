using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ITAcademyManager
{
    public class InstructorService
    {
        public DataTable LoadInstructors()
        {
            return DatabaseHelper.ExecuteQuery(
                @"SELECT i.InstructorID, 
                     ISNULL(i.SpecializationID, '') AS SpecializationID, 
                     i.LastName, 
                     i.FirstName, 
                     i.MiddleName, 
                     i.Phone, 
                     i.Experience, 
                     COALESCE(s.SpecializationName, '') AS SpecializationName
              FROM Instructors i
              LEFT JOIN Specializations s ON i.SpecializationID = s.SpecializationID"
            );
        }

        public DataTable LoadSpecializations()
        {
            return DatabaseHelper.ExecuteQuery("SELECT SpecializationID, SpecializationName FROM Specializations");
        }

        public bool IsPhoneUnique(string phone, int instructorID = -1)
        {
            string query = "SELECT COUNT(*) FROM Instructors WHERE Phone = @Phone AND InstructorID != @InstructorID";
            int count = DatabaseHelper.ExecuteScalar(query,
                new SqlParameter("@Phone", phone),
                new SqlParameter("@InstructorID", instructorID));
            return count == 0;
        }

        public void AddInstructor(int? specializationID, string lastName, string firstName, string middleName, string phone, string experience)
        {
            if (!IsPhoneUnique(phone))
            {
                throw new Exception("Цей номер телефону вже використовується іншим інструктором.");
            }

            DatabaseHelper.ExecuteNonQuery(
                @"INSERT INTO Instructors (SpecializationID, LastName, FirstName, MiddleName, Phone, Experience)
          VALUES (@SpecializationID, @LastName, @FirstName, @MiddleName, @Phone, @Experience)",
                new SqlParameter("@SpecializationID", specializationID ?? (object)DBNull.Value),
                new SqlParameter("@LastName", lastName),
                new SqlParameter("@FirstName", firstName),
                new SqlParameter("@MiddleName", middleName),
                new SqlParameter("@Phone", phone),
                new SqlParameter("@Experience", experience)
            );
        }

        public void EditInstructor(int instructorID, int? specializationID, string lastName, string firstName, string middleName, string phone, string experience)
        {
            if (!IsPhoneUnique(phone, instructorID))
            {
                throw new Exception("Цей номер телефону вже використовується іншим інструктором.");
            }

            DatabaseHelper.ExecuteNonQuery(
                @"UPDATE Instructors 
          SET SpecializationID = @SpecializationID, LastName = @LastName, FirstName = @FirstName, 
              MiddleName = @MiddleName, Phone = @Phone, Experience = @Experience
          WHERE InstructorID = @InstructorID",
                new SqlParameter("@SpecializationID", specializationID ?? (object)DBNull.Value),
                new SqlParameter("@LastName", lastName),
                new SqlParameter("@FirstName", firstName),
                new SqlParameter("@MiddleName", middleName),
                new SqlParameter("@Phone", phone),
                new SqlParameter("@Experience", experience),
                new SqlParameter("@InstructorID", instructorID)
            );
        }

        public void DeleteInstructor(int instructorID)
        {
            try
            {
                string updateScheduleQuery = @"
                    UPDATE Schedule 
                    SET InstructorID = NULL 
                    WHERE InstructorID = @InstructorID";
                DatabaseHelper.ExecuteNonQuery(updateScheduleQuery, new SqlParameter("@InstructorID", instructorID));

                string deleteInstructorQuery = @"
                    DELETE FROM Instructors 
                    WHERE InstructorID = @InstructorID";
                DatabaseHelper.ExecuteNonQuery(deleteInstructorQuery, new SqlParameter("@InstructorID", instructorID));
            }
            catch (Exception ex)
            {
                throw new Exception($"Помилка при видаленні інструктора: {ex.Message}");
            }
        }

        public DataTable FilterInstructors(string searchQuery)
        {
            return DatabaseHelper.ExecuteQuery(
                @"SELECT i.InstructorID, i.SpecializationID, i.LastName, i.FirstName, i.MiddleName, i.Phone, i.Experience, s.SpecializationName
                  FROM Instructors i
                  JOIN Specializations s ON i.SpecializationID = s.SpecializationID
                  WHERE (i.InstructorID LIKE '%' + @SearchQuery + '%') OR
                        (CAST(i.SpecializationID AS VARCHAR) LIKE '%' + @SearchQuery + '%') OR
                        (i.LastName + ' ' + i.FirstName + ' ' + i.MiddleName LIKE '%' + @SearchQuery + '%') OR
                        (s.SpecializationName LIKE '%' + @SearchQuery + '%') OR
                        (i.Phone LIKE '%' + @SearchQuery + '%') OR
                        (i.Experience LIKE '%' + @SearchQuery + '%')",
                new SqlParameter("@SearchQuery", searchQuery)
            );
        }

        public int GetTotalInstructors()
        {
            string query = "SELECT COUNT(*) FROM Instructors";
            return DatabaseHelper.ExecuteScalar(query);
        }
    }
}