using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank
{
    class DemirPara:Para
    {
        public decimal Pi { get; set; }
        private decimal _YariCap;
      public  decimal YariCap
        {
            get
            {
                if (ParaTuru == (ParaAdi)0 || ParaTuru == (ParaAdi)1)
                {
                    _YariCap = 0.85m;
                }
                
                else if (ParaTuru == (ParaAdi)2)
                {
                    _YariCap =0.96m;
                }
                else if (ParaTuru == (ParaAdi)3)
                {
                    _YariCap = 1.075m;
                }
                else if (ParaTuru == (ParaAdi)4)
                {
                    _YariCap = 1.19m;
                }
                else if (ParaTuru == (ParaAdi)5)
                {
                    _YariCap = 1.30m;
                }

                return _YariCap;
            }
        }
        public void DemirParaHacimHesapla(ParaAdi paraturu)
        {
            Pi = 3;
            if (KagitMi==false)
            {
                if (paraturu == (ParaAdi)0)
                {
                    Yukseklik = 0.165m;
                }
                else if (paraturu == (ParaAdi)1 || paraturu == (ParaAdi)2)
                {
                    Yukseklik = 0.17m;
                }
                else if (paraturu == (ParaAdi)3)
                {
                    Yukseklik = 0.19m;
                }
                else if (paraturu == (ParaAdi)4 || paraturu == (ParaAdi)5)
                {
                    Yukseklik = 0.195m;
                }
                else
                {
                    Yukseklik = 0;
                }

                Hacmi = Pi * YariCap * YariCap * Yukseklik;

            }



        }
    }
}
