using System.Drawing;

namespace FirstProject
{
    internal class Bird : Animal
    {
        public Color ColorBeak { get; set; }

        public override void Eat(int qty)
        {
            throw new NotImplementedException();
        }
    }

    internal class FlyingBird : Bird, IAbilityToFly
    {
        public int NbWings { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Fly()
        {
            Console.WriteLine("I'm flying !");
        }
    }
}
