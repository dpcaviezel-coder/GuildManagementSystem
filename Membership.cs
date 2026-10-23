namespace GuildManagementSystem
{
    public class Membership
    {
        public Player Player { get; set; }
        public Guild Guild { get; set; }

        public Membership(Player player, Guild guild)
        {
            Player = player;
            Guild = guild;
        }
    }
}