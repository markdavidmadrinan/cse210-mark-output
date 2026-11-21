public class Comment
{
    // Member variables
    private string _commenterName;
    private string _commentText;

    // Constructor
    public Comment(string commenterName, string commentText)
    {
        _commenterName = commenterName;
        _commentText = commentText;
    }

    // Display the comment
    public void Display()
    {
        Console.WriteLine($"{_commenterName}: {_commentText}");
    }
}