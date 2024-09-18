namespace SdA.Models;

public class Character
{
    #region Constructors
    public Character(string surname, int strength)
    {
        // this.Surname = surname;
        // this.Strength = strength;
    }
    #endregion

    #region Public methods
    public void Move(Vector2D vector)
    {
        this.CurrentPosition = new Vector2D(vector.X + this.CurrentPosition.X, vector.Y + this.CurrentPosition.Y);
        Console.WriteLine("Ma position : {0}/{1}", this.CurrentPosition.X, this.CurrentPosition.Y);
    }
    #endregion

    #region Properties
    public Vector2D CurrentPosition { get; private set; } = new(0, 0);

    public required string Surname { get; set; }

    public int? Strength { get; set; }

    public Weapon? Weapon { get; set; }
    #endregion
}

//namespace Sda.ModelsYoupi
//{
//    public class Character { }
//}
