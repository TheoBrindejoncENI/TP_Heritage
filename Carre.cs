using System;

namespace TP01
{
    public class Carre : Rectangle
    {
        public override int Largeur => Longueur;

        public override string ToString()
        {
            return $"Carre de cote={Longueur}" + Environment.NewLine + base.ToString(true);
        }
    }
}