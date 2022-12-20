using System;

namespace DataAccess.Models;

public class Comment
{
    public int Id { get; set; }

    public string Text { get; set; }

    //Rate for comments 
    public int Rate { get; set; }

    //Comment created date
    public DateTime Date { get; set; }

    //User Id of comment that Id is foreign key to releate 
    public int UserId { get; set; }
}