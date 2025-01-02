IDictionary<string, int> mois = new Dictionary<string, int>();

// TODO : Remplacer les noms par des constantes de type chaine de 
const string monthJ = "Juin";
const string monthS = "Septembre";
const string monthM = "Mars";
mois.Add(monthJ, 6);
mois.Add(monthS, 9);
mois.Add(monthM, 5);

// TODO : Corriger la valeur de Mars avec (3)
mois[monthM] = 3;

// TODO : Retirer Juin

mois.Remove(monthJ);
// Afficher le contenu du dictionnaire
Console.WriteLine("La liste des mois est : ");
foreach (KeyValuePair<string, int> clePaire in mois)
{
    Console.WriteLine(clePaire.Key.ToString() + " est le numéro du mois de " + clePaire.Value + " de l'année ");
}