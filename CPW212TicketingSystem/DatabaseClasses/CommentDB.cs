using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW212TicketingSystem
{
    static class CommentDB
    {

        private static TicketingSystemDBContext db = new TicketingSystemDBContext();

        // Creates a comment and adds it to the database.

        #region Create
        public static void addComment(int? tickID, int? userId, string text, bool isInternal)
        {
            // because of our database being a bit complicated for entity frame work
            // we resorted back to a primitive state of  creating our objects from scratch in the method call 
            // so the entity state would not try to insert duplicate records

            User currUser = db.Users.Single(x => x.UserID == userId);
            Ticket currTicket = db.Tickets.Single(t => t.TicketID == tickID);

            Comment newComment = new Comment(text: text, isInternal: isInternal, ticket: currTicket,
                created: DateTime.Now, user: currUser);
            db.Comments.Add(newComment);
            db.SaveChanges();

        }
        #endregion

        #region Read
        // grabs all public comments for that ticket NOTE: DOES NOT INCLUDE INTERNAL TICKETS
        public static List<Comment> GetAllPublicCommentsByTickID(Ticket ticket)
        {//
            return db.Comments.Where(c => c.Ticket.TicketID == ticket.TicketID && c.IsInternal == false).OrderBy(c => c.Created).Include("Ticket").Include("User").ToList();
        }

        //grabs all comments including internal tech comments

        public static List<Comment> GetAllCommentsByTickID(Ticket ticket)
        {
            return db.Comments.Where(c => c.Ticket.TicketID == ticket.TicketID).OrderBy(c => c.Created)
                .Include("Ticket").Include("User").ToList();
        }


        #endregion
         
        #region Update
        public static void UpdateComment(Comment comment)
        {
            Comment commentToUpdate = db.Comments.Find(comment.CommentID);
            commentToUpdate.Text = comment.Text;
            commentToUpdate.LastEdited = DateTime.Now;

            db.SaveChanges();
        }


        #endregion

        #region Delete
        public static void DeleteComment(Comment comment)
        {
            Comment commentToUpdate = db.Comments.Find(comment.CommentID);
            db.Comments.Remove(commentToUpdate);
            db.SaveChanges();
        }


        #endregion










        #region Unused




        // we don't really need these but they are here in case we do
        //        //todo make these not look like garbage
        //        public static List<Comment> GetCommentsByUser(User user)
        //        {
        //            List<Comment> UserComments = (from c in db.Comments where c.User.UserID == user.UserID select c).ToList();
        //            return UserComments;
        //        }
        //
        //
        //
        //        public static List<Comment> GetInternalComments(Ticket ticket)
        //        {
        //            List<Comment> InternalComments =
        //                (from c in db.Comments where c.Ticket.TicketID == ticket.TicketID && c.IsInternal select c).ToList();
        //
        //            return InternalComments;
        //        }
        #endregion

    }//end class
}
