using ConstructorPratik;
using System.ComponentModel;
using System.Threading.Channels;

public class Program
{
    public static void Main(string[] args)
    {
        //Default Constructor ile bebek nesnesi oluşturma
        Bebek bebek1 = new Bebek();

        bebek1.Ad = "Serra";
        bebek1.Soyad = "Yılmaz";
        
        bebek1.BilgileriYazdir();

        // Alternatif Constructor ile bebek nesnesi oluşturma
        Bebek bebek2 = new Bebek("Ahmet", "Kara");
       
        bebek2.BilgileriYazdir();
    }     
}


