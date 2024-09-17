namespace FirstBisProject
{
    /// <summary>
    /// 
    /// </summary>
    internal class Animal
    {
        #region Fields
        private string surname;
        #endregion

        #region Constructors
        //public Animal() 
        //{ 
        //}

        public Animal(string surname)
        {
            this.surname = surname;
        }

        //public Animal(string surname, string name)
        //{
        //    this.surname = surname;
        //}

        public Animal(int weight) : this("PRENOMPARDEFAUT")
        {
            this.Weight = weight;
        }
        #endregion

        #region Public methods
        /// <summary>
        /// 
        /// </summary>
        /// <param name="food"></param>
        private void Eat(string food)
        {
            Console.WriteLine("Miam {0}", food);
        }

        public void Eat(string food, int quantity = 2, int duration = 10, bool isAlive = true)
        {
            for (int i = 0; i < quantity; i++)
            {
                this.Eat(food);
            }
        }
        #endregion

        #region Properties
        public string Surname
        {
            get
            {
                return this.surname;
            }

            private set
            {
                this.surname = value;
            }
        }

        public int Weight { get; set; }
        #endregion
    }
}
