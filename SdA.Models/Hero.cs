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

        public override void Attack(Character character)
        {
            base.Attack(character);
        }

        protected override void DoAttack(Character character)
        {
            throw new NotImplementedException();
        }
    }
}
