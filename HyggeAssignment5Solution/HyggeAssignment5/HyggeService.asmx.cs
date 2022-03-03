using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using static HyggeAssignment5.DataAccessLayer;


namespace HyggeAssignment5
{
    /// <summary>
    /// Summary description for HyggeService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]


    public class HyggeService : System.Web.Services.WebService
    {

        private DataAccessLayer dal = new DataAccessLayer();
        private List<Table> tables = new List<Table>();

        [WebMethod]
        public DataSet ViewAll(string table)


        {
            switch (table)
            {
                case "Login":
                    return DataAccessLayer.Utils.ViewAll(Table.Logins);


                case "Person":
                    return DataAccessLayer.Utils.ViewAll(Table.Person);



                case "Relationship":
                    return DataAccessLayer.Utils.ViewAll(Table.Relationship);


                case "Interest":
                    return DataAccessLayer.Utils.ViewAll(Table.Interest);


                case "Industry":
                    return DataAccessLayer.Utils.ViewAll(Table.Industry);


                case "Education":
                    return DataAccessLayer.Utils.ViewAll(Table.Education);

                case "EducationIndustry":
                    return DataAccessLayer.Utils.ViewAll(Table.EducationIndustry);


            }
            throw new Exception("The table was not found in the database!"); 

        }




        [WebMethod]
        public List<object[]> GetTableAsList(string tableName) //C# can handle DataSet, but it's not optimal for Java. List of object[] and fill it with values generated from DataSet. 
                                                                                            

        {
            List<object[]> list = new List<object[]>();
            DataSet dataSet = GetDataSet(tableName);    



            DataTable dataTable = dataSet.Tables[0]; //a datatable represents a single table in the database.  
            foreach (DataRow row in dataTable.Rows) //Foreach row in the chosen tables row, we set the row to an array, and add the array to the list and return the list. 
            {
                var array = row.ItemArray;
                list.Add(array);
            }
            return list; //when we make calls in Java, we will recieve the list of object[] representing our tables in the database. 

        }

        [WebMethod]
        public DataSet GetDataTableAsDataSet(string tableName) //C# can handle DataSet, but it's not optimal for Java. List of object[] and fill it with values generated from DataSet. 


        {

            return GetDataSet(tableName);
        }

        public DataSet GetDataSet(String tableName)
        {

            DataSet dataSet = new DataSet(); 

            switch (tableName)
            {
                case "See Metadata for the Employee Tables and Related Tables (one)":
                    dataSet = DataAccessLayer.EmployeeMetaDataContentsOne();
                    break;

                case "See Metadata for the Employee Tables and Related Tables (two)":
                    dataSet = DataAccessLayer.EmployeeMetaDataContentsTwo();
                    break;

                case "See Metadata for the Employee Tables and Related Tables (three)":
                    dataSet = DataAccessLayer.EmployeeMetaDataContentsThree();
                    break;

                case "See Metadata for the Employee Tables and Related Tables (four)":
                    dataSet = DataAccessLayer.EmployeeMetaDataContentsFour();
                    break;

                case "See Metadata for the Employee Tables and Related Tables (five)":
                    dataSet = DataAccessLayer.EmployeeMetaDataContentsFive();
                    break;

                case "See Metadata for the Employee Tables and Related Tables (six)":
                    dataSet = DataAccessLayer.EmployeeMetaDataContentsSix();
                    break;

                case "See Metadata for the Employee Tables and Related Tables (seven)":
                    dataSet = DataAccessLayer.EmployeeMetaDataContentsSeven();
                    break;

                case "See Metadata for the Employee Tables and Related Tables (eight)":
                    dataSet = DataAccessLayer.EmployeeMetaDataContentsEight();
                    break;

                case "See Metadata for the Employee Tables and Related Tables (nine)":
                    dataSet = DataAccessLayer.EmployeeMetaDataContentsNine();
                    break;

                case "See Metadata for the Employee Tables and Related Tables (ten)":
                    dataSet = DataAccessLayer.EmployeeMetaDataContentsTen();
                    break;


                case "See Information about Employees and their Relatives":
                    dataSet = DataAccessLayer.EmployeesRelatives();
                    break;

                case "See Information about the Employees that have been absent due to Sickness in the Year of 2004":
                    dataSet = DataAccessLayer.EmployeesSick2004();
                    break;

                case "See First Name of the Employee that has been Absent the most":
                    dataSet = DataAccessLayer.EmployeeMostAbsent();
                    break;

                case "See all Keys":
                    dataSet = DataAccessLayer.AllKeys();
                    break;

                case "See all Indexes":
                    dataSet = DataAccessLayer.AllIndexes();
                    break;

                case "See all Table_Constraints":
                    dataSet = DataAccessLayer.AllTableConstraints();
                    break;

                case "See all Tables in the Database Solution One":
                    dataSet = DataAccessLayer.AllTablesInDBOne();
                    break;

                case "See all Tables in the Database Solution Two":
                    dataSet = DataAccessLayer.AllTablesInDBTwo();
                    break;

                case "See all Columns of the Employee Table Solution One":
                    dataSet = DataAccessLayer.AllColumnsEmployeeOne();
                    break;

                case "See all Columns of the Employee Table Solution Two":
                    dataSet = DataAccessLayer.AllColumnsEmployeeTwo();
                    break;


            }

            return dataSet;
        }
    }





}




