public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }
    public void AddComment(Comment newComment)
    {
        _comments.Add(newComment);
    }
    public int GetNumberOfComments()
    {
        int numberOfComments = 0;
        foreach (Comment comment in _comments)
        {
            numberOfComments++;
        }
        return numberOfComments;
    }
    public string GetDisplayText()
    {
        return $"{_title} - {_author} ({_length} sec)";
    }
    public void DisplayAll()
    {
        Console.WriteLine(GetDisplayText());
        Console.WriteLine($"Comments: {GetNumberOfComments()}");
        foreach (Comment comment in _comments)
        {
            Console.WriteLine(comment.GetDisplayText());
        }
        Console.WriteLine("");
    }
}