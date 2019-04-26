using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_System
{
        public   class DataBase
    {
        public static List<Person> PersonListFromDB()
        {
            using (IDbConnection cnn = new SQLiteConnection(CString()))
            {

                var output = cnn.Query<Person>("select * from person", new DynamicParameters());
                return output.ToList();

            }
        }

        public static void AddPersonToDB(Person person)
        {
            using (IDbConnection cnn = new SQLiteConnection(CString()))
            {

                cnn.Execute("INSERT INTO Person (Name, LastName,WagePH,[HourWorked],[PaidAlready])VALUES(@Name, @LastName, @WagePH, @HourWorked, @PaidAlready)",person);
            }
        }
        private static string CString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        public static void DeletePersonFromDB(Person person)
        {
            if (person != null)
            {
                using (IDbConnection cnn = new SQLiteConnection(CString()))
                {
                    cnn.Execute("DELETE FROM [Person] WHERE ID = @ID ", person);
                }


            }



        }

        public static void UpdatePersonFromDb(Person person)
        {
            using (IDbConnection cnn = new SQLiteConnection(CString()))
            {
                cnn.Execute("UPDATE [Person] SET [Name] = @Name, [LastName] = @LastName, [WagePH] = @WagePH, [HourWorked] = @HourWorked, [PaidAlready] = @PaidAlready, Image = @Image WHERE ID = @ID;", person);
            
             }

        }

    }
}
