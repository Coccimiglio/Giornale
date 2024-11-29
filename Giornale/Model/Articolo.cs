namespace Giornale.Model;

public class Articolo : Post
{
    private string Testo { get; set; }
    public Articolo()
    {
        
    }

    public Articolo(string nome, string titolo, List<Commento> commenti,string testo) : base(nome, titolo, commenti)
    {
        this.Testo = testo;
    }

    public void AggiungiCommento(Commento commento)
    {
        base.AggiungiCommento(commento);
    }
    
    public void AggiungiCommenti(List<Commento> commenti)
    {
        base.AggiungiCommenti(commenti);
    }

    public override string ToString()
    {
        string commenti = "";
        foreach (var item in base.getCommenti())
        {
            commenti += $"'{item}';\n";
        }
        return $"Autore : {this.Nome};\nTitolo : {this.Titolo};\n \nContenuto:\n[{Testo}]\n \nCommenti : [\n{commenti}]";
    }

    public static bool operator ==(Articolo a, Articolo b)
    {
        if (a == b && a.Testo == b.Testo)
        {
            return true;
        }
        return false;
        /*if (a.Nome == b.Nome && a.Titolo == b.Titolo)
        {
            return true;
        }
        return false;*/
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