namespace Packt.Shared;

// code analysis name space to use SetsRequiredMembers attribute.
using System.Diagnostics.CodeAnalysis;

public class Book
{
    public required string? Isbn;
    public required string? Title;
    public string? Author;
    public int PageCount;

    #region Constructors
    
    // enables object initializer syntax with empty brackets
    public Book()
    {
    }

    // constructor with parameters
    [SetsRequiredMembers]
    public Book(string? isbn, string? title)
    {
        Isbn = isbn;
        Title = title;
    }

    #endregion
}