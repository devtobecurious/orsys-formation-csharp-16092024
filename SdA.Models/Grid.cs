namespace SdA.Models
{
	public class Grid
	{
		public Grid(int nbRows, int nbCols)
		{
			for (int i = 0; i < nbRows; i++)
			{
				for (int j = 0; j < nbCols; j++)
				{
					this.Cells.Add(new() { X = i, Y = j });
				}
			}
		}

		public List<Cell> Cells { get; set; } = new();
	}
}
