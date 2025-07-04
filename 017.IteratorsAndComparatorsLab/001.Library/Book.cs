﻿namespace IteratorsAndComparators;

public class Book
{
    public Book(string title, int year, params string[] authors)
    {
        Title = title;
        Year = year;
        Authors = authors.ToList();
    }

    public string Title { get; set; }
    public int Year { get; set; }
    public List<string> Authors { get; set; }
}
public class Library
{
    private List<Book> books;

    public Library(params Book[] books)
    {
        this.books = new List<Book>(books);
    }
}