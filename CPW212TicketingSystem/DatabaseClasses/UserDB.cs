using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW212TicketingSystem.DatabaseClasses
{
    static class UserDB
    {
        public static User FindUser(string Username, string Password)
        {
            // stores our dbcontext "our tracker" for our database into a variable so can act upon it.
            var db = new TicketingSystemDBContext();
            #region Internal Learning notes
            // uses lambda expression to..
            // return 1 resault or throw an exception if more than 1 result is obtain
            // so it checks the db.users which is basically stating check our db context which is tracking our database
            // then check out the dbset within that db context which will look at the users table essentially as the 
            // dbset is that entity.
            // then it checks to see if it matches the username and password parameter that is passed in.
            // then finally if more then 1 row is returned it will throw the exception if not 1 row is returned
            // then we know we have a user with that matching authentication.
            #endregion
            // we can omit the where clause as single or default implicitly should only return 1 result
            User userLoginCheck = db.Users.SingleOrDefault(currUser => currUser.Username == Username && currUser.Password == Password);

            return userLoginCheck;
        }

        public static void RegisterUser(User regUser)
        {
            var db = new TicketingSystemDBContext();

            db.Users.Add(regUser);
        }

    }
}
