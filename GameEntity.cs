using System;

namespace FatasyRPGApp
{
    // GameEntity is the base class for common RPG objects.
    // It stores properties that both characters and quests can share.
    public class GameEntity
    {
        // The ID represents the database ID or object ID.
        public int Id { get; set; }

        // The Name represents the character name, quest name, or other entity name.
        public string Name { get; set; }

        // Default constructor.
        public GameEntity()
        {
        }

        // Constructor used to quickly create a game entity object.
        public GameEntity(int id, string name)
        {
            Id = id;
            Name = name;
        }

        // Virtual method that can be overridden by child classes.
        public virtual string GetDisplayInfo()
        {
            return $"ID: {Id}, Name: {Name}";
        }
    }
}
