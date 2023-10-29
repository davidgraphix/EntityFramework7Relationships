namespace EntityFramework7Relationships.Models
{
    public class BackPack
    {
        public int Id { get; set; }
        public string Description  { get; set; }
        public int CharacterId { get; set; }
        public Character Character { get; set; }
    }
}
