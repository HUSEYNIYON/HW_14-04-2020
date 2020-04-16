using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataExample
{
    class Person
    {
        SqlConnect sqlConnect;
        public Person()
        {
            sqlConnect = new SqlConnect();
        }
        public void GetPerson()
        {
            string str = "SELECT * FROM Person";
            sqlConnect.Open();
            sqlConnect.Get(str);
            sqlConnect.Close();
        }
        public void GetPersonById(int Id)
        {
            string str = $"SELECT * FROM Person WHERE ID={Id}";
            sqlConnect.Open();
            sqlConnect.Get(str);
            sqlConnect.Close();
        }
        public void PutInfoEmployees(string LastName, string FirstName, string MiddleName, DateTime BirthDate)
        {
            string str = $"INSERT INTO Person ([LastName], [FirstName], [MiddleName], [BirthDate]) VALUES ('{LastName}','{FirstName}','{MiddleName}','{BirthDate}')";
            sqlConnect.Open();
            sqlConnect.Insert(str);
            sqlConnect.Close();
        }
        public void DeletePersonInfo(int Id)
        {
            string str = $"DELETE Person WHERE ID={Id}";
            sqlConnect.Open();
            sqlConnect.Delete(str);
            sqlConnect.Close();
        }
        public void UpdatePerson(int ID,string LastName, string FirstName, string MiddleName, DateTime BirthDate)
        {
            string insertSqlCommand = $"Update Person set FirstName='{LastName}',LastName='{FirstName}',MiddleName='{MiddleName}',BirthDate='{BirthDate}' where id={ID}";
            sqlConnect.Open();
            sqlConnect.Update(insertSqlCommand);
            sqlConnect.Close();
        }
    }
}