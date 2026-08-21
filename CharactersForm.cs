using System;
using System.Windows.Forms;

namespace FatasyRPGApp
{
    /// <summary>
    /// Provides the user interface for viewing and editing
    /// character records stored in the Fantasy RPG database.
    /// </summary>
    public partial class CharactersForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CharactersForm"/> class.
        /// </summary>
        public CharactersForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Validates the current character data, completes any active edits,
        /// and saves all changes to the database.
        /// </summary>
        /// <param name="sender">
        /// The control that triggered the save event.
        /// </param>
        /// <param name="e">
        /// The event data associated with the button click.
        /// </param>
        private void charactersBindingNavigatorSaveItem_Click(
            object sender,
            EventArgs e)
        {
            Validate();
            charactersBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(fantasyRPGDBDataSet);
        }

        /// <summary>
        /// Loads character records from the database when the form opens.
        /// </summary>
        /// <param name="sender">
        /// The form that triggered the load event.
        /// </param>
        /// <param name="e">
        /// The event data associated with the form load event.
        /// </param>
        private void CharactersForm_Load(
            object sender,
            EventArgs e)
        {
            charactersTableAdapter.Fill(
                fantasyRPGDBDataSet.Characters);
        }
    }
}