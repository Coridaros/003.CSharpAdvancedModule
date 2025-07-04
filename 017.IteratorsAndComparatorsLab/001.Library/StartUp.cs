﻿//Iterators and comparators - lab, Task 001
//23.06.2025, 22:08

namespace IteratorsAndComparators;

public class StartUp
{
    static void Main()
    {
        Book bookOne = new Book("Animal Farm", 2003, "George Orwell");
        Book bookTwo = new Book("The Documents in the Case", 2002,
            "Dorothy Sayers", "Robert Eustace");
        Book bookThree = new Book("The Documents in the Case", 1930);

        Library libraryOne = new Library();
        Library libraryTwo = new Library(bookOne, bookTwo, bookThree);
    }
}