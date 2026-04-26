namespace FatasyRPGApp
{
    // This class represents the input data for the machine learning feature.
    // The final version will use character level and reward gold to predict quest difficulty.
    public class QuestPredictionInput
    {
        public float CharacterLevel { get; set; }
        public float RewardGold { get; set; }

        // This value represents whether the quest is considered hard in training data.
        public bool IsHardQuest { get; set; }
    }
}
