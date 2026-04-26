using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;
using FatasyRPGApp.FantasyRPGDBDataSetTableAdapters;

namespace FatasyRPGApp
{
    // QueriesForm is responsible for executing database queries
    // and displaying the results in a DataGridView
    public partial class QueriesForm : Form
    {
        // TableAdapter used to interact with the Characters table
        // This allows us to run predefined queries created in the dataset designer
        private CharactersTableAdapter charactersTableAdapter =
            new CharactersTableAdapter();

        // Connection string used to connect to the SQL Server database
        // This is used for manual SQL queries such as JOIN operations
        private string connectionString =
            @"Data Source=localhost\SQLEXPRESS;Initial Catalog=FantasyRPGDB;Integrated Security=True;TrustServerCertificate=True";

        // Constructor initializes the form and its components
        public QueriesForm()
        {
            InitializeComponent();
        }

        // This method is triggered when the "Show All Characters" button is clicked
        // It retrieves all character records from the database using a TableAdapter query
        private void btnAllCharacters_Click(object sender, EventArgs e)
        {
            // Stopwatch is used to measure performance of the query execution
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            // The DataGridView is populated with all character data
            dgvQueryResults.DataSource = charactersTableAdapter.GetAllCharacters();

            // Stop timing after the query completes
            stopwatch.Stop();

            // Display how long the query took to execute
            MessageBox.Show("All characters query completed in " + stopwatch.ElapsedMilliseconds + " ms.");
        }

        // This method is triggered when the "Level > 10" button is clicked
        // It retrieves only characters above level 10 using a filtered query
        private void btnHighLevel_Click(object sender, EventArgs e)
        {
            // Start performance timing
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            // Load only high-level characters into the DataGridView
            dgvQueryResults.DataSource = charactersTableAdapter.GetHighLevelCharacters();

            // Stop timing after query finishes
            stopwatch.Stop();

            // Display execution time to the user
            MessageBox.Show("High level characters query completed in " + stopwatch.ElapsedMilliseconds + " ms.");
        }

        // This method is triggered when the "Characters + Classes" button is clicked
        // It performs a JOIN query to combine data from the Characters and Classes tables
        private void btnJoin_Click(object sender, EventArgs e)
        {
            // Start measuring query execution time
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            // SQL JOIN query that combines character data with class names
            // This query retrieves character name, level, and corresponding class name
            string query = @"SELECT Characters.CharacterName, Characters.Level, Classes.ClassName
                     FROM Characters
                     INNER JOIN Classes ON Characters.ClassID = Classes.ClassID";

            // Create a connection to the SQL Server database
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // SqlDataAdapter is used to execute the query and fill a DataTable
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                // DataTable will store the results of the query
                DataTable dt = new DataTable();

                // Execute the query and fill the DataTable with results
                adapter.Fill(dt);

                // Bind the DataTable to the DataGridView to display results
                dgvQueryResults.DataSource = dt;
            }

            // Stop timing after query execution is complete
            stopwatch.Stop();

            // Show how long the JOIN query took
            MessageBox.Show("Join query completed in " + stopwatch.ElapsedMilliseconds + " ms.");
        }
    }
}
