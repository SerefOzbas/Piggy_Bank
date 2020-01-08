using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank
{
   public class Para:PiggyBank
    {
     public decimal Yukseklik { get; set; }
        public ParaAdi ParaTuru { get; set; }
        public decimal ParaDegeri { get; set; }
        private bool _KagitMi;
        public bool KagitMi
        {
            get
            {
                if (ParaTuru == (ParaAdi)0 || ParaTuru == (ParaAdi)1 || ParaTuru == (ParaAdi)2 || ParaTuru == (ParaAdi)3 || ParaTuru == (ParaAdi)4 || ParaTuru == (ParaAdi)5)
                {
                    _KagitMi = false;
                }
                else
                {
                    _KagitMi = true;
                }
                return _KagitMi;
            }
        }

     
        public void ParaDegerim(ParaAdi paraturu)
        {
            if (paraturu == (ParaAdi)0)
            {
                ParaDegeri = 0.01m;
            }
            else if (paraturu == (ParaAdi)1)
            {
                ParaDegeri = 0.05m;
            }
            else if (paraturu == (ParaAdi)2)
            {
                ParaDegeri = 0.1m;
            }
            else if (paraturu == (ParaAdi)3)
            {
                ParaDegeri = 0.25m;
            }
            else if (ParaTuru == (ParaAdi)4)
            {
                ParaDegeri = 0.5m;
            }
            else if (ParaTuru == (ParaAdi)5)
            {
                ParaDegeri = 1;
            }
            else if (ParaTuru == (ParaAdi)6)
            {
                ParaDegeri = 5;
            }
            else if (ParaTuru == (ParaAdi)7)
            {
                ParaDegeri = 10;
            }
            else if (ParaTuru == (ParaAdi)8)
            {
                ParaDegeri = 20;
            }
            else if (ParaTuru == (ParaAdi)9)
            {
                ParaDegeri = 50;
            }
            else if (ParaTuru == (ParaAdi)10)
            {
                ParaDegeri = 100;

            }
            else if (ParaTuru == (ParaAdi)11)
            {
                ParaDegeri = 200;

            }
        }

    }
    public enum ParaAdi
    {
        BirKurus=0,
        BesKurus=1,
        OnKurus,
        YirmiBesKurus,
        ElliKurus,
        BirLira,
        BesLira,
        OnLira,
        YirmiLira,
        ElliLira,
        YuzLira,
        IkiYuzLira,
    }

}
