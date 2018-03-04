using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW212TicketingSystem
{
    static class UserDB
    {
        public static User GetUser(string username)
        {
            var db = new TicketingSystemDBContext();
            return db.Users.Where(u => u.Username.Contains(username)).Single();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="user"></param>
        /// <returns>Returns false if username already exists</returns>
        public static bool Add(User user)
        {
            var db = new TicketingSystemDBContext();
            User u = db.Users.Find(user.Username);

            if (u == null)
            {
                db.Users.Add(user);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

         /// <summary>
         /// 
         /// </summary>
         /// <param name="user"></param>
         /// <returns>Returns true if username is in Users table</returns>
        public static bool Update(User user)
        {
            var db = new TicketingSystemDBContext();
            User u = db.Users.Find(user.Username);

            if (u == null)
            {
                return false;
            }
            else
            {
                u.Username = user.Username;
                u.Password = user.Password;
                u.FirstName = user.FirstName;
                u.LastName = user.LastName;
                u.AssignedTickets = user.AssignedTickets;
                u.Role = user.Role;
                db.SaveChanges();
                return true;
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="user"></param>
        /// <returns>Returns true if user exists in Users table</returns>
        public static bool Delete(User user)
        {
            var db = new TicketingSystemDBContext();
            User u = db.Users.Find(user.Username);

            if (u == null)
            {
                return false;
            }
            else
            {
                db.Users.Remove(user);
                db.SaveChanges();
                return true;
            }
        }
        public static User FindUser(string Username, string Password)
        {
            // stores our dbcontext "our tracker" for our database into a variable so can act upon it.
            var db = new TicketingSystemDBContext();

            // we can omit the where clause as single or default implicitly should only return 1 result
            User userLoginCheck = db.Users
                                    .Include("Role")
                                    .Where(currUser => currUser.Username == Username && currUser.Password == Password)
                                    .SingleOrDefault();

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
