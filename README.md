# TP 4 : Héritage en C# (.NET)

**EMSI - Module DotNet - Encadrant : Mr. IDMANSOUR**

**Réalisé par : Malak NAIT HADDOU**

## Objectifs

- Créer une classe dérivée
- Ajouter des méthodes à une classe dérivée
- Utiliser les membres statiques
- Redéfinir des méthodes dans une classe dérivée

## Description

Application console qui modélise des comptes bancaires avec trois classes :

| Classe | Rôle |
|---|---|
| `Compte` | Classe de base : code auto-incrémenté, nom du titulaire, solde, dépôt, retrait |
| `CompteEpargne` | Hérite de `Compte`, ajoute un taux d'intérêt et la méthode `CalculInteret()` |
| `ComptePayant` | Hérite de `Compte`, redéfinit `Deposer()` et `Retirer()` avec une commission fixe |

### Classe `Compte`

- Le **code** est généré automatiquement grâce à un membre statique.
- Le **code** et le **nom** sont en lecture seule.
- Un compte a un solde nul à sa création, ou un solde initial si on le précise.
- Le solde peut être négatif (compte débiteur).
- Méthodes : `Deposer(montant)`, `Retirer(montant)`, `ToString()`, `Equals()`.

### Classe `CompteEpargne`

- Champ supplémentaire : `TauxInteret` (en pourcentage).
- `CalculInteret()` met à jour le solde en tenant compte des intérêts.

### Classe `ComptePayant`

- Chaque dépôt et chaque retrait coûte une commission fixe (5 DH).
- Utilise `override` et `base` pour réutiliser le comportement de `Compte`.

## Structure du projet

```
TP4_NAIT_HADDOU_MALAK/
├── Compte.cs
├── CompteEpargne.cs
├── ComptePayant.cs
├── Program.cs
└── README.md
```

## Exécution

1. Ouvrir la solution dans Visual Studio.
2. Appuyer sur **F5** (ou **Ctrl+F5**).

Ou en ligne de commande, depuis le dossier du projet :

```bash
dotnet run
```

## Programme de test

Le programme crée une instance de chaque classe, puis :

1. dépose une somme dans chaque compte,
2. retire une somme de chaque compte,
3. calcule les intérêts du compte épargne,
4. affiche le solde des trois comptes.

### Résultat attendu

```
Compte n°1 | Titulaire : Malak | Solde : 700
Compte n°2 | Titulaire : Sara | Solde : 1339 | Taux : 3%
Compte n°3 | Titulaire : Aicha | Solde : 590
c1 égal à c2 ? False
```
<img width="454" height="103" alt="Captura de pantalla 2026-11-10 090141" src="https://github.com/user-attachments/assets/37e72023-70a6-48d7-ae4d-dfd9023ab215" />

## Concepts utilisés

- Héritage (`: Compte`)
- Appel du constructeur parent (`: base(...)`)
- Redéfinition de méthodes (`virtual` / `override`)
- Membre statique (compteur de comptes)
- Propriétés en lecture seule et accesseur `protected set`
