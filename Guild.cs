namespace GuildManagementSystem
{
    public class Guild
    {
        public string GuildName { get; }
        public int GuildLevel { get; }

        public Guild(string guildName, int guildLevel)
        {
            GuildName = guildName;
            GuildLevel = guildLevel;
        }

    }
}