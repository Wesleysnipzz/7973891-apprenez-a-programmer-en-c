// TODO : Déclarer une variable nommée couleurs d'un array de string de longueur 5
string[] couleurs = new string[5];


// TODO : Remplir le tableau avec les couleurs demandées dans le README.md
string[] nombreDeCouleurs = new string[] {"rouge", "jaune", "orange", "vert", "bleu"};

// TODO : Remplacer vert par émeraude dans le tableau
nombreDeCouleurs[3] = "émeraude";

// Afficher le contenu du tableau
foreach (string couleur in nombreDeCouleurs)
{
    Console.WriteLine(couleur);
}