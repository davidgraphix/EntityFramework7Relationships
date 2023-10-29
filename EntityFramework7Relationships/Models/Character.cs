namespace EntityFramework7Relationships.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public BackPack BackPack { get; set; }
    }
}
