using System.Numerics;

namespace TP4_Heritage
{
    public class ComptePayant : Compte
    {
        private const decimal Commission = 5;   

        public ComptePayant(string nom) : base(nom) { }

        public ComptePayant(string nom, decimal soldeInitial) : base(nom, soldeInitial) { }

        public override void Deposer(decimal montant)
        {
            base.Deposer(montant);
            Solde -= Commission;
        }

        public override void Retirer(decimal montant)
        {
            base.Retirer(montant);
            Solde -= Commission;
        }
    }
}