namespace Piskvorky2.Domain
{
    public class DatabaseSettings
    {
        public string ConnectionString { get; set; } = null!;

        public string DatabaseName { get; set; } = null!;

        public string GamesCollectionName { get; set; } = null!;

        public string PlayersCollectionName { get; set; } = null!;
    }
}