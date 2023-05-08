using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Futbol_Oyunu
{
    internal class Futbol
    {
        public Random RastgeleSayi=new Random();
        protected string AdSoyad;
        protected int FormaNo;
        protected int Hiz;
        protected int Dayaniklilik;
        protected int Pas;
        protected int Sut;
        protected int Yetenek;
        protected int Kararlilik;
        protected int DogalForm;
        protected int Sans;

        public Futbol(string AdSoyad,int FormaNo) 
        { 
            Hiz=RastgeleSayi.Next(50,101);
            Dayaniklilik = RastgeleSayi.Next(50, 101);
            Pas = RastgeleSayi.Next(50, 101);
            Sut = RastgeleSayi.Next(50, 101);
            Yetenek = RastgeleSayi.Next(50, 101);
            Kararlilik = RastgeleSayi.Next(50, 101);
            DogalForm = RastgeleSayi.Next(50, 101);
            Sans = RastgeleSayi.Next(50, 101);
        }
        public Futbol()
        {

        }
        public virtual Boolean PasVer()
        {
            int PasSkor = Convert.ToInt32(Pas * 0.3 + Yetenek * 0.3 + Dayaniklilik * 0.3 + DogalForm * 0.1 + Sans * 0.2);
            if (PasSkor > 60)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public virtual Boolean GolVurusu()
        {
            int GolSkor = Convert.ToInt32(Yetenek * 0.3 + Sut * 0.2 + Kararlilik * 0.1 + DogalForm * 0.1 + Hiz * 0.1 + Sans * 0.2);
            if (GolSkor > 70)
            {
                return true;
            }
            else { return false; }
        }

    }
    class Defans : Futbol
    {
        private int PozisyonAlma;
        private int Kafa;
        private int Sicrama;
        public Defans(string AdSoyad, int FormaNo)
        {
            this.AdSoyad = AdSoyad;
            this.FormaNo = FormaNo;
            Hiz = RastgeleSayi.Next(50, 91);
            Dayaniklilik = RastgeleSayi.Next(50, 91);
            Pas = RastgeleSayi.Next(50, 91);
            Sut = RastgeleSayi.Next(50, 91);
            Yetenek = RastgeleSayi.Next(50, 91);
            Kararlilik = RastgeleSayi.Next(50, 91);
            DogalForm = RastgeleSayi.Next(50, 91);
            Sans = RastgeleSayi.Next(50, 91);
            PozisyonAlma = RastgeleSayi.Next(50, 91);
            Kafa = RastgeleSayi.Next(50, 91);
            Sicrama = RastgeleSayi.Next(50, 91);
        }
        public override Boolean PasVer()
        {
            int PasSkor = Convert.ToInt32(Pas * 0.3 + Yetenek * 0.3 + Dayaniklilik * 0.1 + DogalForm * 0.1 + Sans * 0.2);
            if (PasSkor > 60)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override Boolean GolVurusu()
        {
            int GolSkor = Convert.ToInt32(Yetenek * 0.3 + Sut * 0.2 + Kararlilik * 0.1 + DogalForm * 0.1 + Hiz * 0.1 + Sans * 0.1+Kafa*0.1+Sicrama*0.1);
            if (GolSkor > 70)
            {
                return true;
            }
            else { return false; }
        }
    }
    class OrtaSaha : Futbol
    {
        private int UzunTop;
        private int IlkDokunus;
        private int Uretkenlik;
        private int TopSurme;
        private int OzelYetenek;
        public OrtaSaha(string AdSoyad, int FormaNo)
        {
            this.AdSoyad = AdSoyad;
            this.FormaNo = FormaNo;
            Hiz = RastgeleSayi.Next(60, 101);
            Dayaniklilik = RastgeleSayi.Next(60, 101);
            Pas = RastgeleSayi.Next(60, 101);
            Sut = RastgeleSayi.Next(60, 101);
            Yetenek = RastgeleSayi.Next(60, 101);
            Kararlilik = RastgeleSayi.Next(60, 101);
            DogalForm = RastgeleSayi.Next(60, 101);
            Sans = RastgeleSayi.Next(60, 101);
            UzunTop = RastgeleSayi.Next(60, 101);
            IlkDokunus = RastgeleSayi.Next(60, 101);
            Uretkenlik = RastgeleSayi.Next(60, 101);
            TopSurme = RastgeleSayi.Next(60, 101);
            OzelYetenek = RastgeleSayi.Next(60, 101);
        }
        public override Boolean PasVer()
        {
            int PasSkor = Convert.ToInt32(Pas * 0.3 + Yetenek * 0.2 + Dayaniklilik * 0.1 + DogalForm * 0.1 + UzunTop*0.1+TopSurme*0.1+Sans*0.1);
            if (PasSkor > 60)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override Boolean GolVurusu()
        {
            int GolSkor = Convert.ToInt32(Yetenek * 0.3 + Sut * 0.2 +OzelYetenek*0.2+IlkDokunus*0.1+ Kararlilik * 0.1 + DogalForm * 0.1 +  Sans * 0.1);
            if (GolSkor > 70)
            {
                return true;
            }
            else { return false; }
        }
    }
    class Forvet : Futbol
    {
        private int Bitiricilik;
        private int IlkDokunus;
        private int Kafa;
        private int OzelYetenek;
        private int SogukKanlilik;

        public Forvet(string AdSoyad, int FormaNo)
        {
            this.AdSoyad = AdSoyad;
            this.FormaNo = FormaNo;
            Hiz = RastgeleSayi.Next(70, 101);
            Dayaniklilik = RastgeleSayi.Next(70, 101);
            Pas = RastgeleSayi.Next(70, 101);
            Sut = RastgeleSayi.Next(70, 101);
            Yetenek = RastgeleSayi.Next(70, 101);
            Kararlilik = RastgeleSayi.Next(70, 101);
            DogalForm = RastgeleSayi.Next(70, 101);
            Sans = RastgeleSayi.Next(70, 101);
            Bitiricilik = RastgeleSayi.Next(70, 101);
            IlkDokunus = RastgeleSayi.Next(70, 101);
            Kafa = RastgeleSayi.Next(70, 101);
            OzelYetenek = RastgeleSayi.Next(70, 101);
            SogukKanlilik = RastgeleSayi.Next(70, 101);
        }
        public override Boolean PasVer()
        {
            int PasSkor = Convert.ToInt32(Pas * 0.3 + Yetenek * 0.2 + Dayaniklilik * 0.1 + DogalForm * 0.1 + Sans * 0.1);
            if (PasSkor > 60)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override Boolean GolVurusu()
        {
            int GolSkor = Convert.ToInt32(Yetenek * 0.2+ OzelYetenek*0.2+ Sut * 0.1+Kafa*0.1+IlkDokunus*0.1+Bitiricilik*0.1+SogukKanlilik*0.1 + Kararlilik * 0.1 + DogalForm * 0.1 + Sans * 0.1);
            if (GolSkor > 70)
            {
                return true;
            }
            else { return false; }
        }

    }

    

}
