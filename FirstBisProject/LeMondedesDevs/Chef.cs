namespace LeMondedesDevs
{
    internal class Chef : IDisposable
    {
        public void Sennuyer() { }

        public void CroireLireLeCode(Developer dev, Code code)
        {
            Console.WriteLine("Je suis au courant du code réalisé");
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
