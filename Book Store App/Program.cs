using Book_Store_App.Models;


Console.WriteLine("Enter book Name:");
Book book = new (Console.ReadLine() , 239 );

Console.WriteLine("Enter book Year:");
book.Year = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(book.Name + "   " + book.Year);

Book[] shelf = new Book[10];
shelf[0] = book;
shelf[1] = book;

Console.WriteLine(shelf.Count(x => x != null));

//foreach (var asd in shelf)
//{
//    Console.WriteLine(asd);
//}

/* Да добавим 2 книги , 4 въпроса , след добавяне да изписва колко книги има в списъка.*/