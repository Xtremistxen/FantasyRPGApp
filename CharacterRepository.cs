using System;
using System.Data;
using System.Data.SqlClient;

namespace FatasyRPGApp
{
    /// <summary>
    /// Provides database operations for character records
    /// in the Fantasy RPG application.
    /// </summary>
    public class CharacterRepository
    {
        /// <summary>
        /// Stores the connection string used to access
        /// the Fantasy RPG database.
        /// </summary>
        private readonly string connectionString;

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="CharacterRepository"/> class.
        /// </summary>
        public CharacterRepository()
        {
            connectionString =
                Properties.Settings.Default.FantasyRPGDBConnectionString;
        }

        /// <summary>
        /// Saves a new character to the Characters table.
        /// </summary>
        /// <param name="characterName">
        /// The name of the character.
        /// </param>
        /// <param name="level">
        /// The character's current level.
        /// </param>
        /// <param name="classId">
        /// The identifier of the character's selected class.
        /// </param>
        public void AddCharacter(
            string characterName,
            int level,
            int classId)
        {
            const string query =
                "INSERT INTO Characters " +
                "(CharacterName, Level, ClassID) " +
                "VALUES (@name, @level, @classId)";

            using (SqlConnection connection =
                   new SqlConnection(connectionString))
            using (SqlCommand command =
                   new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue(
                    "@name",
                    characterName);

                command.Parameters.AddWithValue(
                    "@level",
                    level);

                command.Parameters.AddWithValue(
                    "@classId",
                    classId);

                connection.Open();

                command.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Deletes character records that match the specified character name.
        /// </summary>
        /// <param name="characterName">
        /// The name of the character to delete.
        /// </param>
        public void DeleteCharacterByName(string characterName)
        {
            const string query =
                "DELETE FROM Characters " +
                "WHERE CharacterName = @name";

            using (SqlConnection connection =
                   new SqlConnection(connectionString))
            using (SqlCommand command =
                   new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue(
                    "@name",
                    characterName);

                connection.Open();

                command.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Retrieves all available character classes
        /// from the Classes table.
        /// </summary>
        /// <returns>
        /// A table containing the class identifiers and class names.
        /// </returns>
        public DataTable GetClasses()
        {
            const string query =
                "SELECT ClassID, ClassName " +
                "FROM Classes " +
                "ORDER BY ClassName";

            using (SqlConnection connection =
                   new SqlConnection(connectionString))
            using (SqlDataAdapter adapter =
                   new SqlDataAdapter(query, connection))
            {
                DataTable classes = new DataTable();

                adapter.Fill(classes);

                return classes;
            }
        }
    }
}
