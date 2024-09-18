namespace FirstProject
{
    public enum TypeAnimal
    {
        Eagle,
        Oliphant,
        Rabbit
    }

    internal abstract class Animal
    {
        #region Public methods
        public virtual void Sleep(int duration)
        {
            //if (this.TypeAnimal == TypeAnimal.Eagle) { }
            //if (this.TypeAnimal == TypeAnimal.Rabbit) { }
            Console.WriteLine("Je dors bien");
        }

        public abstract void Eat(int qty);
        #endregion

        #region Properties
        public int Size { get; set; }

        public int Weight { get; set; }

        // public TypeAnimal TypeAnimal { get; init; }
        #endregion
    }
}
