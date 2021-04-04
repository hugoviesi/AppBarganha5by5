namespace AppBarganhaWEB.Utils
{
    public class BarganhaDatabaseSettings : IBarganhaDatabaseSettings
    {
        public string CollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
