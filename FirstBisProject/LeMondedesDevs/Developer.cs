﻿namespace LeMondedesDevs
{
    internal delegate void CreerCode(Developer dev, Code code);

    internal class Developer
    {
        public event CreerCode CodeFini;

        public void Ecrire()
        {
            this.CodeFini?.Invoke(this, new Code("<html></html>"));
        }
    }
}
