public class Video
{
    public string _title;
    public string _author;
    public int _videoLength;
    public List<Comment> _comments = new List<Comment>();


    public Video(string title, string author, int videoLength,  params Comment[] comments)
 
    {
        _title = title;
        _author = author;
        _videoLength = videoLength;
       _comments.AddRange(comments);

    //    OR     Comments = new List<Comment>(comments);
    }

    
    public int NumberOfComments()
    {
        return _comments.Count;
    }

    // USING THE PRINCIPLES OF ABSTRACTION, IT IS VERY ACCEPTABLE TO LEAVE YOUR ATTRIBUTES TO BE ACCESSIBLE OR PUBLIC

    // public string GetTittle()
    // {
    //     return _tittle;
    // }

    // public string GetAuthor()
    // {
    //     return _author;
    // }

    // public int GetVideoLength()
    // {
    //     return _videoLength;
    // }
}