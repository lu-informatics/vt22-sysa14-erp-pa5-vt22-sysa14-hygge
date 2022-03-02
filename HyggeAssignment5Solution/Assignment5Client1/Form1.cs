using HyggeService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5Client1
{
    public partial class Form1 : Form
    {
        static HyggeServiceSoapClient.EndpointConfiguration config = HyggeServiceSoapClient.EndpointConfiguration.HyggeServiceSoap;
        HyggeServiceSoapClient proxy = new HyggeServiceSoapClient(config);
        public Form1()
        {
            InitializeComponent();
        }

    }
}
