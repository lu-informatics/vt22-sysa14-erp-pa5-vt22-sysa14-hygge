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
    public partial class Form1 : Form 
    {
        static HyggeServiceSoapClient.EndpointConfiguration config = HyggeServiceSoapClient.EndpointConfiguration.HyggeServiceSoap;
        HyggeServiceSoapClient proxy = new HyggeServiceSoapClient(config);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            comboBoxValue.Items.Add("See Metadata for the Employee Tables and Related Tables (one)");
            comboBoxValue.Items.Add("See Metadata for the Employee Tables and Related Tables (two)");
            comboBoxValue.Items.Add("See Metadata for the Employee Tables and Related Tables (three)");
            comboBoxValue.Items.Add("See Metadata for the Employee Tables and Related Tables (four)");
            comboBoxValue.Items.Add("See Metadata for the Employee Tables and Related Tables (five)");
            comboBoxValue.Items.Add("See Metadata for the Employee Tables and Related Tables (six)");
            comboBoxValue.Items.Add("See Metadata for the Employee Tables and Related Tables (seven)");
            comboBoxValue.Items.Add("See Metadata for the Employee Tables and Related Tables (eight)");
            comboBoxValue.Items.Add("See Metadata for the Employee Tables and Related Tables (nine)");
            comboBoxValue.Items.Add("See Metadata for the Employee Tables and Related Tables (ten)");
            comboBoxValue.Items.Add("See Information about Employees and their Relatives");
            comboBoxValue.Items.Add("See Information about the Employees that have been absent due to Sickness in the Year of 2004");
            comboBoxValue.Items.Add("See First Name of the Employee that has been Absent the most");
            comboBoxValue.Items.Add("See all Keys");
            comboBoxValue.Items.Add("See all Indexes");
            comboBoxValue.Items.Add("See all Table_Constraints");
            comboBoxValue.Items.Add("See all Tables in the Database Solution One");
            comboBoxValue.Items.Add("See all Tables in the Database Solution Two");
            comboBoxValue.Items.Add("See all Columns of the Employee Table Solution One");
            comboBoxValue.Items.Add("See all Columns of the Employee Table Solution Two");
            



        }

        private void comboBoxValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;



            ArrayOfXElement ds;
             
            ds = proxy.GetDataTableAsDataSet(cb.SelectedItem.ToString());
            
       
           
            dataGridView1.DataSource = ToDataSet(ds).Tables[0];
    }
        public DataSet ToDataSet(ArrayOfXElement arrayOfXElement) //convert ArrayOfXElement
      
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



