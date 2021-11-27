using System;

namespace Zadanie1._2
{
    internal class Program
    { 
        public class Pracownik
        {
            public String imie,nazwisko,stanowisko,plec;
            public int wiek;
            
            public void Show()
            {
                Console.WriteLine(imie);
                Console.WriteLine(nazwisko);
                Console.WriteLine(stanowisko);
                Console.WriteLine(wiek);
            }
            public void isMatch()
            {

            }
        }
        public class kartoteka<T> where T : Pracownik
        {
            public T pole;
            public T Property { get; set; }
            public void dodawanie
            {
                
            }
            public void usuwanie
            {

            }
            public void wyswietlanie
            {

            }
            public void walidacja
            {

            }
            public void wyszukiwanie
            {

            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
