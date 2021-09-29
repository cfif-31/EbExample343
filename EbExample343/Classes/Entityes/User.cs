using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EbExample343.Classes.Entityes
{
    public class User
    {
        public int UserId;
        public string UserName;
        public string UserLogin;
        public string UserPass;
        

        public User(DataRow row) {
            UserId = Convert.ToInt32(row["UserId"]);
            UserName = Convert.ToString(row["UserName"]);
            UserLogin = Convert.ToString(row["UserLogin"]);
            UserPass = Convert.ToString(row["UserPass"]); 
        }

        public static List<User> Select() {
            List<User> users = new List<User>();
            foreach (DataRow row in DbConnector.Select("Select * from Users").Rows) {
                users.Add(new User(row));
            }
            return users;
        }
    }
}
