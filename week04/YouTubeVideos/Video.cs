using System;
using System.Reflection;

public class Video
{
    string _title;
    string _author;
    int _seconds;
    List<Comment> _comments;

    public Video(string title, string author, int seconds)
    {
        _title = title;
        _author = author;
        _seconds = seconds;
        _comments = new List<Comment>();
    }

    public int GetCommentsCount()
    {
        return _comments.Count;
    }

    public void AddComment(Comment newComment)
    {
        _comments.Add(newComment);
    }

    public void GetDisplay()
    {
        Console.WriteLine($"Title: {_title} | Author: {_author} | Length: {_seconds} seconds | Comments: {GetCommentsCount()}");
        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"{comment.GetDisplay()}");
        }
    }
}