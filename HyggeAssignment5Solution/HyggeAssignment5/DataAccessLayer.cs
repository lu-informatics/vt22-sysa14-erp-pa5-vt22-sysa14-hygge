using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace HyggeAssignment5
{
    public class DataAccessLayer


    { //TODO error handling
        public static string Test()
        { //this method should only be used to test out new features of the db. it does not test the functionality of the whole class.   
            try
            {
                DataSet ds = Login.ReadLogin("anabanana@hotmail.com");
                return ds.Tables[0].Rows[0][0].ToString(); // returns the value of the first column of the first row in string format
            }
            catch (SqlException) { return ("failed to connect."); } // returns a simple error message if the client couldn't connect to the db server (check the data source!)
        }
        public enum Table
        { // Enumeration of allowed Tables
            Logins,
            Person,
            Relationship,
            Interest,
            Industry,
            Education,
            EducationIndustry
        }


        public static DataSet EmployeeMetaDataContentsOne() => SendToDatabase("SELECT [No_], [First Name], [Last Name], [Job Title], [E-Mail] FROM [CRONUS Sverige AB$Employee]"); 
        public static DataSet EmployeeMetaDataContentsTwo() => SendToDatabase("SELECT[Employee No_], [Cause of Absence Code], [From Date]FROM[CRONUS Sverige AB$Employee Absence]");
        public static DataSet EmployeeMetaDataContentsThree() => SendToDatabase("SELECT[Employee No_], [Qualification Code], [Description] FROM [CRONUS Sverige AB$Employee Qualification]");
        public static DataSet EmployeeMetaDataContentsFour() => SendToDatabase("SELECT [Employee No_], [Line No_], [Relative Code] FROM[CRONUS Sverige AB$Employee Relative]");
        public static DataSet EmployeeMetaDataContentsFive() => SendToDatabase("SELECT[Code], [Description] FROM[CRONUS Sverige AB$Employee Statistics Group]");
        public static DataSet EmployeeMetaDataContentsSix() => SendToDatabase("SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'CRONUS Sverige AB$Employee'");
        public static DataSet EmployeeMetaDataContentsSeven() => SendToDatabase("SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'CRONUS Sverige AB$Employee Absence'");
        public static DataSet EmployeeMetaDataContentsEight() => SendToDatabase("SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'CRONUS Sverige AB$Employee Qualification'");
        public static DataSet EmployeeMetaDataContentsNine() => SendToDatabase("SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'CRONUS Sverige AB$Employee Relative'");
        public static DataSet EmployeeMetaDataContentsTen() => SendToDatabase("SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'CRONUS Sverige AB$Employee Statistics Group'");



        public static DataSet EmployeesRelatives() => SendToDatabase("SELECT ER.[First Name], ER.[Last Name], ER.[Birth Date], E.[First Name] , E.[Last Name], E.[Job Title], ER.[Relative Code] FROM[CRONUS Sverige AB$Employee] E JOIN[CRONUS Sverige AB$Employee Relative] ER ON ER.[Employee No_] = E.No_");
        public static DataSet EmployeesSick2004() => SendToDatabase("SELECT EA.Description, EA.[From Date], E.[First Name] , E.[Last Name], E.[Job Title] FROM [CRONUS Sverige AB$Employee] E JOIN [CRONUS Sverige AB$Employee Absence] EA ON EA.[Employee No_] = E.No_ WHERE EA.[From Date] BETWEEN CONVERT (datetime, '2004-01-01')AND CONVERT(datetime, '2004-12-31') AND Description = 'Sjuk'");
        public static DataSet EmployeeMostAbsent() => SendToDatabase("SELECT e.[First Name] FROM [CRONUS Sverige AB$Employee] e JOIN (SELECT TOP 1 SUM([Quantity (Base)]) AS Quantity, [Employee No_] FROM [CRONUS Sverige AB$Employee Absence] EA GROUP BY [Employee No_] ORDER BY Quantity DESC) q ON q.[Employee No_] = e.No_");
        public static DataSet AllKeys() => SendToDatabase("SELECT CONSTRAINT_TYPE, CONSTRAINT_NAME FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS WHERE CONSTRAINT_TYPE = 'PRIMARY KEY'");
        public static DataSet AllIndexes() => SendToDatabase("SELECT name, type_desc FROM sys.indexes WHERE name IS NOT NULL");
        public static DataSet AllTableConstraints() => SendToDatabase("SELECT CONSTRAINT_TYPE, CONSTRAINT_NAME FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS");
        public static DataSet AllTablesInDBOne() => SendToDatabase("SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE'");
        public static DataSet AllTablesInDBTwo() => SendToDatabase("SELECT name AS 'BASE TABLE'FROM sys.tables");
        public static DataSet AllColumnsEmployeeOne() => SendToDatabase("SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'CRONUS Sverige AB$Employee' GROUP BY COLUMN_NAME");
        public static DataSet AllColumnsEmployeeTwo() => SendToDatabase("SELECT name FROM sys.all_columns WHERE object_id = OBJECT_ID('[CRONUS Sverige AB$Employee]')");




        public static class Utils
        {
            // These methods partially define the SQL query, leaving parameter fill for the SendToDatabes method.
            // IMPORTANT: These methods requires ParamIDs to match parameter names in the database.

            public static DataSet ViewAll(Table table) => SendToDatabase($"SELECT * FROM {table}");


            //CREATE TEMPLATE
            public static void Create(Table table, ParamArgs value1, ParamArgs value2)
            => SendToDatabase($"INSERT INTO {table}({value1.ParamID.Substring(1)},{value2.ParamID.Substring(1)}) VALUES ({value1.ParamID},{value2.ParamID})", value1, value2);
            //UPDATE TEMPLATE
            public static void Update(Table table, ParamArgs primaryKey, ParamArgs changedValue)
                => SendToDatabase($"UPDATE {table} SET {changedValue.ParamID.Substring(1)} = {changedValue.ParamID} WHERE {primaryKey.ParamID.Substring(1)} = {primaryKey.ParamID}",
                    changedValue,
                    primaryKey);
            //READ TEMPLATE
            public static DataSet Read(Table table, ParamArgs primaryKey)
                => SendToDatabase($"SELECT * FROM {table} WHERE {primaryKey.ParamID.Substring(1)} = {primaryKey.ParamID}", primaryKey);
            //DELETE TEMPLATE
            public static void Delete(Table table, ParamArgs primaryKey)
                => SendToDatabase($"DELETE {table} WHERE {primaryKey.ParamID.Substring(1)} = {primaryKey.ParamID}", primaryKey);
        }

        public static class Login
        {
            //Create
            public static void CreateLogin(string email, string password) => Utils.Create(Table.Logins, new ParamArgs("@email", email), new ParamArgs("@pword", password));
            //Update
            public static void UpdateLogin(string email, string newPassword) => Utils.Update(Table.Logins, new ParamArgs("@email", email), new ParamArgs("@pword", newPassword));
            //Read
            public static DataSet ReadLogin(string email) => Utils.Read(Table.Logins, new ParamArgs("@email", email));
            //Delete
            public static void DeleteLogin(string email) => Utils.Delete(Table.Logins, new ParamArgs("@email", email));
        }

        public static class Industry
        {
            //Create
            public static void CreateIndustry(string industryName, string field) => Utils.Create(Table.Industry, new ParamArgs("@industryName", industryName), new ParamArgs("@field", field));
            //Update 
            public static void UpdateIndustry(string industryName, string newfield) => Utils.Update(Table.Industry, new ParamArgs("@industryName", industryName), new ParamArgs("@field", newfield));
            //Read
            public static DataSet ReadIndustry(string industryName) => Utils.Read(Table.Industry, new ParamArgs("@industryName", industryName));
            //Delete
            public static void DeleteIndustry(string industryName) => Utils.Delete(Table.Industry, new ParamArgs("@industryName", industryName));
        }

        public static class Education
        {
            //Create
            public static void CreateEducation(string educationName, string locale) => Utils.Create(Table.Education, new ParamArgs("@educationName", educationName), new ParamArgs("@locale", locale));
            //Update
            public static void UpdateEducation(string educationName, string newLocale) => Utils.Update(Table.Education, new ParamArgs("@educationName", educationName), new ParamArgs("@locale", newLocale));
            //Read
            public static DataSet ReadEducation(string educationName) => Utils.Read(Table.Education, new ParamArgs("@educationName", educationName));
            //Delete
            public static void DeleteEducation(string educationName) => Utils.Delete(Table.Education, new ParamArgs("@educationName", educationName));
        }

        public static class Person
        {
            //Create Person (should only create necessary data and use the update method to add nonessentials)       // TODO: CREATE PERSON METHOD
            public static void CreatePerson(string personID, string name, int age, string gender, string preference)
                => SendToDatabase(
                    "INSERT INTO Person(personID,name,age,gender,preference) VALUES (@personID,@name,@age,@gender,@preference)",
                    new ParamArgs("@personID", personID),
                    new ParamArgs("@name", name),
                    new ParamArgs("@age", age),
                    new ParamArgs("@gender", gender),
                    new ParamArgs("@preference", preference));
            //Update
            public static void UpdatePerson(string personID, ParamArgs changedValue) => Utils.Update(Table.Person, new ParamArgs("@personID", personID), changedValue);
            //Read
            public static DataSet ReadPerson(string personID) => Utils.Read(Table.Person, new ParamArgs("@personID", personID));
            //Delete
            public static void DeletePerson(string personID) => Utils.Delete(Table.Person, new ParamArgs("@personID", personID));
        }

        public static class Relationship
        {
            //Create
            public static void CreateRelationship(string relationshipType, int lvlOfCommitment)
                => Utils.Create(Table.Relationship, new ParamArgs("@relationshipType", relationshipType), new ParamArgs("@lvlOfCommitment", lvlOfCommitment));
            //Update
            public static void UpdateRelationship(string relationshipType, int newLvlOfCommitment)
                => Utils.Update(Table.Relationship, new ParamArgs("@relationshipType", relationshipType), new ParamArgs("@lvlOfCommitment", newLvlOfCommitment));
            //Read
            public static DataSet ReadRelationship(string relationshipType) => Utils.Read(Table.Relationship, new ParamArgs("@relationshipType", relationshipType));
            //Delete
            public static void DeleteRelationship(string relationshipType) => Utils.Delete(Table.Relationship, new ParamArgs("@relationshipType", relationshipType));
        }

        public static class Interest
        {
            //Create
            public static void CreateInterest(string category, string group)
                => Utils.Create(Table.Interest, new ParamArgs("@interestCategory", category), new ParamArgs("@interestGroup", group));
            //Update
            public static void UpdateInterest(string interestCategory, string newGroup)
                => Utils.Update(Table.Interest, new ParamArgs("@interestCategory", interestCategory), new ParamArgs("@interestGroup", newGroup));
            //Read
            public static DataSet ReadInterest(string interestCategory) => Utils.Read(Table.Interest, new ParamArgs("@interestCategory", interestCategory));
            //Delete
            public static void DeleteInterest(string interestCategory) => Utils.Delete(Table.Interest, new ParamArgs("@interestCategory", interestCategory));
        }

        private static DataSet SendToDatabase(string sqlQuery, params ParamArgs[] args)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection("Data Source = SYST4DEV01; Initial Catalog = Cronus; User ID=hygge ; Password =hej123 "))
                { //SQL Connection
                    cnn.Open();
                    using (SqlCommand command = new SqlCommand(sqlQuery, cnn)) // "using" keyword ensures disposal when objects are no longer used
                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        if (args != null) { foreach (ParamArgs param in args) command.Parameters.AddWithValue(param.ParamID, param.Value); } // fill each parameter using ParamArgs
                        string queryType = sqlQuery.Substring(0, 6);                                        //The initial command is separated into a substring
                        List<string> wca = new List<string> { "UPDATE", "INSERT", "DELETE" };
                        if (wca.Contains(queryType))
                        {        // if the query contains a command that writes to the database...
                            switch (queryType)
                            {// ... then the adapter will be associated with the proper command and executed.
                                case "UPDATE":
                                    adapter.UpdateCommand = command; //association...
                                    adapter.UpdateCommand.ExecuteNonQuery(); //... and execution
                                    break;
                                case "DELETE":
                                    adapter.DeleteCommand = command;
                                    adapter.DeleteCommand.ExecuteNonQuery();
                                    break;
                                case "INSERT":
                                    adapter.InsertCommand = command;
                                    adapter.InsertCommand.ExecuteNonQuery();
                                    break;
                            }
                            return null; // returns null in place of a DataSet. Shouldn't cause any issues since this code path should only be reached by non-SELECT statements.
                        }
                        else
                        {
                            DataSet dataSet = new DataSet(); // A new DataSet is initialized
                            adapter.SelectCommand = command; // adapter is associated with the identified SELECT command
                            adapter.Fill(dataSet); // The DataSet is filled with the results from the adapter's command
                            return dataSet; // the DataSet is returned
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("error"); return null;
            } // error handling here
        }
    }
}