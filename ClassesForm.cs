using System;
using System.Windows.Forms;

namespace FatasyRPGApp
{
    /// <summary>
    /// Provides the user interface for viewing and editing
    /// character class records stored in the Fantasy RPG database.
    /// </summary>
    public partial class ClassesForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClassesForm"/> class.
        /// </summary>
        public ClassesForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Validates the current class data, completes any active edits,
        /// and saves all changes to the database.
        /// </summary>
        /// <param name="sender">
        /// The control that triggered the save event.
        /// </param>
        /// <param name="e">
        /// The event data associated with the button click.
        /// </param>
        private void classesBindingNavigatorSaveItem_Click(
            object sender,
            EventArgs e)
        {
            Validate();
            classesBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(fantasyRPGDBDataSet);
        }

        /// <summary>
        /// Loads class records from the database when the form opens.
        /// </summary>
        /// <param name="sender">
        /// The form that triggered the load event.
        /// </param>
        /// <param name="e">
        /// The event data associated with the form load event.
        /// </param>
        private void ClassesForm_Load(
            object sender,
            EventArgs e)
        {
            classesTableAdapter.Fill(
                fantasyRPGDBDataSet.Classes);
        }
    }
}
