namespace FatasyRPGApp
{
    /// <summary>
    /// Represents a base entity used by objects within the fantasy RPG application.
    /// Provides common properties and behavior shared by characters, quests,
    /// and other game related entities.
    /// </summary>
    public class GameEntity
    {
        /// <summary>
        /// Gets or sets the unique identifier for the entity.
        /// This value may correspond to the entity's database record ID.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the entity.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameEntity"/> class.
        /// </summary>
        public GameEntity()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameEntity"/> class
        /// using the specified identifier and name.
        /// </summary>
        /// <param name="id">The unique identifier for the entity.</param>
        /// <param name="name">The name of the entity.</param>
        public GameEntity(int id, string name)
        {
            Id = id;
            Name = name;
        }

        /// <summary>
        /// Returns formatted information describing the entity.
        /// Derived classes can override this method to provide
        /// entity specific information.
        /// </summary>
        /// <returns>
        /// A formatted string containing the entity's ID and name.
        /// </returns>
        public virtual string GetDisplayInfo()
        {
            return $"ID: {Id}, Name: {Name}";
        }
    }
}
