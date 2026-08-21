using NUnit.Framework;
using FatasyRPGApp;

namespace FatasyRPGApp.Tests
{
    [TestFixture]
    public class QuestDifficultyPredictorTests
    {
        [Test]
        public void Predict_ReturnsEasy_WhenCharacterIsMuchStronger()
        {
            // Arrange
            QuestDifficultyPredictor predictor =
                new QuestDifficultyPredictor();

            QuestPredictionInput input =
                new QuestPredictionInput
                {
                    CharacterLevel = 20,
                    RewardGold = 500
                };

            // Act
            QuestPredictionOutput result =
                predictor.Predict(input);

            // Assert
            Assert.AreEqual(
                QuestDifficulty.Easy,
                result.Difficulty);
        }

        [Test]
        public void Predict_ReturnsModerate_WhenCharacterMatchesQuest()
        {
            // Arrange
            QuestDifficultyPredictor predictor =
                new QuestDifficultyPredictor();

            QuestPredictionInput input =
                new QuestPredictionInput
                {
                    CharacterLevel = 12,
                    RewardGold = 500
                };

            // Act
            QuestPredictionOutput result =
                predictor.Predict(input);

            // Assert
            Assert.AreEqual(
                QuestDifficulty.Moderate,
                result.Difficulty);
        }

        [Test]
        public void Predict_ReturnsHard_WhenQuestIsAboveCharacterLevel()
        {
            // Arrange
            QuestDifficultyPredictor predictor =
                new QuestDifficultyPredictor();

            QuestPredictionInput input =
                new QuestPredictionInput
                {
                    CharacterLevel = 8,
                    RewardGold = 500
                };

            // Act
            QuestPredictionOutput result =
                predictor.Predict(input);

            // Assert
            Assert.AreEqual(
                QuestDifficulty.Hard,
                result.Difficulty);
        }

        [Test]
        public void Predict_ReturnsVeryHard_WhenQuestIsFarAboveCharacterLevel()
        {
            // Arrange
            QuestDifficultyPredictor predictor =
                new QuestDifficultyPredictor();

            QuestPredictionInput input =
                new QuestPredictionInput
                {
                    CharacterLevel = 2,
                    RewardGold = 500
                };

            // Act
            QuestPredictionOutput result =
                predictor.Predict(input);

            // Assert
            Assert.AreEqual(
                QuestDifficulty.VeryHard,
                result.Difficulty);
        }

        [Test]
        public void Predict_CalculatesQuestDifficultyScoreCorrectly()
        {
            // Arrange
            QuestDifficultyPredictor predictor =
                new QuestDifficultyPredictor();

            QuestPredictionInput input =
                new QuestPredictionInput
                {
                    CharacterLevel = 20,
                    RewardGold = 500
                };

            // Act
            QuestPredictionOutput result =
                predictor.Predict(input);

            // Assert
            Assert.AreEqual(
                10f,
                result.QuestDifficultyScore);
        }

        [Test]
        public void Predict_CalculatesLevelDifferenceCorrectly()
        {
            // Arrange
            QuestDifficultyPredictor predictor =
                new QuestDifficultyPredictor();

            QuestPredictionInput input =
                new QuestPredictionInput
                {
                    CharacterLevel = 20,
                    RewardGold = 500
                };

            // Act
            QuestPredictionOutput result =
                predictor.Predict(input);

            // Assert
            Assert.AreEqual(
                10f,
                result.LevelDifference);
        }

        [Test]
        public void Predict_ReturnsEasy_AtPositiveFiveBoundary()
        {
            // Character level 15 - quest score 10 = +5.
            QuestDifficultyPredictor predictor =
                new QuestDifficultyPredictor();

            QuestPredictionInput input =
                new QuestPredictionInput
                {
                    CharacterLevel = 15,
                    RewardGold = 500
                };

            QuestPredictionOutput result =
                predictor.Predict(input);

            Assert.AreEqual(
                QuestDifficulty.Easy,
                result.Difficulty);
        }

        [Test]
        public void Predict_ReturnsModerate_AtZeroBoundary()
        {
            // Character level 10 - quest score 10 = 0.
            QuestDifficultyPredictor predictor =
                new QuestDifficultyPredictor();

            QuestPredictionInput input =
                new QuestPredictionInput
                {
                    CharacterLevel = 10,
                    RewardGold = 500
                };

            QuestPredictionOutput result =
                predictor.Predict(input);

            Assert.AreEqual(
                QuestDifficulty.Moderate,
                result.Difficulty);
        }

        [Test]
        public void Predict_ReturnsHard_AtNegativeFiveBoundary()
        {
            // Character level 5 - quest score 10 = -5.
            QuestDifficultyPredictor predictor =
                new QuestDifficultyPredictor();

            QuestPredictionInput input =
                new QuestPredictionInput
                {
                    CharacterLevel = 5,
                    RewardGold = 500
                };

            QuestPredictionOutput result =
                predictor.Predict(input);

            Assert.AreEqual(
                QuestDifficulty.Hard,
                result.Difficulty);
        }

        [Test]
        public void Predict_ReturnsCorrectMessage_ForVeryHardQuest()
        {
            // Arrange
            QuestDifficultyPredictor predictor =
                new QuestDifficultyPredictor();

            QuestPredictionInput input =
                new QuestPredictionInput
                {
                    CharacterLevel = 2,
                    RewardGold = 500
                };

            // Act
            QuestPredictionOutput result =
                predictor.Predict(input);

            // Assert
            Assert.AreEqual(
                "Prediction: This quest may be very difficult.",
                result.Message);
        }
    }
}