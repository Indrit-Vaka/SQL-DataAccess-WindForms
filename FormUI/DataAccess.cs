using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
namespace FormUI
{
    public class DataAccess
    {
        public List<Person> GetPeople(string lastName)
        {
            //Using qe te mbyllet lidhja
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDB")))
            {
                //var output = connection.Query<Person>($"select * from Person where LastName = '{lastName}'").ToList();
                //var output = connection.Query<Person>("dbo.People_GetBlastName @LastName", new {Lastname = lastName}).ToList();
                var output = connection.Query<Person>($"exec People_GetBlastName @LastName = '{lastName}' ").ToList();
                return output;
            }

        }

        public void InsertPerson(string firtName, string lastName, string emailAddress, string phoneNumber)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDB")))
            {
                //Person newPerson = new Person { FirstName = firtName, LasttName = lastName, EmailAddress = emailAddress, PhoneNumber = phoneNumber };

                List<Person> peope = new List<Person>
                {
                    new Person { FirstName = firtName, LastName = lastName, EmailAddress = emailAddress, PhoneNumber = phoneNumber }
                };
                connection.Execute("dbo.People_Insert @FirstName, @LastName, @EmailAddress, @PhoneNumber", peope);
            }
        }
    }
}
