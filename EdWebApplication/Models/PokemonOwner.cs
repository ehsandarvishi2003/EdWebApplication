namespace EdWebApplication.Models
{
    public class PokemonOwner
    {
        public int PokemonId { get; set; }
        public int OwnerId { get; set; }
        public Pokemon Pokemon { get; set; } //-->join tables
        public Owner Owner { get; set; }
    }
}
