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
    public partial class Form1 : Form //Döpa om
    {
        static HyggeServiceSoapClient.EndpointConfiguration config = HyggeServiceSoapClient.EndpointConfiguration.HyggeServiceSoap;
        HyggeServiceSoapClient proxy = new HyggeServiceSoapClient(config);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxValue.Items.Add("All tables in the database 1");
        }

        private void comboBoxValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;

            ArrayOfXElement ds = null;

            switch (cb.Text)
            {
                case "All tables in the database 1":
                    ds = proxy.Table("All tables in the database 1");
                    break;
            }
            dataGridView1.DataSource = ToDataSet
    }
        public DataSet ToDataSet(ArrayOfXElement arrayOfXElement)
        {

        }
}
}
