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

            comboBoxValue.Items.Add("See Information about Employees and their Relatives");
            comboBoxValue.Items.Add("See Information about the Employees that have been Absent due to Sickness in the Year of 2004");
            comboBoxValue.Items.Add("See first Name of the Employee that has been Absent the most");
            comboBoxValue.Items.Add("See all Keys");
            comboBoxValue.Items.Add("See all Indexes");
            comboBoxValue.Items.Add("See all table_constraints");
            comboBoxValue.Items.Add("See all Tables in the Database Solution One");
            comboBoxValue.Items.Add("See all Tables in the Database Solution Two");
            comboBoxValue.Items.Add("See all Columns of the Employee Table Solution One");
            comboBoxValue.Items.Add("See all Columns of the Employee Table Solution Two");
        }

        private void comboBoxValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            

          
            ArrayOfXElement ds;
            Console.WriteLine(cb.SelectedItem.ToString());
            switch (cb.SelectedItem.ToString())
            {
                case "all tables in the database 1":
                    ds = proxy.Table();
                    break;
                default: ds = proxy.Table();
                    break;
            }
            
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



