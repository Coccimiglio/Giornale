namespace Giornale.Model;

public class Post : IEquatable<Post>
{
    public string Nome { get; set; }
    public string Titolo { get; set; }
    private List<Commento> Commenti= new List<Commento>();
    public Post()
    {
        
    }

    public Post(string nome, string titolo, List<Commento> commenti)
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
            commenti += $"'{item}';\n";
        }
        return $"Autore : {this.Nome};\nTitolo : {this.Titolo};\n \nCommenti : [\n{commenti}]";
    }

    public static bool operator ==(Post a, Post b)
    {
        if (a.Nome == b.Nome && a.Titolo == b.Titolo)
        {
            return true;
        }
        return false;
    }

    public static bool operator !=(Post a, Post b)
    {
        if (!(a.Nome == b.Nome && a.Titolo == b.Titolo))
        {
            return true;
        }
        return false;
    }

    public List<Commento> getCommenti()
    {
        return this.Commenti;
    }

    public bool Equals(Post? other)
    {
        if (other is null) return false;
        if (ReferenceEquals(this, other)) return true;
        return Commenti.Equals(other.Commenti) && Nome == other.Nome && Titolo == other.Titolo;
    }

    public override bool Equals(object? obj)
    {
        if (obj is null) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != GetType()) return false;
        return Equals((Post)obj);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Commenti, Nome, Titolo);
    }
}