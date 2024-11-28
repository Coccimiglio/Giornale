using Giornale.Model;
using System;
namespace Giornale.Model;

public class Program
{
    public static void Main(string[] args)
    {
        Giornale giornale = new Giornale();
        List<Commento> commenti1 = new List<Commento>();
        commenti1.Add(new Commento("Sono Contento"));
        commenti1.Add(new Commento("non ci voleva"));
        commenti1.Add(new CommentoDellaRedazione("affluenza record alle urne"));
        giornale.AggiungiArticolo(new Articolo("Osvaldo","Trump Ha Vinto",commenti1));
        
        
        
        List<Commento> commenti2 = new List<Commento>();
        commenti2.Add(new Commento("Mose ci salverà"));
        giornale.AggiungiArticolo(new Articolo("lu","Acqua alta a Venezia",commenti2));

        Console.WriteLine(giornale);
    }
}