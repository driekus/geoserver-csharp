using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GeoserverClient;

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
            var url = "http://www.opengeocoder.net/API/autocomplete?term=Utrecht";
            new GeoserverRestClient().GetAsyncResponse(url);


            // todo: new GeoserverRestClient().ExecuteAsync(url, callback(response.data));
        }

        private void callback(List<String> strings)
        {
            
        }
    }
}
