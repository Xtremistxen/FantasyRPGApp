using System;
using System.Windows.Forms;

namespace FatasyRPGApp
{
    // This form is used to view and edit class data from the database
    public partial class ClassesForm : Form
    {
        public ClassesForm()
        {
            InitializeComponent();
        }

        // Saves any changes made to the classes data
        private void classesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate(); // Checks that input is valid
            this.classesBindingSource.EndEdit(); // Ends editing on the current record
            this.tableAdapterManager.UpdateAll(this.fantasyRPGDBDataSet); // Saves changes to the database
        }

        // Runs when the form loads
        // Loads class data from the database into the form
        private void ClassesForm_Load(object sender, EventArgs e)
        {
            this.classesTableAdapter.Fill(this.fantasyRPGDBDataSet.Classes);
        }
    }
}
