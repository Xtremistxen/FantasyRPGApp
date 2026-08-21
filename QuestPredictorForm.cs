using System;
using System.Windows.Forms;

namespace FatasyRPGApp
{
    /// <summary>
    /// Provides the user interface for predicting quest difficulty
    /// based on a character's level and the quest's gold reward.
    /// </summary>
    public partial class QuestPredictorForm : Form
    {
        /// <summary>
        /// Performs the quest difficulty calculations used by the form.
        /// </summary>
        private readonly QuestDifficultyPredictor _difficultyPredictor;

        /// <summary>
        /// Initializes a new instance of the <see cref="QuestPredictorForm"/> class.
        /// </summary>
        public QuestPredictorForm()
        {
            InitializeComponent();

            _difficultyPredictor = new QuestDifficultyPredictor();
        }

        /// <summary>
        /// Validates the user's prediction input, calculates the quest difficulty,
        /// and displays the resulting prediction.
        /// </summary>
        /// <param name="sender">
        /// The control that triggered the event.
        /// </param>
        /// <param name="e">
        /// The event data associated with the button click.
        /// </param>
        private void btnPredictDifficulty_Click(object sender, EventArgs e)
        {
            if (!TryReadPredictionInput(out QuestPredictionInput input))
            {
                return;
            }

            QuestPredictionOutput result =
            _difficultyPredictor.Predict(input);

            lblPredictionResult.Text = result.Message;    
        }

        /// <summary>
        /// Reads and validates the quest prediction values entered by the user.
        /// </summary>
        /// <param name="input">
        /// When this method returns successfully, contains the validated
        /// prediction input. Otherwise, the value is <see langword="null"/>.
        /// </param>
        /// <returns>
        /// <see langword="true"/> if all entered values are valid;
        /// otherwise, <see langword="false"/>.
        /// </returns>
        private bool TryReadPredictionInput(out QuestPredictionInput input)
        {
            input = null;

            if (!TryReadPositiveNumber(
                txtPredictLevel.Text,
                "character level",
                out float characterLevel))
            {
                return false;
            }

            if (!TryReadPositiveNumber(
                txtPredictReward.Text,
                "reward amount",
                out float rewardGold))
            {
                return false;
            }

            input = new QuestPredictionInput
            {
                CharacterLevel = characterLevel,
                RewardGold = rewardGold
            };

            return true;
        }

        /// <summary>
        /// Attempts to convert entered text into a valid non-negative number.
        /// Displays a warning message when the value is invalid.
        /// </summary>
        /// <param name="text">
        /// The text value entered by the user.
        /// </param>
        /// <param name="fieldName">
        /// A user-friendly name used when displaying validation messages.
        /// </param>
        /// <param name="value">
        /// When successful, contains the converted numeric value.
        /// </param>
        /// <returns>
        /// <see langword="true"/> if the text contains a valid,
        /// non-negative number; otherwise, <see langword="false"/>.
        /// </returns>
        private bool TryReadPositiveNumber(
            string text,
            string fieldName,
            out float value)
        {
            if (!float.TryParse(text, out value))
            {
                MessageBox.Show(
                    $"Please enter a valid {fieldName}.",
                    "Invalid Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }

            if (value < 0)
            {
                MessageBox.Show(
                    $"The {fieldName} cannot be negative.",
                    "Invalid Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }

            return true;
        }
    }
}