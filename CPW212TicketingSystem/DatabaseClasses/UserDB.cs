using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW212TicketingSystem
{
    static class UserDB
    {
        public static User FindUser(string Username, string Password)
        {
            // stores our dbcontext "our tracker" for our database into a variable so can act upon it.
            var db = new TicketingSystemDBContext();

            // we can omit the where clause as single or default implicitly should only return 1 result
            User userLoginCheck = db.Users.SingleOrDefault(currUser => currUser.Username == Username && currUser.Password == Password);

            return userLoginCheck;
        }
        // takes in a user object/context object which points to
        public static void RegisterUser(User regUser)
        {
            var db = new TicketingSystemDBContext();

            db.Users.Add(regUser);
        }

    }
}
