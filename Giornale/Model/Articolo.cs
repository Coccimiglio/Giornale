namespace Giornale.Model;

public class Articolo
{
    public string Nome { get; set; }
    public string Titolo { get; set; }
    private List<Commento> Commenti= new List<Commento>();
    public Articolo()
    {
        
    }

    public Articolo(string nome, string titolo, List<Commento> commenti)
    {
        this.Nome = nome;
        this.Titolo = titolo;
        this.Commenti = commenti;
    }

    public void AggiungiCommento(Commento commento)
    {
        this.Commenti.Add(commento);
    }
    
    public void AggiungiCommenti(List<Commento> commenti)
    {
        foreach (var item in this.Commenti)
        {
            if (!Commenti.Contains(item))
            {
                this.Commenti.Add(item);
            }
        }
    }

    public override string ToString()
    {
        string commenti = "";
        foreach (var item in this.Commenti)
        {
            commenti += $"{item}\n \n";
        }
        return $"Autore : {this.Nome} \n Titolo : {this.Titolo} \n \n Commenti : {commenti}";
    }

    public static bool operator ==(Articolo a, Articolo b)
    {
        if (a.Nome == b.Nome && a.Titolo == b.Titolo)
        {
            return true;
        }
        return false;
    }

    public static bool operator !=(Articolo a, Articolo b)
    {
        if (!(a.Nome == b.Nome && a.Titolo == b.Titolo))
        {
            return true;
        }
        return false;
    }
}