namespace GuildManagementSystem
{
    public class GuildManager
    {
        public List<Player> players = new();
        public List<Guild> guilds = new();
        public List<Membership> members = new();

        public void AddPlayer(Player player)
        {
            players.Add(player);
        }

        public void AddGuild(Guild guild)
        {
            guilds.Add(guild);
        }

        public void JoinGuild(
            Player player,
            Guild guild)
        {
            players.Add(player);
            guilds.Add(guild);

            members.Add(
                new Membership(player, guild));
        }


        public void DisplayMemberships()
        {
            Console.WriteLine("\nGuild Memberships:\n");

            foreach (Membership membership in members)
            {
                Console.WriteLine($"{membership.Player.Name} -> {membership.Guild.GuildName}\n");
            }
        }
    
    }
}