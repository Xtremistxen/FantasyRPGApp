namespace FatasyRPGApp
{
    // QuestEntity inherits from GameEntity.
    // It adds quest-specific properties such as reward gold and assigned character ID.
    public class QuestEntity : GameEntity
    {
        public int RewardGold { get; set; }
        public int CharacterId { get; set; }

        public QuestEntity()
        {
        }

        public QuestEntity(int id, string name, int rewardGold, int characterId)
            : base(id, name)
        {
            RewardGold = rewardGold;
            CharacterId = characterId;
        }

        // This overrides the base method to display quest-specific information.
        public override string GetDisplayInfo()
        {
            return $"Quest: {Name}, Reward Gold: {RewardGold}, Character ID: {CharacterId}";
        }
    }
}
