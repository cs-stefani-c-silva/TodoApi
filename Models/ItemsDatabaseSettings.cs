namespace TodoApi.Models
{
    public class ItemsDatabaseSettings : IItemsDatabaseSettings
    {
        public string ItemsCollectionName { get; set; }
        public string ConnectionString {get; set; }
        public string DatabaseName { get; set; }
    }

    public interface IItemsDatabaseSettings
    {
        public string ItemsCollectionName { get; set; }
        public string ConnectionString {get; set; }
        public string DatabaseName { get; set; }
    }
}