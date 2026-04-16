using System;
using System.Windows.Forms;

namespace FatasyRPGApp
{
    // This form is used to view and edit quest data from the database
    public partial class QuestsForm : Form
    {
        public QuestsForm()
        {
            InitializeComponent();
        }

        // Saves any changes made to the quests data
        private void questsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate(); // Checks that all input is valid
            this.questsBindingSource.EndEdit(); // Ends editing on the current record
            this.tableAdapterManager.UpdateAll(this.fantasyRPGDBDataSet); // Saves changes to the database
        }

        // Runs when the form loads
        // Loads quest data from the database into the form
        private void QuestsForm_Load(object sender, EventArgs e)
        {
            this.questsTableAdapter.Fill(this.fantasyRPGDBDataSet.Quests);
        }
    }
}
