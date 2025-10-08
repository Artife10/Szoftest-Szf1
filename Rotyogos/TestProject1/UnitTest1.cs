using osztallyok;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void NagykoruE()
        {
            var diak = new Diak {
                Nev = "Pataki Renegéd",
                Kor = 12,
                Iskola = "Egik Ernõ Ob Horgász Egyetem"
            };

            var eredmeny = diak.NagykoruE();
            
            //Assert
            Assert.False(eredmeny);

        }

        [Fact]
        public void NagykoruE_true()
        {
            var diak = new Diak
            {
                Nev = "Sinóros Bandita",
                Kor = 19,
                Iskola = "Chernobyl"
            };

            var eredmeny = diak.NagykoruE();

            Assert.True(eredmeny);
        }
    }
}