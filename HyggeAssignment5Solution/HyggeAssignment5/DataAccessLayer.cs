using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace HyggeAssignment5
{
    public class DataAccessLayer
    {
        public static DataSet SendToDatabase(string sqlQuery){
        
            {
                using (SqlConnection cnn = new SqlConnection("Data Source = SYSA12; Initial Catalog = Cronos; User ID=hygge; Password = hej123;")) 
                {
                    
                    string queryString = "SELECT * FROM [CRONUS Sverige AB$Employee]";

                    {
                        SqlCommand command = new SqlCommand(queryString, cnn);
                        cnn.Open();
                        using(SqlDataReader reader = command.ExecuteReader()){
                            while(reader.Read()){
                                Console.WriteLine(reader.GetString(0));


                    }

                //    void SendTable()
                //{
                //    string response = "";
                //    while (response != null)
                //    {
                //        response = Console.ReadLine();
                //        switch(response)
                //        {
                //            case "Contents and metadata for the Employee tables and related tables";
                //                            string queryString = "";
                //            break;
                //            case "Information about Employees and their relatives";
                //                            string queryString1 = "SELECT ER.[First Name], ER.[Last Name], ER.[Birth Date], E.[First Name] , E.[Last Name], E.[Job Title]FROM [CRONUS Sverige AB$Employee] E JOIN[CRONUS Sverige AB$Employee Relative] ER ON ER.[Employee No_] = E.No_;
                //             break;
                //            case "Information about Employees that have been absent due to sickness in the year of 2004";
                //            //
                //             break;
                //            case "First name of employee that has been absent the most";
                //                //
                //                break;
                //            case "ALL KEYS";
                //                //
                //                break;
                //            case "ALL INDEXES";
                //                //
                //                break;

                //            case "ALL TABLE_CONSTRAINTS";
                //                //
                //                break;
                //            case "ALL TABLES IN THE DATABASE 1";
                //                //
                //                break;
                //            case "ALL TABLES IN THE DATABASE 2";
                //                //
                //                break;
                //            case "ALL COLUMNS OF THE EMPLOYEE TABLE 1";
                //                //
                //                break;
                //            case "ALL COLUMNS OF THE EMPLOYEE TABLE 2";
                //                //
                //                break;


                //        }
            }
}
}
}
