using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezervniChasti
{
    public class Magazin
    {
        public List<RezervnaChast> RezervniChasti { get; set; }
        public object Kolichestvo { get; private set; }

        public Magazin()
        {
            RezervniChasti = new List<RezervnaChast>();
        }


        public void NapishiRezervnaChast(string VidStoka, string MarkaKoli, int Kolichestvi, decimal Cena, string MernaEdinica)
        {
            RezervnaChast novaChast = null;

            if (VidStoka == "Dvigatel")
            {
                novaChast = new Dvigatel()
                {
                    VidStoka = VidStoka,
                    MarkaKoli = MarkaKoli,
                    Kolichestvo = Kolichestvo,
                    Cena = Cena,
                    MernaEdinica = MernaEdinica
                };
            }
            else if (VidStoka == "Gumi")
            {
                novaChast = new Gumi()
                {
                    VidStoka = VidStoka,
                    MarkaKoli = MarkaKoli,
                    Kolichestvo = Kolichestvo,
                    Cena = Cena,
                    MernaEdinica = MernaEdinica
                };

            }

            else if (VidStoka == "Spirachki")
            {
                novaChast = new Spirachki()
                {
                    VidStoka = VidStoka,
                    MarkaKoli = MarkaKoli,
                    Kolichestvo = Kolichestvo,
                    Cena = Cena,
                    MernaEdinica = MernaEdinica
                };
            }

            if (novaChast != null)
            {
                RezervniChasti.Add(novaChast);
            }
        }
    }
}
