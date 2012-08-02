using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GeoserverClient;
using GeoserverClient.Model;

namespace GeoserverClientWindowsForms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rdbAdres.Checked)
            {
                GeoserverAgn.GetAdressen(tbPostcode.Text, Int32.Parse(tbHuisnummer.Text), callback, tbToevoeging.Text);
            }
            else
            {
                GeoserverAgn.GetGebouwen(tbPostcode.Text, Int32.Parse(tbHuisnummer.Text), callback, tbToevoeging.Text);
            }
            tbResult.Text = "Even geduld...";
        }

        private void callback(List<Adres> adressen)
        {

            var text=adressen!=null?"Aantal adressen:" + adressen.Count.ToString(): "niks gevonden helaas.";
            tbResult.Invoke(new MethodInvoker(delegate { tbResult.Text=text; })); 
        }

        private void callback(List<Gebouw> gebouwen)
        {
            var text = gebouwen != null ? "Aantal gebouwen:" + gebouwen.Count.ToString() : "niks gevonden helaas.";
            tbResult.Invoke(new MethodInvoker(delegate { tbResult.Text = text; }));
        }
    }
}
