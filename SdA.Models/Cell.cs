namespace SdA.Models
{
	public class Cell
	{
		public required int X { get; set; }
		public required int Y { get; set; }

		public List<Character> Characters { get; init; } = new();
	}
}
