namespace Giornale.Model;

public class Commento
{
    public string Testo { get; set; }

    public Commento(string testo)
    {
        this.Testo = testo;
    }

    public Commento()
    {
        
    }

    public override string ToString()
    {
        return Testo;
    }
}