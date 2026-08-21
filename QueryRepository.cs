using System.Data;
using System.Data.SqlClient;
using FatasyRPGApp.FantasyRPGDBDataSetTableAdapters;

namespace FatasyRPGApp
{
    /// <summary>
    /// Provides database query operations used by the query form.
    /// </summary>
    public class QueryRepository
    {
        private readonly string connectionString;
        private readonly CharactersTableAdapter charactersTableAdapter;

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="QueryRepository"/> class.
        /// </summary>
        public QueryRepository()
        {
            connectionString =
                Properties.Settings.Default.FantasyRPGDBConnectionString;

            charactersTableAdapter =
                new CharactersTableAdapter();
        }

        /// <summary>
        /// Retrieves all characters from the database.
        /// </summary>
        /// <returns>
        /// A data table containing all character records.
        /// </returns>
        public DataTable GetAllCharacters()
        {
            return charactersTableAdapter.GetAllCharacters();
        }

        /// <summary>
        /// Retrieves characters whose level meets the
        /// application's high-level query criteria.
        /// </summary>
        /// <returns>
        /// A data table containing high-level characters.
        /// </returns>
        public DataTable GetHighLevelCharacters()
        {
            return charactersTableAdapter.GetHighLevelCharacters();
        }

        /// <summary>
        /// Retrieves character names, levels, and their associated
        /// class names using a database join.
        /// </summary>
        /// <returns>
        /// A table containing joined character and class information.
        /// </returns>
        public DataTable GetCharactersWithClasses()
        {
            const string query =
                @"SELECT Characters.CharacterName,
                         Characters.Level,
                         Classes.ClassName
                  FROM Characters
                  INNER JOIN Classes
                      ON Characters.ClassID = Classes.ClassID";

            using (SqlConnection connection =
                   new SqlConnection(connectionString))
            using (SqlDataAdapter adapter =
                   new SqlDataAdapter(query, connection))
            {
                DataTable results = new DataTable();

                adapter.Fill(results);

                return results;
            }
        }
    }
}
