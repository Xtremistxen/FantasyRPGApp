namespace FatasyRPGApp
{
    // This class represents the output from the machine learning prediction.
    // PredictedLabel tells whether the model thinks the quest is hard.
    public class QuestPredictionOutput
    {
        public bool PredictedLabel { get; set; }
        public float Probability { get; set; }
        public float Score { get; set; }
    }
}
