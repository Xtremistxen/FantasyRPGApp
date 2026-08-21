namespace FatasyRPGApp
{
    /// <summary>
    /// Represents a quest within the fantasy RPG application.
    /// Inherits common entity information such as the ID and name
    /// from the <see cref="GameEntity"/> base class.
    /// </summary>
    public class QuestEntity : GameEntity
    {
        /// <summary>
        /// Gets or sets the amount of gold awarded for completing the quest.
        /// </summary>
        public int RewardGold { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the character assigned to the quest.
        /// This value corresponds to a character record stored in the database.
        /// </summary>
        public int CharacterId { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="QuestEntity"/> class.
        /// </summary>
        public QuestEntity()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QuestEntity"/> class
        /// with the specified quest information.
        /// </summary>
        /// <param name="id">The unique identifier for the quest.</param>
        /// <param name="name">The name of the quest.</param>
        /// <param name="rewardGold">The amount of gold awarded for completing the quest.</param>
        /// <param name="characterId">
        /// The identifier of the character assigned to the quest.
        /// </param>
        public QuestEntity(int id, string name, int rewardGold, int characterId)
            : base(id, name)
        {
            RewardGold = rewardGold;
            CharacterId = characterId;
        }

        /// <summary>
        /// Returns formatted information describing the quest.
        /// </summary>
        /// <returns>
        /// A string containing the quest's name, gold reward, and assigned character identifier.
        /// </returns>
        public override string GetDisplayInfo()
        {
            return $"Quest: {Name}, Reward Gold: {RewardGold}, Character ID: {CharacterId}";
        }
    }
}
