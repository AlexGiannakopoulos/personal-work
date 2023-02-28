using System.Globalization;

namespace Exercise3OOP;

public class Cars
{
    public string Num { get; set; }
    public string Brand { get; set; }
    public int Km { get; set; }
    
    public Cars(string Num, string Brand, int Km)
    {
        this.Num = Num;
        this.Brand = Brand;
        this.Km = Km;
    }

    public override string ToString()
    {
        return "Car Number: " + Num + " Car brand: " + Brand + " Car Kilometres travelled: " + Km;
    }
}