using System;


namespace osztallyok
{
    public class Diak
    {
        public string Nev { get; set; }
        public int Kor { get; set; }
        public string Iskola { get; set; }

        public void Bemutatkozas()
        {
            Console.WriteLine($"Szia, a nevem {Nev}, {Kor} éves vagyok és a(z) {Iskola} iskolába járok.");
        }

        // Metódus: eldönti, hogy nagykorú-e
        public bool NagykoruE()
        {
            return Kor >= 18;
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            // Példányosítás → létrehozunk egy "valódi diákot"
            Diak diak1 = new Diak
            {
                Nev = "Marci",
                Kor = 17,
                Iskola = "Neumann János Technikum"
            };

            // Másik diák
            Diak diak2 = new Diak
            {
                Nev = "Anna",
                Kor = 19,
                Iskola = "Szegedi Egyetem"
            };

            // Osztály használata
            diak1.Bemutatkozas();
            Console.WriteLine($"Nagykorú-e? {diak1.NagykoruE()}");
        }
    }
}