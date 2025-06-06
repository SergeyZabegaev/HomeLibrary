using System;

namespace Books.Model;

public class Book
{
    public Guid Id { get; set; }
    public required string Title { get; set; }
    public required string Author { get; set; }
    public string? Description { get; set; }
    public string? Category { get; set; }
    public int PageCount { get; set; }
    public DateTime PublishedDate { get; set; }

}
