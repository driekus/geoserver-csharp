using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GeoserverClient;
using GeoserverClient.Model;

namespace GeoserverClientWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GeoserverRestClient.GetAdressen(tbPostcode.Text,Int32.Parse(tbHuisnummer.Text), callback);
            tbResult.Text = "Even geduld...";
        }

        private void callback(List<Adres> adressen)
        {

            var text=adressen!=null?"Aantal adressen:" + adressen.Count.ToString(): "niks gevonden helaas.";
            tbResult.Invoke(new MethodInvoker(delegate { tbResult.Text=text; })); 
        }
    }
}
