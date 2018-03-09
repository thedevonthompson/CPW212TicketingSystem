using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW212TicketingSystem
{
    /// <summary>
    /// Responsible for User CRUD interactions with the database
    /// </summary>
    static class UserDB
    {
        /// <summary>
        /// Returns all Users from the database
        /// </summary>
        /// <returns>List of Users</returns>
        public static List<User> GetAllUsers()
        {
            return new TicketingSystemDBContext().Users.ToList();
        }

        /// <summary>
        /// Returns a user by username
        /// </summary>
        /// <param name="username"></param>
        /// <returns>User</returns>
        public static User GetUser(string username)
        {
            var db = new TicketingSystemDBContext();
            return db.Users.Where(u => u.Username.Contains(username)).Single();
        }

        /// <summary>
        /// Adds the user passed in to the database
        /// </summary>
        /// <param name="user">User to be added to the database</param>
        public static void Add(User user)
        {
            var db = new TicketingSystemDBContext();
            db.Users.Add(user);
            db.SaveChanges();
        }

        /// <summary>
        /// Updates the User passed in by userID
        /// </summary>
        /// <param name="user"></param>
        /// <returns>Returns true if User with the UserID is in Users table</returns>
        public static bool Update(User user)
        {
            var db = new TicketingSystemDBContext();
            User u = db.Users.Find(user.UserID);

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
        /// Deletes the User passed in from the database
        /// </summary>
        /// <param name="user">User to be deleted</param>
        public static void Delete(User user)
        {
            var db = new TicketingSystemDBContext();
            db.Users.Remove(user);
            db.SaveChanges();
        }

        /// <summary>
        /// Returns the user with the current name and password
        /// </summary>
        /// <param name="Username">Username to be found</param>
        /// <param name="Password">Password to be found </param>
        /// <returns></returns>
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
