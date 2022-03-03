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
        //static hyggeservicesoapclient.endpointconfiguration config = hyggeservicesoapclient.endpointconfiguration.hyggeservicesoap;
        //hyggeservicesoapclient proxy = new hyggeservicesoapclient(config);
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

            //case "See Metadata for the Employee Tables and Related Tables":
            //    return null;

            //comboBox.addItem("See Information about Employees and their Relatives");
            //comboBox.addItem("See Information about the Employees that have been Absent due to Sickness in the Year of 2004");
            //comboBox.addItem("See first Name of the Employee that has been Absent the most");
            //comboBox.addItem("See all Keys");
            //comboBox.addItem("See all Indexes");
            //comboBox.addItem("See all table_constraints");
            //comboBox.addItem("See all Tables in the Database Solution One");
            //comboBox.addItem("See all Tables in the Database Solution Two");
            //comboBox.addItem("See all Columns of the Employee Table Solution One");
            //comboBox.addItem("See all Columns of the Employee Table Solution Two");

    //        ArrayOfXElement ds;
    //        Console.WriteLine(cb.SelectedItem.ToString());
    //        switch (cb.SelectedItem.ToString())
    //        {
    //            case "all tables in the database 1":
    //                ds = proxy.Table();
    //                break;
    //            default: ds = proxy.Table();
    //                break;
    //        }
            
    //        dataGridView1.DataSource = ToDataSet(ds).Tables[0];
    //}
        //public DataSet ToDataSet(ArrayOfXElement arrayOfXElement)
      
        //    {
        //    Console.WriteLine(arrayOfXElement);
        //    Console.WriteLine(arrayOfXElement.Nodes[0]);
        //        var strSchema = arrayOfXElement.Nodes[0].ToString();
        //        var strData = arrayOfXElement.Nodes[1].ToString();
        //        var strXml = "<?xml version=\"1.0\" encoding=\"utf-8\" ?>\n\t<DataSet>";
        //        strXml += strSchema + strData;
        //        strXml += "</DataSet>";

        //        DataSet ds = new DataSet("TestDataSet");
        //        ds.ReadXml(new MemoryStream(Encoding.UTF8.GetBytes(strXml)));

        //        return ds;
        //    }

         void button1_Click(object sender, EventArgs e) // chronological order between button number and DAL query
        {
            dataGridView1.DataSource = proxy.Query1().Tables[0];
        }
        }
    }
}








