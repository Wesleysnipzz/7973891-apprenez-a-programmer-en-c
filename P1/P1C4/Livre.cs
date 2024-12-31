namespace P1C4;

public class Livre
{
    public string Titre { get; set; }
    public string Auteur { get; set; }
    public int NombreDePages { get; set; }

    // Ajouter un constructeur pour initialiser les propriétés non-nullables
    public Livre()
    {
        Titre = string.Empty;
        Auteur = string.Empty;
        NombreDePages = 0;
    }
}
