class Locataire
{
    protected static int id = 0;
    protected string nom;
    protected string telephone;

    public Locataire(string nom, string telephone)
    {
        this.nom = nom;
        this.telephone = telephone;
        id+=1;
    }

    public virtual void Afficher()
    {
        Console.WriteLine($"ID : {id} | Nom : {nom} | Telephone : {telephone}");
    }
}