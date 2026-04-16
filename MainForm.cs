using System;
using System.Windows.Forms;

namespace FatasyRPGApp
{
    // This is the main menu form of the application.
    // It allows the user to navigate to different parts of the program.
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // Opens the Classes form when the button is clicked
        private void btnViewClasses_Click(object sender, EventArgs e)
        {
            ClassesForm form = new ClassesForm();
            form.ShowDialog();
        }

        // Opens the Characters form when the button is clicked
        private void btnViewCharacters_Click(object sender, EventArgs e)
        {
            CharactersForm form = new CharactersForm();
            form.ShowDialog();
        }

        // Opens the Quests form when the button is clicked
        private void btnViewQuests_Click(object sender, EventArgs e)
        {
            QuestsForm form = new QuestsForm();
            form.ShowDialog();
        }

        // Opens the Queries form when the button is clicked
        // This form runs database queries and displays results
        private void btnRunQueries_Click(object sender, EventArgs e)
        {
            QueriesForm form = new QueriesForm();
            form.ShowDialog();
        }

        // Closes the application when the Exit button is clicked
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}