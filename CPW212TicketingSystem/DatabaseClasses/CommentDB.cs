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

        static TicketingSystemDBContext db = new TicketingSystemDBContext();

        // Creates a comment and adds it to the database.
        public static void addComment(Comment comment)
        {
            // ask joe about this 
            db.Tickets.Attach(comment.Ticket);
            
            //db.Users.Attach(comment.User);
            

            //db.Entry(comment.User).State = EntityState.Unchanged;
            //db.Entry(comment.Ticket).State = EntityState.Unchanged;

            //db.Comments.Add(comment);
            db.Entry(comment.Ticket).State = EntityState.Added;
            db.SaveChanges();
            
        }
        // removes a comment ..Though there should never be a reason to remove a comment really.
        public static void DeleteComment(Comment comment)
        {
            Comment commentToUpdate = db.Comments.Find(comment.CommentID);
            db.Comments.Remove(commentToUpdate);
            db.SaveChanges();
        }

        public static void UpdateComment(Comment comment)
        {
            Comment commentToUpdate = db.Comments.Find(comment.CommentID);
            commentToUpdate.Text = comment.Text;
            commentToUpdate.LastEdited = DateTime.Now;

            db.SaveChanges();
        }
        //Grabs all comments.
        public static List<Comment> GetAllComments()
        {
            List<Comment> ListOfComments = (db.Comments).ToList();
            return ListOfComments;
        }
        // grabs the current ticket that we are viewing, passes it down to our extension method, to run a query that selects all comments
        // that have a ticket and that their ticket matches, the same ticketID as the one passed in by the parameter.
        public static List<Comment> GetCommentsByTickID(Ticket ticket)
        {
            List<Comment> TicketComments = db.Comments.Where(c => c.Ticket.TicketID == ticket.TicketID).OrderBy(c => c.Created).Include("Ticket").ToList();
            //this will return it in sorted order of when it was created.

            return TicketComments;
        }

        public static List<Comment> GetCommentsByUser(User user)
        {
            List<Comment> UserComments = (from c in db.Comments where c.User.UserID == user.UserID select c).ToList();
            return UserComments;
        }

        public static List<Comment> GetInternalComments(Ticket ticket)
        {
            List<Comment> InternalComments =
                (from c in db.Comments where c.Ticket.TicketID == ticket.TicketID && c.IsInternal select c).ToList();

            return InternalComments;
        }


    }
}
