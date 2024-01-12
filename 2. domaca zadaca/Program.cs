using System;
using System.Xml.Serialization;

namespace zadaca
{
    //SRP
    public class Skladistar
    {
        public void StanjeSkladista(int kutije) { }

        public void Utovar(int kutije) { }

        public void PrijevozRobe(int kutije) { }

    }


    /* 
        lose je to sto skladistar ne obavlja prijevoz robe, to bi trebao obavljati prijevoznik
        tako da metoda PrijevozRobe treba biti u posebnoj klasi Prijevoznik. Svaka klasa treba biti odgovorna za sebe
        
    */


    //OCP
    public class Placanje
    {
        public void IzvrsiPlacanje(decimal iznos) { }
    }

    public class KreditnaKartica : Placanje
    {
        public void IzvrsiPlacanje(decimal iznos) { }
    }

    /*
        problem je sto imamo vise vrsta placanj: gotovinom, kreditnom karticom, virmanom ...
        metoda IzvrsiPlacanje nece biti ista za sve oblike placanja. Rjesenje bi bilo da ju stavimo u interface.
        time ne bi imali potrebu mjenjati kod.
    */



    // LSP
    public class Vozilo
    {
        public virtual void Putnici() { }
       
    }
    public class Bicikl : Vozilo
    {
        public override void Putnici() { }
        
    }
    public class Avion : Vozilo
    {
        public override void Putnici() { }
       
    }
    
    /*
        problem je sto bicikl ne moze imati putnike te time nema smisla metoda Putnici.
        time dijete klase ne moze zamijeniti roditelja klase.
    */


    // ISP

    public interface IZaposlenik
    {
        public void UtovarKamiona();
        public void PrijevozRobe();
        
    }

    public class Skladistar2 : IZaposlenik
    {
        public void PrijevozRobe() { }
       

        public void UtovarKamiona() { }
       
    }

    public class Prijevoznik : IZaposlenik
    {
        public void PrijevozRobe() { }
       
        public void UtovarKamiona() { }
        
    }

    /*
        problem je u tome sto slicno kao u prvom zadatku Skladistar ne izvrsava funkciju prijevoza robe
        time krsi pravilo ISP jer interface ne moze biti implentiran u svaku klasu
    */

    //DIP
    
    public class Kuća
    {
        private Žarulja žarulja;

        public Kuća()
        {
            žarulja = new Žarulja();
        }

        public void OsvijetliDnevnuSobu()
        {
            žarulja.Upali();
            Console.WriteLine("Dnevna soba je osvijetljena.");
        }
    }
    public class Žarulja
    {
        public void Upali()
        {
            Console.WriteLine("Žarulja je upaljena.");
        }
    }

    /*
        problem je sto kuca ovisi o zarulji.Time se stvara cvrsta ovisnost prema specificnoj implementaciji umjesto prema apstrakciji.
        rjesenje bi bilo da implementiramo sucelje IIzvorSvijetla
    */

}