namespace FatasyRPGApp
{
    /// <summary>
    /// Represents the result produced by the
    /// quest difficulty prediction system.
    /// </summary>
    public class QuestPredictionOutput
    {
        /// <summary>
        /// Gets or sets the predicted difficulty of the quest.
        /// </summary>
        public QuestDifficulty Difficulty { get; set; }

        /// <summary>
        /// Gets or sets the calculated difficulty score
        /// associated with the quest.
        /// </summary>
        public float QuestDifficultyScore { get; set; }

        /// <summary>
        /// Gets or sets the difference between the character's
        /// level and the calculated quest difficulty score.
        /// </summary>
        public float LevelDifference { get; set; }

        /// <summary>
        /// Gets or sets a user-friendly message describing
        /// the prediction result.
        /// </summary>
        public string Message { get; set; }
    }
}
