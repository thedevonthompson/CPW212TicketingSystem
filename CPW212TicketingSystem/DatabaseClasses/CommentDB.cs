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
        public static List<Comment> GetAllPublicComments()
        {
            return db.Comments.Where(c => c.IsInternal == false).ToList();
        }
        //grab all comments include tech comments known as internal comments
        public static List<Comment> GetAllComments()
        {
            return  (db.Comments).ToList();
        }




        // grabs all public comments for that ticket

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





        //todo make these not look like garbage
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
