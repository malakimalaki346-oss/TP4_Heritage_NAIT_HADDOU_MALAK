namespace TP4_Heritage
{
    public class CompteEpargne : Compte
    {
        public decimal TauxInteret { get; set; }   // en pourcentage, ex : 3 pour 3 %

        public CompteEpargne(string nom, decimal tauxInteret) : base(nom)
        {
            TauxInteret = tauxInteret;
        }

        public CompteEpargne(string nom, decimal soldeInitial, decimal tauxInteret)
            : base(nom, soldeInitial)
        {
            TauxInteret = tauxInteret;
        }

        public void CalculInteret()
        {
            Solde += Solde * TauxInteret / 100;
        }

        public override string ToString()
        {
            return base.ToString() + $" | Taux : {TauxInteret}%";
        }
    }
}