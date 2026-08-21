using System;
using System.Windows.Forms;

namespace FatasyRPGApp
{
    /// <summary>
    /// Provides the user interface for viewing and editing
    /// quest records stored in the Fantasy RPG database.
    /// </summary>
    public partial class QuestsForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuestsForm"/> class.
        /// </summary>
        public QuestsForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Validates the current quest data, completes any active edits,
        /// and saves all changes to the database.
        /// </summary>
        /// <param name="sender">
        /// The control that triggered the save event.
        /// </param>
        /// <param name="e">
        /// The event data associated with the button click.
        /// </param>
        private void questsBindingNavigatorSaveItem_Click(
            object sender,
            EventArgs e)
        {
            Validate();
            questsBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(fantasyRPGDBDataSet);
        }

        /// <summary>
        /// Loads quest records from the database when the form opens.
        /// </summary>
        /// <param name="sender">
        /// The form that triggered the load event.
        /// </param>
        /// <param name="e">
        /// The event data associated with the form load event.
        /// </param>
        private void QuestsForm_Load(
            object sender,
            EventArgs e)
        {
            questsTableAdapter.Fill(
                fantasyRPGDBDataSet.Quests);
        }
    }
}