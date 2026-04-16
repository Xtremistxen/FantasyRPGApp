using System;
using System.Windows.Forms;

namespace FatasyRPGApp
{
    // This form is used to view and edit character data from the database
    public partial class CharactersForm : Form
    {
        public CharactersForm()
        {
            InitializeComponent();
        }

        // Saves any changes made to the characters data
        private void charactersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate(); // Checks that input is valid
            this.charactersBindingSource.EndEdit(); // Ends editing on the current record
            this.tableAdapterManager.UpdateAll(this.fantasyRPGDBDataSet); // Saves changes to the database
        }

        // Runs when the form loads
        // Loads character data from the database into the form
        private void CharactersForm_Load(object sender, EventArgs e)
        {
            this.charactersTableAdapter.Fill(this.fantasyRPGDBDataSet.Characters);
        }
    }
}