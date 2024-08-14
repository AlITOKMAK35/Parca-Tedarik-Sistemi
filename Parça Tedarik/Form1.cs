using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Parça_Tedarik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
 
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-CSING2L;Initial Catalog=parca;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'parcaDataSet.par' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.parTableAdapter.Fill(this.parcaDataSet.par);

        }
        int ruls1, ruls2, ruls3, ruls4, ruls5, ruls6;
        int rulad1, rulad2, rulad3, rulad4, rulad5, rulad6;
        int kdv1, kdv2;
        int rulbl1, rulbl2, rulbl3, rulbl4, rulbl5, rulbl6;
        int kdvtoplam;
        int rulkdvss1, rulkdvss2, rulkdvss3, rulkdvss4, rulkdvss5, rulkdvss6;
        double partoptur, parkdvtop, geneltoplams;

        private void rul1ad_SelectedIndexChanged(object sender, EventArgs e)
        {
            ruls1 = Convert.ToInt32(rul1fi.Text);
            rulad1 = Convert.ToInt32(rul1ad.Text);
            rultp1.Text = (ruls1 * rulad1).ToString();
            rulbl1 = Convert.ToInt32(rultp1.Text);
            kdv1 = 10;
            kdv2 = 100;
            rultp1.Text = (ruls1 * rulad1).ToString();
            rulbl1 = Convert.ToInt32(rultp1.Text);
            rulkdvs1.Text = (rulbl1 * kdv1 / kdv2).ToString();
            rulkdvss1 = Convert.ToInt32(rulkdvs1.Text);
            rulmansipkdv1.Text = rulkdvs1.Text;
            parctopla = rulad1 + rulad2 + rulad3 + rulad4 + rulad5 + rulad6;
            parctoplamad1.Text = parctopla.ToString();

            ruls1 = Convert.ToInt32(rul1fi.Text);
            rultp1.Text = (ruls1 * rulad1).ToString();
            rulbl1 = Convert.ToInt32(rultp1.Text);
            kdv1 = 10;
            kdv2 = 100;
            rultp1.Text = (ruls1 * rulad1).ToString();
            rulbl1 = Convert.ToInt32(rultp1.Text);
            rulkdvs1.Text = (rulbl1 * kdv1 / kdv2).ToString();
            rulkdvss1 = Convert.ToInt32(rulkdvs1.Text);
            rulmansip1.Text = rultp1.Text;
            partoptur = (ruls1 * rulad1) + (ruls2 * rulad2) + (ruls3 * rulad3) + (ruls4 * rulad4) + (ruls5 * rulad5) + (rulad6 * rulad6);
            parkdvtop = rulkdvss1 + rulkdvss2 + rulkdvss3 + rulkdvss4 + rulkdvss5 + rulkdvss6;
            geneltoplams = (partoptur + parkdvtop);
            parcageneltoplam.Text = geneltoplams.ToString();
            parcatoplamtutar.Text = partoptur.ToString();
            parcatoplamkdv.Text = parkdvtop.ToString();
        }

        private void rul2ad_SelectedIndexChanged(object sender, EventArgs e)
        {
            ruls2 = Convert.ToInt32(rul2fi.Text);
            rulad2 = Convert.ToInt32(rul2ad.Text);
            rultp2.Text = (ruls2 * rulad2).ToString();
            rulbl2 = Convert.ToInt32(rultp2.Text);
            kdv1 = 10;
            kdv2 = 100;
            rultp2.Text = (ruls2 * rulad2).ToString();
            rulbl2 = Convert.ToInt32(rultp2.Text);
            rulkdvs2.Text = (rulbl2 * kdv1 / kdv2).ToString();
            rulkdvss2 = Convert.ToInt32(rulkdvs2.Text);
            rulmansipkdv2.Text = rulkdvs2.Text;
            parctopla = rulad1 + rulad2 + rulad3 + rulad4 + rulad5 + rulad6;
            parctoplamad1.Text = parctopla.ToString();

            ruls2 = Convert.ToInt32(rul2fi.Text);
            rultp2.Text = (ruls2 * rulad2).ToString();
            rulbl2 = Convert.ToInt32(rultp2.Text);
            kdv1 = 10;
            kdv2 = 100;
            rultp2.Text = (ruls2 * rulad2).ToString();
            rulbl2 = Convert.ToInt32(rultp2.Text);
            rulkdvs2.Text = (rulbl2 * kdv1 / kdv2).ToString();
            rulkdvss2 = Convert.ToInt32(rulkdvs2.Text);
            rulmansip2.Text = rultp2.Text;

            partoptur = (ruls1 * rulad1) + (ruls2 * rulad2) + (ruls3 * rulad3) + (ruls4 * rulad4) + (ruls5 * rulad5) + (rulad6 * rulad6);
            parkdvtop = rulkdvss1 + rulkdvss2 + rulkdvss3 + rulkdvss4 + rulkdvss5 + rulkdvss6;
            geneltoplams = (partoptur + parkdvtop);
            parcageneltoplam.Text = geneltoplams.ToString();
            parcatoplamtutar.Text = partoptur.ToString();
            parcatoplamkdv.Text = parkdvtop.ToString();
        }
        private void rul3ad_SelectedIndexChanged(object sender, EventArgs e)
        {
            ruls3 = Convert.ToInt32(rul3fi.Text);
            rulad3 = Convert.ToInt32(rul3ad.Text);
            rultp3.Text = (ruls3 * rulad3).ToString();
            rulbl3 = Convert.ToInt32(rultp3.Text);
            kdv1 = 10;
            kdv2 = 100;
            rultp3.Text = (ruls3 * rulad3).ToString();
            rulbl3 = Convert.ToInt32(rultp3.Text);
            rulkdvs3.Text = (rulbl3 * kdv1 / kdv2).ToString();
            rulkdvss3 = Convert.ToInt32(rulkdvs3.Text);
            rulmansipkdv3.Text = rulkdvs3.Text;
            parctopla = rulad1 + rulad2 + rulad3 + rulad4 + rulad5 + rulad6;
            parctoplamad1.Text = parctopla.ToString();

            ruls3 = Convert.ToInt32(rul3fi.Text);
            rultp3.Text = (ruls3 * rulad3).ToString();
            rulbl3 = Convert.ToInt32(rultp3.Text);
            kdv1 = 10;
            kdv2 = 100;
            rultp3.Text = (ruls3 * rulad3).ToString();
            rulbl3 = Convert.ToInt32(rultp3.Text);
            rulkdvs3.Text = (rulbl3 * kdv1 / kdv2).ToString();
            rulkdvss3 = Convert.ToInt32(rulkdvs3.Text);
            rulmansip3.Text = rultp3.Text;

            partoptur = (ruls1 * rulad1) + (ruls2 * rulad2) + (ruls3 * rulad3) + (ruls4 * rulad4) + (ruls5 * rulad5) + (rulad6 * rulad6);
            parkdvtop = rulkdvss1 + rulkdvss2 + rulkdvss3 + rulkdvss4 + rulkdvss5 + rulkdvss6;
            geneltoplams = (partoptur + parkdvtop);
            parcageneltoplam.Text = geneltoplams.ToString();
            parcatoplamtutar.Text = partoptur.ToString();
            parcatoplamkdv.Text = parkdvtop.ToString();
        }

        private void rul4ad_SelectedIndexChanged(object sender, EventArgs e)
        {
            ruls4 = Convert.ToInt32(rul4fi.Text);
            rulad4 = Convert.ToInt32(rul4ad.Text);
            rultp4.Text = (ruls4 * rulad4).ToString();
            rulbl4 = Convert.ToInt32(rultp4.Text);
            kdv1 = 10;
            kdv2 = 100;
            rultp4.Text = (ruls4 * rulad4).ToString();
            rulbl4 = Convert.ToInt32(rultp4.Text);
            rulkdvs4.Text = (rulbl4 * kdv1 / kdv2).ToString();
            rulkdvss4 = Convert.ToInt32(rulkdvs4.Text);
            rulmansipkdv4.Text = rulkdvs4.Text;
            parctopla = rulad1 + rulad2 + rulad3 + rulad4 + rulad5 + rulad6;
            parctoplamad1.Text = parctopla.ToString();

            ruls4 = Convert.ToInt32(rul4fi.Text);
            rultp4.Text = (ruls4 * rulad4).ToString();
            rulbl4 = Convert.ToInt32(rultp4.Text);
            kdv1 = 10;
            kdv2 = 100;
            rultp4.Text = (ruls4 * rulad4).ToString();
            rulbl4 = Convert.ToInt32(rultp4.Text);
            rulkdvs4.Text = (rulbl4 * kdv1 / kdv2).ToString();
            rulkdvss4 = Convert.ToInt32(rulkdvs4.Text);
            rulmansip4.Text = rultp4.Text;

            partoptur = (ruls1 * rulad1) + (ruls2 * rulad2) + (ruls3 * rulad3) + (ruls4 * rulad4) + (ruls5 * rulad5) + (rulad6 * rulad6);
            parkdvtop = rulkdvss1 + rulkdvss2 + rulkdvss3 + rulkdvss4 + rulkdvss5 + rulkdvss6;
            geneltoplams = (partoptur + parkdvtop);
            parcageneltoplam.Text = geneltoplams.ToString();
            parcatoplamtutar.Text = partoptur.ToString();
            parcatoplamkdv.Text = parkdvtop.ToString();
        }

       
        private void rul5ad_SelectedIndexChanged(object sender, EventArgs e)
        {
            ruls5 = Convert.ToInt32(rul5fi.Text);
            rulad5 = Convert.ToInt32(rul5ad.Text);
            rultp5.Text = (ruls5 * rulad5).ToString();
            rulbl5 = Convert.ToInt32(rultp5.Text);
            kdv1 = 10;
            kdv2 = 100;
            rultp5.Text = (ruls5 * rulad5).ToString();
            rulbl5 = Convert.ToInt32(rultp5.Text);
            rulkdvs5.Text = (rulbl5 * kdv1 / kdv2).ToString();
            rulkdvss5 = Convert.ToInt32(rulkdvs5.Text);
            rulmansipkdv5.Text = rulkdvs5.Text;
            parctopla = rulad1 + rulad2 + rulad3 + rulad5 + rulad5 + rulad6;
            parctoplamad1.Text = parctopla.ToString();

            ruls5 = Convert.ToInt32(rul5fi.Text);
            rultp5.Text = (ruls5 * rulad5).ToString();
            rulbl5 = Convert.ToInt32(rultp5.Text);
            kdv1 = 10;
            kdv2 = 100;
            rultp5.Text = (ruls5 * rulad5).ToString();
            rulbl5 = Convert.ToInt32(rultp5.Text);
            rulkdvs5.Text = (rulbl5 * kdv1 / kdv2).ToString();
            rulkdvss5 = Convert.ToInt32(rulkdvs5.Text);
            rulmansip5.Text = rultp5.Text;

            partoptur = (ruls1 * rulad1) + (ruls2 * rulad2) + (ruls3 * rulad3) + (ruls4 * rulad4) + (ruls5 * rulad5) + (rulad6 * rulad6);
            parkdvtop = rulkdvss1 + rulkdvss2 + rulkdvss3 + rulkdvss4 + rulkdvss5 + rulkdvss6;
            geneltoplams = (partoptur + parkdvtop);
            parcageneltoplam.Text = geneltoplams.ToString();
            parcatoplamtutar.Text = partoptur.ToString();
            parcatoplamkdv.Text = parkdvtop.ToString();
        }

        private void rul6ad_SelectedIndexChanged(object sender, EventArgs e)
        {
            ruls6 = Convert.ToInt32(rul6fi.Text);
            rulad6 = Convert.ToInt32(rul6ad.Text);
            rultp6.Text = (ruls6 * rulad6).ToString();
            rulbl6 = Convert.ToInt32(rultp6.Text);
            kdv1 = 10;
            kdv2 = 100;
            rultp6.Text = (ruls6 * rulad6).ToString();
            rulbl6 = Convert.ToInt32(rultp6.Text);
            rulkdvs6.Text = (rulbl6 * kdv1 / kdv2).ToString();
            rulkdvss6 = Convert.ToInt32(rulkdvs6.Text);
            rulmansipkdv6.Text = rulkdvs6.Text;
            parctopla = rulad1 + rulad2 + rulad3 + rulad5 + rulad5 + rulad6;
            parctoplamad1.Text = parctopla.ToString();

            ruls6 = Convert.ToInt32(rul6fi.Text);
            rultp6.Text = (ruls6 * rulad6).ToString();
            rulbl6 = Convert.ToInt32(rultp6.Text);
            kdv1 = 10;
            kdv2 = 100;
            rultp6.Text = (ruls6 * rulad6).ToString();
            rulbl6 = Convert.ToInt32(rultp6.Text);
            rulkdvs6.Text = (rulbl6 * kdv1 / kdv2).ToString();
            rulkdvss6 = Convert.ToInt32(rulkdvs6.Text);
            rulmansip6.Text = rultp6.Text;

            partoptur = (ruls1 * rulad1) + (ruls2 * rulad2) + (ruls3 * rulad3) + (ruls4 * rulad4) + (ruls5 * rulad5) + (rulad6 * rulad6);
            parkdvtop = rulkdvss1 + rulkdvss2 + rulkdvss3 + rulkdvss4 + rulkdvss5 + rulkdvss6;
            geneltoplams = (partoptur + parkdvtop);
            parcageneltoplam.Text = geneltoplams.ToString();
            parcatoplamtutar.Text = partoptur.ToString();
            parcatoplamkdv.Text = parkdvtop.ToString();
        }
             

        private void button17_Click(object sender, EventArgs e)
        {
            rultp1.Text = "....";
            rulkdvs1.Text = "....";
        }

       

        private void button16_Click(object sender, EventArgs e)
        {
            firmadi.Text = "";
            firmatel.Text = "";
            siparistarihi.Text = "";
            sipyetkili.Text = "";
            sipno.Text = "";
            sipadres.Text = "";
        }

        int parctopla;
        

        private void button15_Click(object sender, EventArgs e)
        {
            
            baglanti.Open();
            SqlCommand VeriKaydet = new SqlCommand("insert into par(toplamtutar,parcaadet,firma,siparistarihi) values(@topla,@paradet,@firmad,@siptah)", baglanti);
            VeriKaydet.Parameters.AddWithValue("@siptah", siparistarihi.Text);
            VeriKaydet.Parameters.AddWithValue("@paradet", parctoplamad1.Text);
            VeriKaydet.Parameters.AddWithValue("@firmad", firmadi.Text);
            VeriKaydet.Parameters.AddWithValue("@topla", parcageneltoplam.Text);
            VeriKaydet.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Veri Eklendi");

            this.parTableAdapter.Fill(this.parcaDataSet.par);



        }

        private void button14_Click(object sender, EventArgs e)
        {
            lblfirmadi.Text = firmadi.Text;
            lblfirmatel.Text = firmatel.Text;
            lblsiptarih.Text = siparistarihi.Text;
            lblsipyetkili.Text= sipyetkili.Text;
            lblsipno.Text = sipno.Text;
            lblsipadres.Text = sipadres.Text;

        }

        private void toplayolla1_Click(object sender, EventArgs e)
        {
            partoptur = (ruls1 * rulad1) + (ruls2 * rulad2) + (ruls3 * rulad3) + (ruls4 * rulad4) + (ruls5 * rulad5) + (rulad6 * rulad6);
            parkdvtop = rulkdvss1 + rulkdvss2 + rulkdvss3 + rulkdvss4 + rulkdvss5 + rulkdvss6;
            geneltoplams = (partoptur + parkdvtop);
            parcageneltoplam.Text = geneltoplams.ToString();
            parcatoplamtutar.Text = partoptur.ToString();
            parcatoplamkdv.Text = parkdvtop.ToString();
        }


        private void rul2fi_SelectedIndexChanged(object sender, EventArgs e)
        {
            ruls2 = Convert.ToInt32(rul2fi.Text);
            rultp2.Text = (ruls2 * rulad2).ToString();
            rulbl2 = Convert.ToInt32(rultp2.Text);
            kdv1 = 10;
            kdv2 = 100;
            rultp2.Text = (ruls2 * rulad2).ToString();
            rulbl2 = Convert.ToInt32(rultp2.Text);
            rulkdvs2.Text = (rulbl2 * kdv1 / kdv2).ToString();
            rulkdvss2 = Convert.ToInt32(rulkdvs2.Text);
            rulmansipkdv2.Text = rulkdvs2.Text;

            ruls2 = Convert.ToInt32(rul2fi.Text);
            rultp2.Text = (ruls2 * rulad2).ToString();
            rulbl2 = Convert.ToInt32(rultp2.Text);
            kdv1 = 10;
            kdv2 = 100;
            rultp2.Text = (ruls2 * rulad2).ToString();
            rulbl2 = Convert.ToInt32(rultp2.Text);
            rulkdvs2.Text = (rulbl2 * kdv1 / kdv2).ToString();
            rulkdvss2 = Convert.ToInt32(rulkdvs2.Text);
            rulmansip2.Text = rultp2.Text;
            partoptur = (ruls1 * rulad1) + (ruls2 * rulad2) + (ruls3 * rulad3) + (ruls4 * rulad4) + (ruls5 * rulad5) + (rulad6 * rulad6);
            parkdvtop = rulkdvss1 + rulkdvss2 + rulkdvss3 + rulkdvss4 + rulkdvss5 + rulkdvss6;
            geneltoplams = (partoptur + parkdvtop);
            parcageneltoplam.Text = geneltoplams.ToString();
            parcatoplamtutar.Text = partoptur.ToString();
            parcatoplamkdv.Text = parkdvtop.ToString();
        }       

        private void rul1fi_SelectedIndexChanged(object sender, EventArgs e)
        {

            ruls1 = Convert.ToInt32(rul1fi.Text);            
            rultp1.Text = (ruls1 * rulad1).ToString();
            rulbl1 = Convert.ToInt32(rultp1.Text);
            kdv1 = 10;
            kdv2 = 100;
            rultp1.Text = (ruls1 * rulad1).ToString();
            rulbl1 = Convert.ToInt32(rultp1.Text);
            rulkdvs1.Text = (rulbl1 * kdv1 / kdv2).ToString();
            rulkdvss1 = Convert.ToInt32(rulkdvs1.Text);
            rulmansipkdv1.Text = rulkdvs1.Text;

            ruls1 = Convert.ToInt32(rul1fi.Text);            
            rultp1.Text = (ruls1 * rulad1).ToString();
            rulbl1 = Convert.ToInt32(rultp1.Text);            
            kdv1 = 10;
            kdv2 = 100;
            rultp1.Text = (ruls1 * rulad1).ToString();
            rulbl1 = Convert.ToInt32(rultp1.Text);
            rulkdvs1.Text = (rulbl1 * kdv1 / kdv2).ToString();
            rulkdvss1 = Convert.ToInt32(rulkdvs1.Text);
            rulmansip1.Text = rultp1.Text;
            partoptur = (ruls1 * rulad1) + (ruls2 * rulad2) + (ruls3 * rulad3) + (ruls4 * rulad4) + (ruls5 * rulad5) + (rulad6 * rulad6);
            parkdvtop = rulkdvss1 + rulkdvss2 + rulkdvss3 + rulkdvss4 + rulkdvss5 + rulkdvss6;
            geneltoplams = (partoptur + parkdvtop);
            parcageneltoplam.Text = geneltoplams.ToString();
            parcatoplamtutar.Text = partoptur.ToString();
            parcatoplamkdv.Text = parkdvtop.ToString();


        }

       


        private void label20_Click(object sender, EventArgs e)
        {
            kdvtoplam = rulkdvss1 + rulkdvss2 + rulkdvss3 + rulkdvss4 + rulkdvss5 + rulkdvss6;
            rulkdvtoplam.Text = kdvtoplam.ToString();
        
        }


        private void rulkdv6_Click(object sender, EventArgs e)
        {
            kdv1 = 10;
            kdv2 = 100;
            rultp6.Text = (ruls6 * rulad6).ToString();
            rulbl6 = Convert.ToInt32(rultp6.Text);
            rulkdvs6.Text = (rulbl6 * kdv1 / kdv2).ToString();
            rulkdvss6 = Convert.ToInt32(rulkdvs6.Text);

        }

        private void rulkdv5_Click(object sender, EventArgs e)
        {
            kdv1 = 10;
            kdv2 = 100;
            rultp5.Text = (ruls5 * rulad5).ToString();
            rulbl5 = Convert.ToInt32(rultp5.Text);
            rulkdvs5.Text = (rulbl5 * kdv1 / kdv2).ToString();
            rulkdvss5 = Convert.ToInt32(rulkdvs5.Text);
        }

        


        private void rulkdv4_Click(object sender, EventArgs e)
        {
            kdv1 = 10;
            kdv2 = 100;
            rultp4.Text = (ruls4 * rulad4).ToString();
            rulbl4 = Convert.ToInt32(rultp4.Text);
            rulkdvs4.Text = (rulbl4 * kdv1 / kdv2).ToString();
            rulkdvss4 = Convert.ToInt32(rulkdvs4.Text);
        }

        

        private void rulkdv3_Click(object sender, EventArgs e)
        {
            kdv1 = 10;
            kdv2 = 100;
            rultp3.Text = (ruls3 * rulad3).ToString();
            rulbl3 = Convert.ToInt32(rultp3.Text);
            rulkdvs3.Text = (rulbl3 * kdv1 / kdv2).ToString();
            rulkdvss3 = Convert.ToInt32(rulkdvs3.Text);
        }       

        private void rulkdv2_Click(object sender, EventArgs e)
        {
            kdv1 = 10;
            kdv2 = 100;
            rultp2.Text = (ruls2 * rulad2).ToString();
            rulbl2 = Convert.ToInt32(rultp2.Text);
            rulkdvs2.Text = (rulbl2 * kdv1 / kdv2).ToString();
            rulkdvss2 = Convert.ToInt32(rulkdvs2.Text);
        }

        



        private void rulkdv1_Click(object sender, EventArgs e)
        {
            kdv1 = 10;
            kdv2 = 100;
            rultp1.Text = (ruls1 * rulad1).ToString();
            rulbl1 = Convert.ToInt32(rultp1.Text);
            rulkdvs1.Text = (rulbl1 * kdv1 / kdv2).ToString();
            rulkdvss1 = Convert.ToInt32(rulkdvs1.Text);

        }     
        
        
        private void rulbt6_Click(object sender, EventArgs e)
        {
           
            ruls6 = Convert.ToInt32(rul6fi.Text);
            rulad6 = Convert.ToInt32(rul6ad.Text);
            rultp6.Text = (ruls6 * rulad6).ToString();
            rulbl6 = Convert.ToInt32(rultp6.Text);
        }

        private void rulbt5_Click(object sender, EventArgs e)
        {
            
            ruls5 = Convert.ToInt32(rul5fi.Text);
            rulad5 = Convert.ToInt32(rul5ad.Text);
            rultp5.Text = (ruls5 * rulad5).ToString();
            rulbl5 = Convert.ToInt32(rultp5.Text);
        }

        
        private void rulbt4_Click(object sender, EventArgs e)
        {
           
            ruls4 = Convert.ToInt32(rul4fi.Text);
            rulad4 = Convert.ToInt32(rul4ad.Text);
            rultp4.Text = (ruls4 * rulad4).ToString();
            rulbl4 = Convert.ToInt32(rultp4.Text);
        }

        

        private void rulbt3_Click(object sender, EventArgs e)
        {
            
            ruls3 = Convert.ToInt32(rul3fi.Text);
            rulad3 = Convert.ToInt32(rul3ad.Text);
            rultp3.Text = (ruls3 * rulad3).ToString();
            rulbl3 = Convert.ToInt32(rultp3.Text);
        }

        
        private void rulbt2_Click(object sender, EventArgs e)
        {
            
            ruls2 = Convert.ToInt32(rul2fi.Text);
            rulad2 = Convert.ToInt32(rul2ad.Text);
            rultp2.Text = (ruls2 * rulad2).ToString();
            rulbl2 = Convert.ToInt32(rultp2.Text);
        }

        
        private void rulbt1_Click(object sender, EventArgs e)
        {
           
            ruls1 = Convert.ToInt32(rul1fi.Text);
            rulad1 = Convert.ToInt32(rul1ad.Text);
            rultp1.Text = (ruls1 * rulad1).ToString();
            rulbl1 = Convert.ToInt32(rultp1.Text);
        }
    }
}
