using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeoserverClient;

namespace GeoServerClientConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var bagclient = new BagClient();
            bagclient.GetGebouw();
        }
    }
}

