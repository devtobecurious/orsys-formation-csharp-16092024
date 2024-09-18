namespace FirstProject
{
    internal class Eagle : Animal
    {
        public override void Sleep(int duration)
        {
            //   base.Sleep(duration);
            Console.WriteLine("Je dors dans un nid, je suis un aigle quand meme");
        }

        public void SitUp()
        {
            Console.WriteLine("I' m the best");
        }

        public override void Eat(int qty)
        {
            Console.WriteLine("Je mange des rats {0} fois", qty);
        }
    }
}
