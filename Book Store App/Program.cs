﻿using Book_Store_App.Models;

Console.WriteLine("Enter book Name:");
Book book = new(Console.ReadLine(), 239);

Console.WriteLine("Enter book Year:");
book.Year = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(book.Name + "   " + book.Year);

Book[] shelf = new Book[10];
shelf[0] = book;
shelf[1] = book;

Console.WriteLine(shelf.Count(x => x != null));

//foreach (Book b in shelf)
//{
//    Console.WriteLine(b.Name);
//}

/* Да добавим 2 книги с по 4 въпроса. След добавяне да изписва колко книги има в списъка. */

Console.WriteLine(shelf[0].Name);