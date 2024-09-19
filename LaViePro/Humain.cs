namespace LaViePro
{
    internal class Humain
    {
        public void SeDeplacer(Meteo meteo)
        {
            var moyenDeplacement = FabricMoyenDeDeplacement.Create(meteo);
            moyenDeplacement.Avancer();
        }
    }
}
