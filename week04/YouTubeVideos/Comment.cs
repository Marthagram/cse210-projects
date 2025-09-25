public class Comment
{
    public string _commentorName;
    public string _comment;

    public Comment(string name, string comment)
    {
        _commentorName = name;
        _comment = comment;
    }


    // USING THE PRINCIPLES OF ABSTRACTION, IT IS VERY ACCEPTABLE TO LEAVE YOUR ATTRIBUTES TO BE ACCESSIBLE OR PUBLIC
    // public string GetCommentorName()
    // {
    //     return _commentorName;
    // }

    // public string GetComment()
    // 
    //     return _comment;
    // }
}