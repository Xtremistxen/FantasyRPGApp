using System;
using System.Data;
using NUnit.Framework;
using FatasyRPGApp;
using System.Data.SqlClient;

namespace FatasyRPGApp.Tests
{
    [TestFixture]
    public class RepositoryIntegrationTests
    {
        [Test]
        public void CharacterRepository_AddCharacter_SavesCharacterToDatabase()
        {
            // Arrange
            CharacterRepository characterRepository =
                new CharacterRepository();

            QueryRepository queryRepository =
                new QueryRepository();

            DataTable classes =
                characterRepository.GetClasses();

            Assert.Greater(
                classes.Rows.Count,
                0);

            int classId =
                Convert.ToInt32(
                    classes.Rows[0]["ClassID"]);

            string characterName =
                "IntegrationTestHero_" +
                Guid.NewGuid().ToString("N").Substring(0, 8);

            try
            {
                // Act
                characterRepository.AddCharacter(
                    characterName,
                    10,
                    classId);

                DataTable characters =
                    queryRepository.GetAllCharacters();

                bool characterFound = false;

                foreach (DataRow row in characters.Rows)
                {
                    if (row["CharacterName"].ToString()
                        == characterName)
                    {
                        characterFound = true;
                        break;
                    }
                }

                // Assert
                Assert.IsTrue(
                    characterFound,
                    "The character was not found after being inserted.");
            }
            finally
            {
                characterRepository.DeleteCharacterByName(
                    characterName);
            }
        }
        [Test]
        public void CharacterRepository_GetClasses_ReturnsClassData()
        {
            // Arrange
            CharacterRepository repository =
                new CharacterRepository();

            // Act
            DataTable classes =
                repository.GetClasses();

            // Assert
            Assert.IsNotNull(classes);
            Assert.Greater(classes.Rows.Count, 0);

            Assert.IsTrue(
                classes.Columns.Contains("ClassID"));

            Assert.IsTrue(
                classes.Columns.Contains("ClassName"));
        }

        [Test]
        public void QueryRepository_GetAllCharacters_ReturnsCharacterTable()
        {
            // Arrange
            QueryRepository repository =
                new QueryRepository();

            // Act
            DataTable characters =
                repository.GetAllCharacters();

            // Assert
            Assert.IsNotNull(characters);

            Assert.IsTrue(
                characters.Columns.Contains("CharacterID"));

            Assert.IsTrue(
                characters.Columns.Contains("CharacterName"));

            Assert.IsTrue(
                characters.Columns.Contains("Level"));

            Assert.IsTrue(
                characters.Columns.Contains("ClassID"));
        }

        [Test]
        public void QueryRepository_GetHighLevelCharacters_ReturnsOnlyHighLevelCharacters()
        {
            // Arrange
            QueryRepository repository =
                new QueryRepository();

            // Act
            DataTable characters =
                repository.GetHighLevelCharacters();

            // Assert
            Assert.IsNotNull(characters);

            foreach (DataRow row in characters.Rows)
            {
                int level =
                    System.Convert.ToInt32(row["Level"]);

                Assert.Greater(
                    level,
                    10);
            }
        }

        [Test]
        public void QueryRepository_GetCharactersWithClasses_ReturnsJoinedData()
        {
            // Arrange
            QueryRepository repository =
                new QueryRepository();

            // Act
            DataTable results =
                repository.GetCharactersWithClasses();

            // Assert
            Assert.IsNotNull(results);

            Assert.IsTrue(
                results.Columns.Contains("CharacterName"));

            Assert.IsTrue(
                results.Columns.Contains("Level"));

            Assert.IsTrue(
                results.Columns.Contains("ClassName"));
        }
       
    }
}
