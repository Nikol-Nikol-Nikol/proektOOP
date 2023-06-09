using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RezervniChasti
{
    public abstract class RezervnaChast: IPrint
    {
        private string vidStoka;
        private string markaKoli;
        private int kolichestvo;
        private decimal cena;
        private string mernaEdinica;
        

        public string VidStoka
        {
            get { return vidStoka; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("value");
                }
                this.vidStoka = value;
            }
        }

        public string MarkaKoli
        { 
            get { return markaKoli; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("value");
                }
                this.markaKoli = value;
            }
        }
        public int Kolichestvo
        {
            get { return kolichestvo; }
            set
            {
                if (value<0)
                {
                    throw new ArgumentException("value");
                }
                this.kolichestvo = value;
            }
        }
        public decimal Cena
        {
            get { return cena; }
            set
            {
                if (value<0)
                {
                    throw new ArgumentException("value");
                }
                this.cena = value;
            }
            
        }
        public string MernaEdinica
        {
            get { return mernaEdinica; }
            set
            {
                if (string.IsNullOrEmpty ("value"))
                {
                    throw new ArgumentException("value");
                }  
                this.mernaEdinica = value;
            }
        }
        public RezervnaChast(string vidStoka, string markaKoli, 
        int kolichestvo, decimal cena, string mernaEdinica )
        {
            this.VidStoka=vidStoka;
            this.MarkaKoli=markaKoli;
            this.Kolichestvo=kolichestvo;
            this.Cena=cena;
            this.MernaEdinica=mernaEdinica;
            
        }
        public virtual void Print()
        {
            Console.WriteLine($"{this.vidStoka} {this.markaKoli}" +
                $" {this.kolichestvo} {this.cena} {this.mernaEdinica}");
        }

        public abstract decimal IzchisliSrednoKolichestvo();

    }

}
