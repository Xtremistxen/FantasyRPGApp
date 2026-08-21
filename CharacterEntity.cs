namespace FatasyRPGApp
{
    /// <summary>
    /// Represents a character within the fantasy RPG application.
    /// Inherits common entity information such as the ID and name
    /// from the <see cref="GameEntity"/> base class.
    /// </summary>
    public class CharacterEntity : GameEntity
    {
        /// <summary>
        /// Gets or sets the character's current level.
        /// </summary>
        public int Level { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the class assigned to the character.
        /// This value corresponds to a class record stored in the database.
        /// </summary>
        public int ClassId { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterEntity"/> class.
        /// </summary>
        public CharacterEntity()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterEntity"/> class
        /// with the specified character information.
        /// </summary>
        /// <param name="id">The unique identifier for the character.</param>
        /// <param name="name">The name of the character.</param>
        /// <param name="level">The current level of the character.</param>
        /// <param name="classId">The identifier of the character's assigned class.</param>
        public CharacterEntity(int id, string name, int level, int classId)
            : base(id, name)
        {
            Level = level;
            ClassId = classId;
        }

        /// <summary>
        /// Returns formatted information describing the character.
        /// </summary>
        /// <returns>
        /// A string containing the character's name, level, and class identifier.
        /// </returns>
        public override string GetDisplayInfo()
        {
            return $"Character: {Name}, Level: {Level}, Class ID: {ClassId}";
        }
    }
}