namespace SdA.Models
{
    public class Hero : Character
    {
        public Hero(string surname) : base(surname, 100)
        {
        }

        public Hero() : this("Unknown")
        {
        }
    }
}
