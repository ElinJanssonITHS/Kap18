﻿
namespace Bookstore.Data;

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Isbn { get; set; } = string.Empty;
    public int PublisherId { get; set; }
    public Publisher? Publisher { get; set; }
    public virtual ICollection<Author>? Authors { get; set; }
}
