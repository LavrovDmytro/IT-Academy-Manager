using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace ITAcademyManager
{
    public class SpecializationService
    {
        public DataTable LoadSpecializations()
        {
            return DatabaseHelper.ExecuteQuery("SELECT SpecializationID, SpecializationName FROM Specializations");
        }

        public DataTable LoadInstructorSpecializations()
        {
            string query = @"SELECT s.SpecializationName, i.FirstName + ' ' + i.LastName AS FullName
                         FROM Specializations s
                         INNER JOIN Instructors i ON s.SpecializationID = i.SpecializationID";
            return DatabaseHelper.ExecuteQuery(query);
        }

        public bool IsSpecializationNameUnique(string specializationName, int specializationID = -1)
        {
            string query = "SELECT COUNT(*) FROM Specializations WHERE SpecializationName = @SpecializationName AND SpecializationID != @SpecializationID";
            int count = DatabaseHelper.ExecuteScalar(query,
                new SqlParameter("@SpecializationName", specializationName),
                new SqlParameter("@SpecializationID", specializationID));
            return count == 0;
        }

        public void AddSpecialization(string specializationName)
        {
            if (!IsSpecializationNameUnique(specializationName))
            {
                throw new Exception("Спеціалізація з такою назвою вже існує.");
            }

            DatabaseHelper.ExecuteNonQuery(
                "INSERT INTO Specializations (SpecializationName) VALUES (@SpecializationName)",
                new SqlParameter("@SpecializationName", specializationName)
            );
        }

        public void EditSpecialization(int specializationID, string specializationName)
        {
            if (!IsSpecializationNameUnique(specializationName, specializationID))
            {
                throw new Exception("Спеціалізація з такою назвою вже існує.");
            }

            DatabaseHelper.ExecuteNonQuery(
                "UPDATE Specializations SET SpecializationName = @SpecializationName WHERE SpecializationID = @SpecializationID",
                new SqlParameter("@SpecializationName", specializationName),
                new SqlParameter("@SpecializationID", specializationID)
            );
        }

        public void DeleteSpecialization(int specializationID)
        {
            string updateInstructorsQuery = "UPDATE Instructors SET SpecializationID = NULL WHERE SpecializationID = @SpecializationID";
            string deleteSpecializationQuery = "DELETE FROM Specializations WHERE SpecializationID = @SpecializationID";

            DatabaseHelper.ExecuteNonQuery(updateInstructorsQuery, new SqlParameter("@SpecializationID", specializationID));
            DatabaseHelper.ExecuteNonQuery(deleteSpecializationQuery, new SqlParameter("@SpecializationID", specializationID));
        }

        public DataTable FilterSpecializations(string searchQuery)
        {
            string query = @"SELECT SpecializationID, SpecializationName
                         FROM Specializations
                         WHERE SpecializationName LIKE @SearchQuery + '%' OR
                               CAST(SpecializationID AS VARCHAR) LIKE @SearchQuery + '%'";
            return DatabaseHelper.ExecuteQuery(query, new SqlParameter("@SearchQuery", searchQuery));
        }

        public DataTable FilterInstructorSpecializations(string searchQuery)
        {
            string query = @"SELECT s.SpecializationName, i.FirstName + ' ' + i.LastName AS FullName
                         FROM Specializations s
                         INNER JOIN Instructors i ON s.SpecializationID = i.SpecializationID
                         WHERE s.SpecializationName LIKE @SearchQuery + '%' OR
                               CONCAT(i.FirstName, ' ', i.LastName) LIKE @SearchQuery + '%'";
            return DatabaseHelper.ExecuteQuery(query, new SqlParameter("@SearchQuery", searchQuery));
        }

        public DataTable FilterInstructorSpecializationsBySpecialization(string specializationName)
        {
            string query = @"SELECT s.SpecializationName, i.FirstName + ' ' + i.LastName AS FullName
                         FROM Specializations s
                         INNER JOIN Instructors i ON s.SpecializationID = i.SpecializationID
                         WHERE s.SpecializationName = @SpecializationName";
            return DatabaseHelper.ExecuteQuery(query, new SqlParameter("@SpecializationName", specializationName));
        }

        public List<string> LoadComboBoxSpecializations()
        {
            string query = @"SELECT DISTINCT s.SpecializationName
                         FROM Specializations s
                         INNER JOIN Instructors i ON s.SpecializationID = i.SpecializationID";
            var table = DatabaseHelper.ExecuteQuery(query);
            return table.Rows.Cast<DataRow>().Select(row => row["SpecializationName"].ToString()).ToList();
        }
    }
}