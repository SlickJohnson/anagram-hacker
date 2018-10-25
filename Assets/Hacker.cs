using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {

    // Use this for initialization
    void Start() {
        ShowMainMenu();
    }

    // Show menu on terminal
    void ShowMainMenu() {
        Terminal.ClearScreen();
        Terminal.WriteLine("Hello!");
        Terminal.WriteLine("Let's keep this simple.");
        Terminal.WriteLine("I'll test your abilites to see if your worthy to join the team.");
        Terminal.WriteLine("Press Ctrl + P to start...");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
