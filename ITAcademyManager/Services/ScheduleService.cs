using System;
using System.Data;
using System.Data.SqlClient;

namespace ITAcademyManager
{
    public class ScheduleService
    {
        public DataTable LoadSchedule()
        {
            string query = @"
            SELECT s.ScheduleID, 
                   s.InstructorID, 
                   s.GroupID, 
                   s.PlaceID,
                   COALESCE(i.FirstName + ' ' + i.LastName, '') AS InstructorName, 
                   g.GroupName, 
                   COALESCE(p.PlaceName, '') AS PlaceName, 
                   s.Date, 
                   CONVERT(VARCHAR, s.StartTime, 108) AS StartTime, 
                   CONVERT(VARCHAR, s.EndTime, 108) AS EndTime, 
                   s.Status
            FROM Schedule s
            LEFT JOIN Instructors i ON s.InstructorID = i.InstructorID
            JOIN Groups g ON s.GroupID = g.GroupID
            LEFT JOIN Places p ON s.PlaceID = p.PlaceID";

            return DatabaseHelper.ExecuteQuery(query);
        }

        public DataTable LoadInstructors()
        {
            string query = "SELECT InstructorID, FirstName + ' ' + LastName AS InstructorName FROM Instructors";
            return DatabaseHelper.ExecuteQuery(query);
        }

        public DataTable LoadGroups()
        {
            string query = "SELECT GroupID, GroupName FROM Groups";
            return DatabaseHelper.ExecuteQuery(query);
        }

        public DataTable LoadPlaces()
        {
            string query = "SELECT PlaceID, PlaceName FROM Places";
            return DatabaseHelper.ExecuteQuery(query);
        }

        public void AddSchedule(int instructorID, int groupID, int placeID, DateTime date, TimeSpan startTime, TimeSpan endTime, string status)
        {
            string query = @"
            INSERT INTO Schedule (InstructorID, GroupID, PlaceID, Date, StartTime, EndTime, Status)
            VALUES (@InstructorID, @GroupID, @PlaceID, @Date, @StartTime, @EndTime, @Status)";

            SqlParameter[] parameters =
            {
                new SqlParameter("@InstructorID", instructorID),
                new SqlParameter("@GroupID", groupID),
                new SqlParameter("@PlaceID", placeID),
                new SqlParameter("@Date", date),
                new SqlParameter("@StartTime", startTime),
                new SqlParameter("@EndTime", endTime),
                new SqlParameter("@Status", status)
            };

            DatabaseHelper.ExecuteNonQuery(query, parameters);
        }

        public void EditSchedule(int scheduleID, int instructorID, int groupID, int placeID, DateTime date, TimeSpan startTime, TimeSpan endTime, string status)
        {
            string query = @"
            UPDATE Schedule 
            SET InstructorID = @InstructorID, 
                GroupID = @GroupID, 
                PlaceID = @PlaceID, 
                Date = @Date, 
                StartTime = @StartTime, 
                EndTime = @EndTime,
                Status = @Status
            WHERE ScheduleID = @ScheduleID";

            SqlParameter[] parameters =
            {
                new SqlParameter("@InstructorID", instructorID),
                new SqlParameter("@GroupID", groupID),
                new SqlParameter("@PlaceID", placeID),
                new SqlParameter("@Date", date),
                new SqlParameter("@StartTime", startTime),
                new SqlParameter("@EndTime", endTime),
                new SqlParameter("@Status", status),
                new SqlParameter("@ScheduleID", scheduleID)
            };

            DatabaseHelper.ExecuteNonQuery(query, parameters);
        }

        public void DeleteSchedule(int scheduleID)
        {
            string query = "DELETE FROM Schedule WHERE ScheduleID = @ScheduleID";
            SqlParameter[] parameters = { new SqlParameter("@ScheduleID", scheduleID) };
            DatabaseHelper.ExecuteNonQuery(query, parameters);
        }

        public DataTable FilterSchedule(string searchQuery)
        {
            string query = @"
            SELECT s.ScheduleID, 
                   s.InstructorID, 
                   s.GroupID, 
                   s.PlaceID,
                   COALESCE(i.FirstName + ' ' + i.LastName, 'Без інструктора') AS InstructorName, 
                   g.GroupName, 
                   COALESCE(p.PlaceName, '') AS PlaceName, 
                   s.Date, 
                   CONVERT(VARCHAR, s.StartTime, 108) AS StartTime, 
                   CONVERT(VARCHAR, s.EndTime, 108) AS EndTime, 
                   s.Status
            FROM Schedule s
            LEFT JOIN Instructors i ON s.InstructorID = i.InstructorID
            JOIN Groups g ON s.GroupID = g.GroupID
            LEFT JOIN Places p ON s.PlaceID = p.PlaceID
            WHERE (COALESCE(i.FirstName + ' ' + i.LastName, 'Без інструктора') LIKE '%' + @SearchQuery + '%') OR
                  (g.GroupName LIKE '%' + @SearchQuery + '%') OR
                  (COALESCE(p.PlaceName, '') LIKE '%' + @SearchQuery + '%') OR
                  (CONVERT(VARCHAR, s.Date, 103) LIKE '%' + @SearchQuery + '%') OR
                  (CONVERT(VARCHAR, s.StartTime, 108) LIKE '%' + @SearchQuery + '%') OR
                  (CONVERT(VARCHAR, s.EndTime, 108) LIKE '%' + @SearchQuery + '%') OR
                  (s.Status LIKE '%' + @SearchQuery + '%')";

            SqlParameter[] parameters = { new SqlParameter("@SearchQuery", searchQuery) };
            return DatabaseHelper.ExecuteQuery(query, parameters);
        }

        public int GetScheduledCount()
        {
            string query = "SELECT COUNT(*) FROM Schedule WHERE Status = 'Scheduled'";
            return DatabaseHelper.ExecuteScalar(query);
        }
    }
}