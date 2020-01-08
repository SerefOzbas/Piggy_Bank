using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiggyBank
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<ParaAdi> paralar = new List<ParaAdi>();
        List<decimal> kirincaParam = new List<decimal>();

        Para para = new Para();
        Kumbara kumbara = new Kumbara();
        KagitPara kagitpara = new KagitPara();
        DemirPara demirpara = new DemirPara();
        private void Form1_Load(object sender, EventArgs e)
        {
            kumbara.Hacmi = 30;
            cmbParaAt.DataSource = Enum.GetValues(typeof(ParaAdi));
        }

        Random rnd = new Random();

        decimal toplampara=0;
        decimal toplamkahitparahacim=0;
        decimal toplamdemirparahacim=0;
        decimal butunparahacmi=0;
        private void Button1_Click(object sender, EventArgs e)
        {
            if (kumbara.Hacmi < butunparahacmi)
            {
                MessageBox.Show("Kumbaranız dolmuştur.Sallamayı deneyiniz.");
            }
            else
            {
                para.ParaTuru = (ParaAdi)cmbParaAt.SelectedItem;
                para.ParaDegerim(para.ParaTuru);
                label13.Text = para.ParaTuru.ToString();
                paralar.Add(para.ParaTuru);
                toplampara += para.ParaDegeri;
                label14.Text = toplampara.ToString();
                int sayi = rnd.Next(25, 76);


                kagitpara.ParaTuru = (ParaAdi)cmbParaAt.SelectedItem;
                kagitpara.KagitParaHacimHesapla(kagitpara.ParaTuru);
                kagitpara.Hacmi = (kagitpara.Hacmi * sayi) / 100;
                toplamkahitparahacim += kagitpara.Hacmi;

                demirpara.ParaTuru = (ParaAdi)cmbParaAt.SelectedItem;
                demirpara.DemirParaHacimHesapla(demirpara.ParaTuru);
                demirpara.Hacmi = demirpara.Hacmi * sayi / 100;
                toplamdemirparahacim += demirpara.Hacmi;


                butunparahacmi = toplamdemirparahacim + toplamkahitparahacim;

                label3.Text = butunparahacmi.ToString();
            }

          


          

        }

        int sayac = 0;
        private void BtnKumbaraKir_Click(object sender, EventArgs e)
        {
            btnParaAt.Enabled = false;
            btnKumbaraSalla.Enabled = false;
            if (sayac==0)
            {
                kirincaParam.Add(toplampara);
                label5.Text = toplampara.ToString();
            }
            else if (sayac == 1)
            {
                kirincaParam.Add(toplampara);
                label16.Text = toplampara.ToString();
            }

            toplampara = 0;
            butunparahacmi = 0;
            toplamkahitparahacim = 0;
            toplamdemirparahacim = 0;
            sayac++;
        }

        private void BtnKumbaraSalla_Click(object sender, EventArgs e)
        {
            butunparahacmi = 0;
            toplamdemirparahacim = 0;
            toplamkahitparahacim = 0;

            for (int i = 0; i < paralar.Count; i++)
            {
                
                    kagitpara.ParaTuru = paralar[i];
                    kagitpara.KagitParaHacimHesapla(kagitpara.ParaTuru);
                    kagitpara.Hacmi = kagitpara.Hacmi * 25 / 100;
                    toplamkahitparahacim += kagitpara.Hacmi;
                             
                    demirpara.ParaTuru = paralar[i];
                    demirpara.DemirParaHacimHesapla(demirpara.ParaTuru);
                    demirpara.Hacmi = demirpara.Hacmi * 25 / 100;
                    toplamdemirparahacim += demirpara.Hacmi;
                        
            }
            butunparahacmi = toplamdemirparahacim + toplamkahitparahacim;
            label4.Text = butunparahacmi.ToString();

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            btnParaAt.Enabled = true;
            btnKumbaraSalla.Enabled = true;
            if (sayac==2)
            {
                btnParaAt.Enabled = false;
                btnKumbaraKir.Enabled = false;
                btnKumbaraSalla.Enabled = false;
                for (int i = 0; i < kirincaParam.Count; i++)
                {
                    toplampara+=kirincaParam[i];
                }
                label6.Text = toplampara.ToString();
                button1.Enabled = false;
            }
           
        }
    }
}
