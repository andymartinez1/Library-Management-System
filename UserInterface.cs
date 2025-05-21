using Spectre.Console;

namespace LibraryManagementSystem;

internal class UserInterface
{
    private BooksController _booksController = new BooksController();

    internal void MainMenu()
    {
        while (true)
        {
            Console.Clear();

            var choice = AnsiConsole.Prompt(
                new SelectionPrompt<Enums.MenuOption>()
                    .Title("What do you want to do?")
                    .AddChoices(Enum.GetValues<Enums.MenuOption>()));

            switch (choice)
            {
                case Enums.MenuOption.ViewBooks:
                    _booksController.ViewBooks();
                    break;
                case Enums.MenuOption.AddBook:
                    _booksController.AddBook();
                    break;
                case Enums.MenuOption.DeleteBook:
                    _booksController.DeleteBook();
                    break;
            }
        }
    }
}