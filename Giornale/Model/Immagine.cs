namespace Giornale.Model;

public class Immagine : Post
{
    private string LinkImmagine { get; set; }
    public Immagine()
    {
        
    }

    public Immagine(string nome, string titolo, List<Commento> commenti,string linkImmagine) : base(nome, titolo, commenti)
    {
        this.LinkImmagine = linkImmagine;
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
        return $"Autore : {this.Nome};\nTitolo : {this.Titolo};\n \nContenuto:\n[{LinkImmagine}]\n \nCommenti : [\n{commenti}]";
    }

    public static bool operator ==(Immagine a, Immagine b)
    {
        if (a == b && a.LinkImmagine == b.LinkImmagine)
        {
            return true;
        }
        return false;
    }

    public static bool operator !=(Immagine a, Immagine b)
    {
        if (!(a == b && a.LinkImmagine == b.LinkImmagine))
        {
            return true;
        }
        return false;
    }
}