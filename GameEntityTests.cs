using NUnit.Framework;
using FatasyRPGApp;

namespace FatasyRPGApp.Tests
{
    [TestFixture]
    public class GameEntityTests
    {
        [Test]
        public void GameEntity_Constructor_SetsIdAndName()
        {
            GameEntity entity = new GameEntity(1, "Ancient Sword");

            Assert.AreEqual(1, entity.Id);
            Assert.AreEqual("Ancient Sword", entity.Name);
        }

        [Test]
        public void GameEntity_GetDisplayInfo_ReturnsCorrectInformation()
        {
            GameEntity entity = new GameEntity(2, "Magic Potion");

            Assert.AreEqual(
                "ID: 2, Name: Magic Potion",
                entity.GetDisplayInfo());
        }

        [Test]
        public void CharacterEntity_Constructor_SetsAllProperties()
        {
            CharacterEntity character =
                new CharacterEntity(3, "Aria", 10, 2);

            Assert.AreEqual(3, character.Id);
            Assert.AreEqual("Aria", character.Name);
            Assert.AreEqual(10, character.Level);
            Assert.AreEqual(2, character.ClassId);
        }

        [Test]
        public void CharacterEntity_GetDisplayInfo_ReturnsCorrectInformation()
        {
            CharacterEntity character =
                new CharacterEntity(4, "Darius", 15, 1);

            Assert.AreEqual(
                "Character: Darius, Level: 15, Class ID: 1",
                character.GetDisplayInfo());
        }

        [Test]
        public void QuestEntity_Constructor_SetsAllProperties()
        {
            QuestEntity quest =
                new QuestEntity(5, "Defeat the Goblins", 250, 3);

            Assert.AreEqual(5, quest.Id);
            Assert.AreEqual("Defeat the Goblins", quest.Name);
            Assert.AreEqual(250, quest.RewardGold);
            Assert.AreEqual(3, quest.CharacterId);
        }

        [Test]
        public void QuestEntity_GetDisplayInfo_ReturnsCorrectInformation()
        {
            QuestEntity quest =
                new QuestEntity(6, "Slay the Dragon", 1000, 4);

            Assert.AreEqual(
                "Quest: Slay the Dragon, Reward Gold: 1000, Character ID: 4",
                quest.GetDisplayInfo());
        }

        [Test]
        public void CharacterEntity_UsesPolymorphism()
        {
            GameEntity entity =
                new CharacterEntity(7, "Lyra", 8, 3);

            Assert.AreEqual(
                "Character: Lyra, Level: 8, Class ID: 3",
                entity.GetDisplayInfo());
        }
    }
}
