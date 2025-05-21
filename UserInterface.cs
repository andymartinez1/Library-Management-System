using LibraryManagementSystem.Controllers;
using Spectre.Console;

namespace LibraryManagementSystem;

internal class UserInterface
{
    private readonly BookController _bookController = new();
    private readonly MagazineController _magazinesController = new();
    private readonly NewspaperController _newspapersController = new();

    internal void MainMenu()
    {
        while (true)
        {
            Console.Clear();

            var actionChoice = AnsiConsole.Prompt(
                new SelectionPrompt<Enums.MenuAction>()
                .Title("What do you want to do next?")
                .AddChoices(Enum.GetValues<Enums.MenuAction>()));

            var itemTypeChoice = AnsiConsole.Prompt(
                new SelectionPrompt<Enums.ItemType>()
                .Title("Select the type of item:")
                .AddChoices(Enum.GetValues<Enums.ItemType>()));

            switch (actionChoice)
            {
                case Enums.MenuAction.ViewItem:
                    ViewItems(itemTypeChoice);
                    break;
                case Enums.MenuAction.AddItem:
                    AddItem(itemTypeChoice);
                    break;
                case Enums.MenuAction.DeleteItem:
                    DeleteItem(itemTypeChoice);
                    break;
            }


        }
    }

    private void ViewItems(Enums.ItemType itemType)
    {
        switch (itemType)
        {
            case Enums.ItemType.Book:
                _bookController.ViewItems();
                break;
            case Enums.ItemType.Magazine:
                _magazinesController.ViewItems();
                break;
            case Enums.ItemType.Newspaper:
                _newspapersController.ViewItems();
                break;
        }
    }

    private void AddItem(Enums.ItemType itemType)
    {
        switch (itemType)
        {
            case Enums.ItemType.Book:
                _bookController.AddItem();
                break;
            case Enums.ItemType.Magazine:
                _magazinesController.AddItem();
                break;
            case Enums.ItemType.Newspaper:
                _newspapersController.AddItem();
                break;
        }
    }

    private void DeleteItem(Enums.ItemType itemType)
    {
        switch (itemType)
        {
            case Enums.ItemType.Book:
                _bookController.DeleteItem();
                break;
            case Enums.ItemType.Magazine:
                _magazinesController.DeleteItem();
                break;
            case Enums.ItemType.Newspaper:
                _newspapersController.DeleteItem();
                break;
        }
    }
}