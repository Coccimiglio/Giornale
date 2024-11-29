namespace Giornale.Model;

public class CommentoDelDirettore: Commento
{
    public CommentoDelDirettore(string testo) : base(testo)
    {
        
    }
    public override string ToString()
    {
        return $"!!! {this.Testo}";
    }
}