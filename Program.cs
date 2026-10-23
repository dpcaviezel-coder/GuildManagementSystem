using System;

namespace GuildManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player("Reinan", 12, "Assassin");
            Player player2 = new Player("Haisley", 13, "Priest");
            Player player3 = new Player("Luna", 12, "Warlock");

            GuildManager guildManager = new GuildManager();

            guildManager.JoinGuild(player1, new Guild("Star Slayers", 7));
            guildManager.JoinGuild(player2, new Guild("Knights of Ring", 9));
            guildManager.JoinGuild(player3, new Guild("Star Slayers", 7));

            guildManager.DisplayMemberships();
        }
    }
}