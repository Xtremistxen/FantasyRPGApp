namespace FatasyRPGApp
{
    // CharacterEntity inherits from GameEntity.
    // This demonstrates inheritance because CharacterEntity receives Id and Name from GameEntity.
    public class CharacterEntity : GameEntity
    {
        public int Level { get; set; }
        public int ClassId { get; set; }

        public CharacterEntity()
        {
        }

        public CharacterEntity(int id, string name, int level, int classId)
            : base(id, name)
        {
            Level = level;
            ClassId = classId;
        }

        // This overrides the base class method to display character-specific information.
        public override string GetDisplayInfo()
        {
            return $"Character: {Name}, Level: {Level}, Class ID: {ClassId}";
        }
    }
}