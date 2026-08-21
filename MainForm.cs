using System;
using System.Windows.Forms;

namespace FatasyRPGApp
{
    /// <summary>
    /// Represents the main menu of the Fantasy RPG Character and Quest Manager.
    /// Provides navigation to the application's character, class, quest,
    /// query, and quest prediction features.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class
        /// and creates sample RPG objects for demonstration purposes.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

        }

   

        /// <summary>
        /// Opens the form used to create and save a new character.
        /// </summary>
        /// <param name="sender">
        /// The control that triggered the event.
        /// </param>
        /// <param name="e">
        /// The event data associated with the button click.
        /// </param>
        private void btnAddCharacter_Click(object sender, EventArgs e)
        {
            using (AddCharacterForm form = new AddCharacterForm())
            {
                form.ShowDialog();
            }
        }

        /// <summary>
        /// Opens the quest difficulty prediction form.
        /// </summary>
        /// <param name="sender">
        /// The control that triggered the event.
        /// </param>
        /// <param name="e">
        /// The event data associated with the button click.
        /// </param>
        private void btnQuestPredictor_Click(object sender, EventArgs e)
        {
            using (QuestPredictorForm form = new QuestPredictorForm())
            {
                form.ShowDialog();
            }
        }

        /// <summary>
        /// Opens the form used to view and edit character class records.
        /// </summary>
        /// <param name="sender">
        /// The control that triggered the event.
        /// </param>
        /// <param name="e">
        /// The event data associated with the button click.
        /// </param>
        private void btnViewClasses_Click(object sender, EventArgs e)
        {
            using (ClassesForm form = new ClassesForm())
            {
                form.ShowDialog();
            }
        }

        /// <summary>
        /// Opens the form used to view and edit character records.
        /// </summary>
        /// <param name="sender">
        /// The control that triggered the event.
        /// </param>
        /// <param name="e">
        /// The event data associated with the button click.
        /// </param>
        private void btnViewCharacters_Click(object sender, EventArgs e)
        {
            using (CharactersForm form = new CharactersForm())
            {
                form.ShowDialog();
            }
        }

        /// <summary>
        /// Opens the form used to view and edit quest records.
        /// </summary>
        /// <param name="sender">
        /// The control that triggered the event.
        /// </param>
        /// <param name="e">
        /// The event data associated with the button click.
        /// </param>
        private void btnViewQuests_Click(object sender, EventArgs e)
        {
            using (QuestsForm form = new QuestsForm())
            {
                form.ShowDialog();
            }
        }

        /// <summary>
        /// Opens the form used to execute and display database queries.
        /// </summary>
        /// <param name="sender">
        /// The control that triggered the event.
        /// </param>
        /// <param name="e">
        /// The event data associated with the button click.
        /// </param>
        private void btnRunQueries_Click(object sender, EventArgs e)
        {
            using (QueriesForm form = new QueriesForm())
            {
                form.ShowDialog();
            }
        }

        /// <summary>
        /// Closes the main form and exits the application.
        /// </summary>
        /// <param name="sender">
        /// The control that triggered the event.
        /// </param>
        /// <param name="e">
        /// The event data associated with the button click.
        /// </param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}