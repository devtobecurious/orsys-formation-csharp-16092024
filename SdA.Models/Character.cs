namespace SdA.Models
{
    internal class Character
    {
        #region Constructors
        public Character(string surname, int strength)
        {
            this.Surname = surname;
            this.Strength = strength;
        }
        #endregion

        #region Properties
        public required string Surname { get; set; }

        public int Strength { get; init; }
        #endregion
    }
}
