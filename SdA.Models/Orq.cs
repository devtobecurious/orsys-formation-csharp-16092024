namespace SdA.Models
{
	public class Orq : Character
	{
		public Orq(string surname, int strength) : base(surname, strength)
		{
		}

		protected override void DoAttack(Character character)
		{
			throw new NotImplementedException();
		}
	}
}
