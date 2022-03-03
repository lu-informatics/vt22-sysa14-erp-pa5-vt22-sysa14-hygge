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
            DataSet dataSet = new DataSet();



            switch (tableName)
            {
                case "Person":
                    dataSet = DataAccessLayer.Utils.ViewAll(Table.Person);
                    break;
                case "Relationship":
                    dataSet = DataAccessLayer.Utils.ViewAll(Table.Relationship);
                    break;
                case "Education":
                    dataSet = DataAccessLayer.Utils.ViewAll(Table.Education);
                    break;
                case "Industry":
                    dataSet = DataAccessLayer.Utils.ViewAll(Table.Industry);
                    break;
                case "Interest":
                    dataSet = DataAccessLayer.Utils.ViewAll(Table.Interest);
                    break;
                case "Login":
                    dataSet = DataAccessLayer.Utils.ViewAll(Table.Logins);
                    break;
                case "EducationIndustry":
                    dataSet = DataAccessLayer.Utils.ViewAll(Table.EducationIndustry);
                    break;


            }


            DataTable dataTable = dataSet.Tables[0]; //a datatable represents a single table in the database.  
            foreach (DataRow row in dataTable.Rows) //Foreach row in the chosen tables row, we set the row to an array, and add the array to the list and return the list. 
            {
                var array = row.ItemArray;
                list.Add(array);
            }
            return list; //when we make calls in Java, we will recieve the list of object[] representing our tables in the database. 

        }
    }
}

//[WebMethod] 

//        public DataSet Query1(string Table){

//            switch(table)
//            {
//                case "Employee Relatives":
//            return DataAccessLayer.EmployeesRelatives(table);
//                case "Employee Sick 2004":
//                    return DataAccessLayer.EmployeesSick2004();
//                case "Query":
//            return  DataAccessLayer.EmployeeMostAbsent();
//                case "All Tables Constrains":
//            return DataAccessLayer.AllTableConstraints();


//            }
//        public DataSet Query2()
//        {

//            return DataAccessLayer.EmployeesSick2004();

//        }

//        public DataSet Query3()
//        {
//            return DataAccessLayer.EmployeeMostAbsent();
//        }

//}
//}





