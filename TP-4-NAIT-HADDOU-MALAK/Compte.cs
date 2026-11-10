using System;

namespace TP4_Heritage
{
    public class Compte
    {
        private static int compteur = 0;      

        public int Code { get; }            
        public string Nom { get; }            
        public decimal Solde { get; protected set; }  

        
        public Compte(string nom)
        {
            compteur++;
            Code = compteur;
            Nom = nom;
            Solde = 0;
        }

       
        public Compte(string nom, decimal soldeInitial) : this(nom)
        {
            Solde = soldeInitial;
        }

        public virtual void Deposer(decimal montant)
        {
            Solde += montant;
        }

        public virtual void Retirer(decimal montant)
        {
            Solde -= montant;   
        }

        public override string ToString()
        {
            return $"Compte n°{Code} | Titulaire : {Nom} | Solde : {Solde}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Compte autre)
                return Code == autre.Code;
            return false;
        }

        public override int GetHashCode()
        {
            return Code.GetHashCode();
        }
    }
}