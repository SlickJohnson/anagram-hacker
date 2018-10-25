using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    // Game state
    int level;
    // Current screen
    enum Screen { MainMenu, Password, Win };
    Screen currentScreen = Screen.MainMenu;

    // Use this for initialization
    void Start()
    {
        ShowMainMenu();
    }

    // Show menu on terminal
    void ShowMainMenu()
    {
        currentScreen = Screen.MainMenu
        Terminal.ClearScreen();
        Terminal.WriteLine("Hello!");
        Terminal.WriteLine("Let's keep this simple.");
        Terminal.WriteLine("I'll test your abilites to see if your worthy to join the team.");
        Terminal.WriteLine("Press Ctrl + P to start...");
    }

    // Handle user input
    void OnUserInput(string input)
    {
        if (input == "menu") // Can always go back to main menu.
        {
            ShowMainMenu();
        }
        else if (currentScreen == Screen.MainMenu)
        {
            RunMainMenu(input);
        }
    }

    // Runs the menu commands
    private void RunMainMenu(string input)
    {
        if (input == "1")
        {
            level = 1;
            StartGame();
        }
        else if (input == "2")
        {
            level = 2;
            StartGame();
        }
        else if (input == "007")
        {
            Terminal.WriteLine("Please select a level Mr. Bond!");
        }
        else
        {
            Terminal.WriteLine("Please choose a valid level.");
        }
    }

    // Start Game
    void StartGame()
    {
        currentScreen = Screen.Password;
        Terminal.WriteLine("You have chosen level " + level);
    }
}
