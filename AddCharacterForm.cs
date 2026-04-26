using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FatasyRPGApp
{
    public partial class AddCharacterForm : Form
    {
        // Connection string used to connect to the SQL Server FantasyRPGDB database
        private string connectionString =
            @"Data Source=localhost\SQLEXPRESS;Initial Catalog=FantasyRPGDB;Integrated Security=True;TrustServerCertificate=True";

        public AddCharacterForm()
        {
            InitializeComponent();
        }

        private void btnSaveCharacter_Click(object sender, EventArgs e)
        {
            // Validate that the character name is not blank
            if (txtCharacterName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter a character name.");
                return;
            }

            // Validate that level is a number
            if (!int.TryParse(txtLevel.Text, out int level))
            {
                MessageBox.Show("Please enter a valid number for level.");
                return;
            }

            // Validate that class ID is a number
            if (!int.TryParse(txtClassId.Text, out int classId))
            {
                MessageBox.Show("Please enter a valid number for class ID.");
                return;
            }

            // SQL INSERT statement that adds a new character record to the database
            string query = "INSERT INTO Characters (CharacterName, Level, ClassID) VALUES (@name, @level, @classId)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    // Parameters help protect the database from bad input and SQL injection
                    command.Parameters.AddWithValue("@name", txtCharacterName.Text);
                    command.Parameters.AddWithValue("@level", level);
                    command.Parameters.AddWithValue("@classId", classId);

                    command.ExecuteNonQuery();
                }
            }
            // Shows we added the character successfully and can be seen in the query
            MessageBox.Show("Character added successfully!");

            txtCharacterName.Clear();
            txtLevel.Clear();
            txtClassId.Clear();
        }
    }
}
