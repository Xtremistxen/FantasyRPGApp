using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using FatasyRPGApp.FantasyRPGDBDataSetTableAdapters;

namespace FatasyRPGApp
{
    public partial class QueriesForm : Form
    {
        private CharactersTableAdapter charactersTableAdapter =
            new CharactersTableAdapter();

        private string connectionString =
            @"Data Source=localhost\SQLEXPRESS;Initial Catalog=FantasyRPGDB;Integrated Security=True;TrustServerCertificate=True";

        public QueriesForm()
        {
            InitializeComponent();
        }

        private void btnAllCharacters_Click(object sender, EventArgs e)
        {
            dgvQueryResults.DataSource = charactersTableAdapter.GetAllCharacters();
        }

        private void btnHighLevel_Click(object sender, EventArgs e)
        {
            dgvQueryResults.DataSource = charactersTableAdapter.GetHighLevelCharacters();
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            string query = @"SELECT Characters.CharacterName, Characters.Level, Classes.ClassName
                             FROM Characters
                             INNER JOIN Classes ON Characters.ClassID = Classes.ClassID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvQueryResults.DataSource = dt;
            }
        }
    }
}
