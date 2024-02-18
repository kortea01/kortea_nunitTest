using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestDolgozatProject
{

    private Array pontok = new Array[];


    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PontFelvesz(int x)
        {
            //TODO: Hozzáad egy pontszámot a listához.Érvénytelen paraméter  esetén  (x  < -1  vagy  x  >  100)  ez  a  függvény  dobjon ArgumentException-t.
        }
        public bool MindenkiMegirta()
        {
            //TODO: Volt-e olyan diák, aki nem írt dolgozatot.
            return true;
        }

        public int Bukas()
        {
            //TODO: Adja  vissza hányan értek el 50 pontnál kevesebbet!C#  gettert használj!Figyeljen oda, hogy csak azokat a tanulókat számolja, akik megírták a dolgozatot.
            return 0;
        }

        public int Elegseges()
        {
            //TODO: Adja vissza hányan értek el [50,60] pont közötti értéket.A szélsőértékeket is számolja bele! C# gettert használj!
            return 0;
        }

        public int Kozepes()
        {
            //TODO: Adja vissza hányan értek el [61,70] pont közötti értéket.A szélsőértékeket is számolja bele! C# gettert használj!
            return 0;
        }

        public int Jo()
        {
            //TODO: Adja vissza hányan értek el [71,80] pont közötti értéket.A szélsőértékeket is számolja bele! C# gettert használj!
            return 0;
        }

        public int Jeles()
        {
            //TODO: Adja vissza hányan értek el 81 pontnál többet. C# gettert használj.
            return 0;
        }

        public bool Gyanus(int kivalok)
        {
            //TODO: Adja vissza, hogya kivalo tanulok számánál lett-e több jeles osztályzat (db).
            //(Pl.: kivalok=5 esetén6 db jeles osztályzat született, akkor a  visszatérési  érték  IGAZ  lesz!
            //Lehetséges,  hogy  valamelyiktanuló  extra segítséget használt a dolgozat írása közben.).
            //A kivalok számát 0-tól kezdődően várja  a  függvény.
            //Érvénytelen  paraméter  esetén  ez  a  függvény  is  dobjon ArgumentException-t.
            return true;
        }

        public bool Ervenytelen()
        {
            //TODO: Adja vissza, hogy a dolgozat érvénytelen-e, és újra kell írni. A   dolgozat   akkorlesz  érvénytelen,
            //ha  a  tanulók  legalább  fele  nem  írt dolgozatot. C# gettert használj.
            return true;
        }



    }
}
