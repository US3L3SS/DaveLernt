
namespace DaveLernt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Zeichenketten
            string abc = "ich bin ein string";
            char a = 'a';
            //Nummerische
            //Ganzzahl
            Console.WriteLine($"Int: {int.MinValue} - {int.MaxValue}");
            Console.WriteLine($"Uint: {uint.MinValue} - {uint.MaxValue}");
            Console.WriteLine($"Nint: {nint.MinValue} - {nint.MaxValue}");
            short b = 2;
            Console.WriteLine($"Short: {short.MinValue} - {short.MaxValue}");
            int c = 3;
            //Gleitkommazahlen
            float f = 4.2f;
            Console.WriteLine($"Float: {float.MinValue} - {float.MaxValue}");
            double g = 4.478575;
            Console.WriteLine($"Double: {double.MinValue} - {double.MaxValue}");
            decimal h = 4.4m;
            Console.WriteLine($"Decimal: {decimal.MinValue} - {decimal.MaxValue}");
            //operatischer
            bool abcd = true;
            Haarfarben haarfarben = Haarfarben.hdsajkdhasj;
            var transformer = 2;
        }
    }
    public enum Haarfarben
    {
        Blond,
        Schwarz,
        Rot,
        Braun,
        Glatze,
        DeineMum,
        hdsajkdhasj
    }
}
