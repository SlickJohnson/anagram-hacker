using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    // Game configuration data
    string[] level1Passwords = { "12345", "easy", "laptop1", "donthackthis", "veryhard" };
    string[] level2Passwords = { "HardMode", "SuperVirus", "pathoGen", "H4cker", "200billi" };


    // Game state
    int level;

    // Current screen
    enum Screen { MainMenu, Password, Win };
    Screen currentScreen = Screen.MainMenu;

    // Current password being guessed
    string password;

    // Use this for initialization
    void Start()
    {
        ShowMainMenu();
    }

    // Show menu on terminal
    void ShowMainMenu()
    {
        currentScreen = Screen.MainMenu;
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
        else if (currentScreen == Screen.Password) {
            CheckPassword(input);
        }
    }

    // Handles input for main menu
    private void RunMainMenu(string input)
    {
        bool isValidLevelNumber = (input == "1" || input == "2");
        if (isValidLevelNumber)
        {
            level = int.Parse(input);
            AskForPassword();
        }
    }

    // Starts the game 
    void AskForPassword()
    {
        Terminal.ClearScreen();
        SetRandomPassword();
        Terminal.WriteLine("type \"menu\" to return to menu");
        Terminal.WriteLine("Enter password, hint: " + password.Anagram());
    }

    private void SetRandomPassword()
    {
        currentScreen = Screen.Password;
        switch (level)
        {
            case 1:
                int index1 = Random.Range(0, level1Passwords.Length);
                password = level1Passwords[index1];
                break;
            case 2:
                int index2 = Random.Range(0, level2Passwords.Length);
                password = level2Passwords[index2];
                break;
            default:
                Debug.LogError("Invalid level number");
                break;
        }
    }

    // Handles input for password menu
    private void CheckPassword(string input)
    {
        if (input == password)
        {
            DisplayWinScreen();
        }
        else
        {
            AskForPassword();
        }
    }

    private void DisplayWinScreen()
    {
        currentScreen = Screen.Win;
        Terminal.ClearScreen();
        Terminal.WriteLine("Access granted...");
        ShowLevelReward();
        Terminal.WriteLine("type \"menu\" to return to menu");
    }

    private void ShowLevelReward()
    {
        switch(level)
        {
            case 1:
                Terminal.WriteLine("Here's the blueprints for the high tech book model...");
                Terminal.WriteLine(@"
    _______
   /      /,
  /      //
 /______//
(______(/
                ");
                break;
            case 2:
                Terminal.WriteLine("You now have access to the giant camera at the front of the bulding...");
                Terminal.WriteLine(@"
  _______
 |__/-\[]|
 |  (_)  |
 |_______|
    /|\
                ");
                break;
            default:
                Debug.LogError("Invalid");
                break;
        }
        Terminal.WriteLine("Return to main menu");
    }
}
