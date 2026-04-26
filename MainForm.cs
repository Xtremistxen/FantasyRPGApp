using System;
using System.Windows.Forms;

namespace FatasyRPGApp
{
    // This is the main menu form of the application
    // It allows the user to navigate to different parts of the program
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            // Creates sample objects when the program starts
            // This helps demonstrate the object-oriented part of the project
            CreateSampleObjects();
        }

        // This method creates multiple objects from the custom classes
        // It demonstrates object creation, inheritance, and polymorphism
        private void CreateSampleObjects()
        {
            CharacterEntity hero1 = new CharacterEntity(1, "Aric", 12, 1);
            CharacterEntity hero2 = new CharacterEntity(2, "Lyra", 9, 2);

            QuestEntity quest1 = new QuestEntity(1, "Goblin Camp Raid", 150, 1);
            QuestEntity quest2 = new QuestEntity(2, "Crystal Cave Search", 300, 2);

            MessageBox.Show(
                hero1.GetDisplayInfo() + "\n" +
                hero2.GetDisplayInfo() + "\n" +
                quest1.GetDisplayInfo() + "\n" +
                quest2.GetDisplayInfo(),
                "Sample RPG Objects"
            );
        }

        // Opens the form that allows the user to add a new character to the database
        private void btnAddCharacter_Click(object sender, EventArgs e)
        {
            new AddCharacterForm().ShowDialog();
        }

        // Opens the quest predictor form
        // This form demonstrates the planned machine learning feature
        private void btnQuestPredictor_Click(object sender, EventArgs e)
        {
            new QuestPredictorForm().ShowDialog();
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