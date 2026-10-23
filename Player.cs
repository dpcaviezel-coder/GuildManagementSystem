namespace GuildManagementSystem
{
    public class Player
    {
        public string Name { get; }
        public int Level { get; }
        public string ClassType { get; }

        public Player(string name, int level, string classType)
        {
            Name = name;
            Level = level;
            ClassType = classType;
        }
    }
}