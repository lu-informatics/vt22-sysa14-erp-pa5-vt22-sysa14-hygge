using HyggeService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

            ArrayOfXElement ds;

            switch (cb.Text)
            {
                case "all tables in the database 1":
                    ds = proxy.Table();
                    break;
            }
            ds = proxy.Table();
            dataGridView1.DataSource = ToDataSet(ds).Tables[0];
    }
        public DataSet ToDataSet(ArrayOfXElement arrayOfXElement)
      
            {
            Console.WriteLine(arrayOfXElement);
            Console.WriteLine(arrayOfXElement.Nodes[0]);
                var strSchema = arrayOfXElement.Nodes[0].ToString();
                var strData = arrayOfXElement.Nodes[1].ToString();
                var strXml = "<?xml version=\"1.0\" encoding=\"utf-8\" ?>\n\t<DataSet>";
                strXml += strSchema + strData;
                strXml += "</DataSet>";

                DataSet ds = new DataSet("TestDataSet");
                ds.ReadXml(new MemoryStream(Encoding.UTF8.GetBytes(strXml)));

                return ds;
            }
        }
    }



