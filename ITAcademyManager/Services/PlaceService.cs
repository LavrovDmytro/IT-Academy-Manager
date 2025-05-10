using System;
using System.Data;
using System.Data.SqlClient;

namespace ITAcademyManager.Services
{
    public class PlaceService
    {
        public DataTable LoadPlaces()
        {
            return DatabaseHelper.ExecuteQuery("SELECT * FROM Places");
        }

        public bool IsPlaceNameUnique(string placeName, int placeID = -1)
        {
            string query = "SELECT COUNT(*) FROM Places WHERE PlaceName = @PlaceName AND PlaceID != @PlaceID";
            int count = DatabaseHelper.ExecuteScalar(query,
                new SqlParameter("@PlaceName", placeName),
                new SqlParameter("@PlaceID", placeID));
            return count == 0;
        }

        public void AddPlace(string placeName)
        {
            if (!IsPlaceNameUnique(placeName))
            {
                throw new Exception("Місце з такою назвою вже існує.");
            }

            DatabaseHelper.ExecuteNonQuery(
                "INSERT INTO Places (PlaceName) VALUES (@PlaceName)",
                new SqlParameter("@PlaceName", placeName)
            );
        }

        public void EditPlace(int placeID, string placeName)
        {
            if (!IsPlaceNameUnique(placeName, placeID))
            {
                throw new Exception("Місце з такою назвою вже існує.");
            }

            DatabaseHelper.ExecuteNonQuery(
                "UPDATE Places SET PlaceName = @PlaceName WHERE PlaceID = @PlaceID",
                new SqlParameter("@PlaceName", placeName),
                new SqlParameter("@PlaceID", placeID)
            );
        }

        public void DeletePlace(int placeID)
        {
            string updateScheduleQuery = "UPDATE Schedule SET PlaceID = NULL WHERE PlaceID = @PlaceID";
            DatabaseHelper.ExecuteNonQuery(updateScheduleQuery, new SqlParameter("@PlaceID", placeID));

            string deletePlaceQuery = "DELETE FROM Places WHERE PlaceID = @PlaceID";
            DatabaseHelper.ExecuteNonQuery(deletePlaceQuery, new SqlParameter("@PlaceID", placeID));
        }

        public DataTable FilterPlaces(string searchQuery)
        {
            return DatabaseHelper.ExecuteQuery(
                "SELECT * FROM Places WHERE PlaceID LIKE @SearchQuery + '%' OR PlaceName LIKE @SearchQuery + '%'",
                new SqlParameter("@SearchQuery", searchQuery)
            );
        }
    }
}