using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.Entities.Post
{
    public class Post
    {
        public Post() { }

        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();

        #region Métodos

        public void AddComent(Comment coment)
        {
            Comments.Add(coment);
        }

        public void RemoveComent(Comment coment)
        {
            Comments.Remove(coment);
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine(Title);
            stringBuilder.Append(Likes);
            stringBuilder.Append(" Likes - ");
            stringBuilder.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            stringBuilder.AppendLine(Content);
            stringBuilder.AppendLine("Comments:");

            foreach (Comment comment in Comments)
            {
                stringBuilder.AppendLine(comment.Text);
            }

            return stringBuilder.ToString();
        }

        #endregion
    }
}
