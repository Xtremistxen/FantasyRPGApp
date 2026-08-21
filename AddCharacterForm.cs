using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FatasyRPGApp
{
    /// <summary>
    /// Provides the user interface for creating and saving
    /// new character records to the Fantasy RPG database.
    /// </summary>
    public partial class AddCharacterForm : Form
    {
        /// <summary>
        /// Provides access to character-related database operations.
        /// </summary>
        private readonly CharacterRepository characterRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="AddCharacterForm"/> class.
        /// </summary>
        public AddCharacterForm()
        {
            InitializeComponent();
            characterRepository = new CharacterRepository();
            LoadClasses();
        }

        /// <summary>
        /// Loads available character classes from the database
        /// and displays them in the class selection ComboBox.
        /// </summary>
        private void LoadClasses()
        {
            try
            {
                DataTable classes =
                    characterRepository.GetClasses();

                cmbClass.DataSource = classes;
                cmbClass.DisplayMember = "ClassName";
                cmbClass.ValueMember = "ClassID";

                cmbClass.SelectedIndex = -1;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "The character classes could not be loaded.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Validates the entered character information and saves
        /// a new character record to the database.
        /// </summary>
        /// <param name="sender">
        /// The control that triggered the event.
        /// </param>
        /// <param name="e">
        /// The event data associated with the button click.
        /// </param>
        private void btnSaveCharacter_Click(object sender, EventArgs e)
        {
            string characterName = txtCharacterName.Text.Trim();

            if (string.IsNullOrEmpty(characterName))
            {
                MessageBox.Show(
                    "Please enter a character name.",
                    "Invalid Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (!int.TryParse(txtLevel.Text, out int level) || level <= 0)
            {
                MessageBox.Show(
                    "Please enter a valid character level greater than 0.",
                    "Invalid Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (cmbClass.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please select a character class.",
                    "Invalid Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int classId = Convert.ToInt32(cmbClass.SelectedValue);

            if (!SaveCharacter(characterName, level, classId))
            {
                return;
            }

            MessageBox.Show(
                "Character added successfully!",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            ClearInputFields();
        }

        /// <summary>
        /// Attempts to save a new character to the database.
        /// </summary>
        /// <param name="characterName">
        /// The name of the character being saved.
        /// </param>
        /// <param name="level">
        /// The character's level.
        /// </param>
        /// <param name="classId">
        /// The identifier of the selected character class.
        /// </param>
        /// <returns>
        /// <see langword="true"/> if the character was saved successfully;
        /// otherwise, <see langword="false"/>.
        /// </returns>
        private bool SaveCharacter(
            string characterName,
            int level,
            int classId)
        {
            try
            {
                characterRepository.AddCharacter(
                    characterName,
                    level,
                    classId);

                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "The character could not be saved because of a database error.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }
        }

        /// <summary>
        /// Clears all character input fields after a character
        /// has been successfully saved.
        /// </summary>
        /// <summary>
        /// Clears the character input fields after a character
        /// has been saved successfully.
        /// </summary>
        private void ClearInputFields()
        {
            txtCharacterName.Clear();
            txtLevel.Clear();
            cmbClass.SelectedIndex = -1;
        }
    }
}