namespace FatasyRPGApp
{
    /// <summary>
    /// Represents the character and quest information used
    /// by the quest difficulty prediction system.
    /// </summary>
    public class QuestPredictionInput
    {
        /// <summary>
        /// Gets or sets the level of the character attempting the quest.
        /// </summary>
        public float CharacterLevel { get; set; }

        /// <summary>
        /// Gets or sets the amount of gold awarded
        /// for completing the quest.
        /// </summary>
        public float RewardGold { get; set; }
    }
}
