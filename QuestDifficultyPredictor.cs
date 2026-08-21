namespace FatasyRPGApp
{
    /// <summary>
    /// Provides rule-based calculations for estimating
    /// quest difficulty based on character and quest information.
    /// </summary>
    public class QuestDifficultyPredictor
    {
        /// <summary>
        /// Represents the amount of reward gold used to calculate
        /// one point of estimated quest difficulty.
        /// </summary>
        private const float GoldPerDifficultyPoint = 50f;

        /// <summary>
        /// Evaluates character and quest information and returns
        /// a complete quest difficulty prediction.
        /// </summary>
        /// <param name="input">
        /// The information used to calculate the prediction.
        /// </param>
        /// <returns>
        /// A <see cref="QuestPredictionOutput"/> containing
        /// the prediction results.
        /// </returns>
        public QuestPredictionOutput Predict(QuestPredictionInput input)
        {
            float questDifficultyScore =
                input.RewardGold / GoldPerDifficultyPoint;

            float levelDifference =
                input.CharacterLevel - questDifficultyScore;

            QuestDifficulty difficulty =
                DetermineDifficulty(levelDifference);

            return new QuestPredictionOutput
            {
                Difficulty = difficulty,
                QuestDifficultyScore = questDifficultyScore,
                LevelDifference = levelDifference,
                Message = GetMessage(difficulty)
            };
        }

        /// <summary>
        /// Determines the estimated quest difficulty based
        /// on the calculated level difference.
        /// </summary>
        private QuestDifficulty DetermineDifficulty(float levelDifference)
        {
            if (levelDifference >= 5)
            {
                return QuestDifficulty.Easy;
            }

            if (levelDifference >= 0)
            {
                return QuestDifficulty.Moderate;
            }

            if (levelDifference >= -5)
            {
                return QuestDifficulty.Hard;
            }

            return QuestDifficulty.VeryHard;
        }

        /// <summary>
        /// Creates a user-friendly message describing
        /// the supplied quest difficulty.
        /// </summary>
        private string GetMessage(QuestDifficulty difficulty)
        {
            switch (difficulty)
            {
                case QuestDifficulty.Easy:
                    return "Prediction: This quest should be easy.";

                case QuestDifficulty.Moderate:
                    return "Prediction: This quest should be manageable.";

                case QuestDifficulty.Hard:
                    return "Prediction: This quest may be difficult.";

                case QuestDifficulty.VeryHard:
                    return "Prediction: This quest may be very difficult.";

                default:
                    return "Prediction unavailable.";
            }
        }
    }
}