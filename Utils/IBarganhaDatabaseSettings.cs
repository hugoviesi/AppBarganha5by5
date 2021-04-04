namespace AppBarganhaWEB.Utils
{
    public interface IBarganhaDatabaseSettings
    {
        string CollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}