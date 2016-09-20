using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberWizards : MonoBehaviour {

    int max;
    int min;
    int guess;

    public Text guessText;

    public int maxGuessesAllowed = 5;

	// Use this for initialization
	void Start () {
        StartGame();
	}

    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = (max + min) / 2;
      
        max = max + 1;
    }

    //run when need to update the guess
    void NextGuess()
    {
        guess = (max + min) / 2;
        guessText.text = guess.ToString();
        maxGuessesAllowed = maxGuessesAllowed - 1;
        if (maxGuessesAllowed <= 0)
        {
            Application.LoadLevel("Lose");
        }
        
    }
    
    public void GuessHigher()
    {
        min = guess;
        NextGuess();
    }
    public void GuessLower()
    {
        max = guess;
        NextGuess();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
