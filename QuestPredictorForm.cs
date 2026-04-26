using System;
using System.Windows.Forms;

namespace FatasyRPGApp
{
    public partial class QuestPredictorForm : Form
    {
        public QuestPredictorForm()
        {
            InitializeComponent();
        }

        private void btnPredictDifficulty_Click(object sender, EventArgs e)
        {
            if (!float.TryParse(txtPredictLevel.Text, out float characterLevel))
            {
                MessageBox.Show("Please enter a valid character level.");
                return;
            }

            if (!float.TryParse(txtPredictReward.Text, out float rewardGold))
            {
                MessageBox.Show("Please enter a valid reward amount.");
                return;
            }

            // This is a simple placeholder prediction.
            // Later this can be replaced with a real ML.NET model.
            bool isHardQuest = rewardGold > 300 && characterLevel < 10;

            if (isHardQuest)
            {
                lblPredictionResult.Text = "Prediction: This quest may be difficult for this character.";
            }
            else
            {
                lblPredictionResult.Text = "Prediction: This quest should be manageable.";
            }
        }
    }
}