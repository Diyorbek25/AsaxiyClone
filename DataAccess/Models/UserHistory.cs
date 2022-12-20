
using System;

namespace DataAccess.Models;

internal class UserHistory
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public int OrderId { get; set; }
    public DateTime Date { get; set; }
}