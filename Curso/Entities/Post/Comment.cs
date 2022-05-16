namespace Curso.Entities.Post
{
    public class Comment
    {
        public Comment() { }

        public Comment(string text)
        {
            Text = text;
        }

        public string Text { get; set; }
    }
}
