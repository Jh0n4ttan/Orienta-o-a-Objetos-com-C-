namespace Dotnet__Poo.src.Entities
{
    public class Knight : Hero
    {
        public Knight(String Name, int Level, string HeroType) :base(Name, Level, HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        } 
    }
}
