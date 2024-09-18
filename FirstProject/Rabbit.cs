namespace FirstProject
{
    internal class Rabbit : Animal
    {
        public override void Eat(int qty)
        {
            Console.WriteLine("Je mange des carottes .... gniac gniacc");
        }

        public override void Sleep(int duration)
        {
            base.Sleep(duration);
            Console.WriteLine("Je dors dans un terrier");
        }
    }
}
