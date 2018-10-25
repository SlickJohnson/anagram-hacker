using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    // Game state
    int level;

    // Use this for initialization
    void Start()
    {
        ShowMainMenu();
    }

    // Show menu on terminal
    void ShowMainMenu()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Hello!");
        Terminal.WriteLine("Let's keep this simple.");
        Terminal.WriteLine("I'll test your abilites to see if your worthy to join the team.");
        Terminal.WriteLine("Press Ctrl + P to start...");
    }

    // Handle user input
    void OnUserInput(string input)
    {
        if (input == "menu")
        {
            ShowMainMenu();
        }
        else if (input == "007")
        {
            Terminal.WriteLine("Please select a level Mr. Bond!");
        }
        else if (input == "1")
        {
            level = 1;
            StartGame();
        }
        else if (input == "2")
        {
            level = 2;
            StartGame();
        }
        else
        {
            Terminal.WriteLine("Please choose a valid level.");
        }
    }

    // Start Game
    void StartGame()
    {
        Terminal.WriteLine("You have chosen level " + level);
    }
}
