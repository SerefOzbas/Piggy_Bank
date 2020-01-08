using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank
{
    public class KagitPara : Para
    {
        private decimal _Boy;
      public  decimal Boy
        {
            get
            {

                if (ParaTuru == (ParaAdi)6 || ParaTuru == (ParaAdi)7)
                {
                    _Boy = (decimal)6.4;
                }
                else if (ParaTuru == (ParaAdi)8 || ParaTuru == (ParaAdi)9)
                {
                    _Boy = (decimal)6.8;
                }
                else if (ParaTuru == (ParaAdi)10 || ParaTuru == (ParaAdi)11)
                {
                    _Boy = (decimal)7.2;
                }
                return _Boy;
            }
           
        }

        private decimal _En;
        public decimal En
        {
            get
            {
                if (ParaTuru == (ParaAdi)6)
                {
                    _En = 13;
                }
                else if (ParaTuru == (ParaAdi)7)
                {
                    _En = 13.6m;
                }
                else if (ParaTuru == (ParaAdi)8)
                {
                    _En = 14.2m;
                }
                else if (ParaTuru == (ParaAdi)9)
                {
                    _En = 14.8m;
                }
                else if (ParaTuru == (ParaAdi)10)
                {
                    _En = 15.4m;
                }
                else if (ParaTuru == (ParaAdi)11)
                {
                    _En = 16;
                }
                
                return _En;
            }
           
        }

       
        public void KagitParaHacimHesapla(ParaAdi paraturu)
        {
            if (KagitMi==true)
            {
                Yukseklik = 0.025m;
                Hacmi = (En/4) * Boy * (Yukseklik * 4);
            }

        }

    }
      
}
