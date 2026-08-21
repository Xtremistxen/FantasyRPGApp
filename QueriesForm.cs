using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;


namespace FatasyRPGApp
{
    /// <summary>
    /// Provides database query tools for retrieving and displaying
    /// character and class information from the Fantasy RPG database.
    /// The form also measures the execution time of each query.
    /// </summary>
    public partial class QueriesForm : Form
    {
        /// <summary>
        /// Provides access to database queries used by this form.
        /// </summary>
        private readonly QueryRepository queryRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="QueriesForm"/> class.
        /// </summary>
        public QueriesForm()
        {
            InitializeComponent();
            queryRepository = new QueryRepository();
        }

        /// <summary>
        /// Retrieves all character records from the database,
        /// displays them in the query results grid, and reports
        /// the query execution time.
        /// </summary>
        /// <param name="sender">
        /// The control that triggered the event.
        /// </param>
        /// <param name="e">
        /// The event data associated with the button click.
        /// </param>
        private void btnAllCharacters_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            try
            {
                dgvQueryResults.DataSource =
                    queryRepository.GetAllCharacters();

                stopwatch.Stop();

                ShowQueryPerformance(
                    "All characters",
                    stopwatch.ElapsedMilliseconds);
            }
            catch (SqlException ex)
            {
                stopwatch.Stop();

                ShowDatabaseError(ex);
            }
        }

        /// <summary>
        /// Retrieves characters above level 10 from the database,
        /// displays them in the query results grid, and reports
        /// the query execution time.
        /// </summary>
        /// <param name="sender">
        /// The control that triggered the event.
        /// </param>
        /// <param name="e">
        /// The event data associated with the button click.
        /// </param>
        private void btnHighLevel_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            try
            {
                dgvQueryResults.DataSource =
                    queryRepository.GetHighLevelCharacters();

                stopwatch.Stop();

                ShowQueryPerformance(
                    "High level characters",
                    stopwatch.ElapsedMilliseconds);
            }
            catch (SqlException ex)
            {
                stopwatch.Stop();

                ShowDatabaseError(ex);
            }
        }

        /// <summary>
        /// Executes a SQL INNER JOIN between the Characters and Classes
        /// tables, displays each character with their associated class,
        /// and reports the query execution time.
        /// </summary>
        /// <param name="sender">
        /// The control that triggered the event.
        /// </param>
        /// <param name="e">
        /// The event data associated with the button click.
        /// </param>
        private void btnJoin_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            try
            {
                dgvQueryResults.DataSource =
                    queryRepository.GetCharactersWithClasses();

                stopwatch.Stop();

                ShowQueryPerformance(
                    "Character and class join",
                    stopwatch.ElapsedMilliseconds);
            }
            catch (SqlException ex)
            {
                stopwatch.Stop();

                ShowDatabaseError(ex);
            }
        }

        /// <summary>
        /// Displays the execution time of a completed database query.
        /// </summary>
        /// <param name="queryName">
        /// The user-friendly name of the query.
        /// </param>
        /// <param name="elapsedMilliseconds">
        /// The query execution time in milliseconds.
        /// </param>
        private void ShowQueryPerformance(
            string queryName,
            long elapsedMilliseconds)
        {
            MessageBox.Show(
                $"{queryName} query completed in " +
                $"{elapsedMilliseconds} ms.",
                "Query Complete",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        /// <summary>
        /// Displays a consistent error message when a database operation fails.
        /// </summary>
        /// <param name="exception">
        /// The SQL exception that caused the database operation to fail.
        /// </param>
        private void ShowDatabaseError(SqlException exception)
        {
            MessageBox.Show(
                "The database query could not be completed.\n\n" +
                exception.Message,
                "Database Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    } 
}
    

