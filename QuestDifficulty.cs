namespace FatasyRPGApp
{
    /// <summary>
    /// Represents the possible difficulty levels that can be
    /// assigned to a quest by the quest prediction system.
    /// </summary>
    public enum QuestDifficulty
    {
        /// <summary>
        /// Indicates that the character should have little
        /// difficulty completing the quest.
        /// </summary>
        Easy,

        /// <summary>
        /// Indicates that the quest should provide a reasonable
        /// challenge for the character.
        /// </summary>
        Moderate,

        /// <summary>
        /// Indicates that the quest may be difficult
        /// for the character to complete.
        /// </summary>
        Hard,

        /// <summary>
        /// Indicates that the quest may be significantly
        /// above the character's current ability.
        /// </summary>
        VeryHard
    }
}
