using UnityEngine;
using System.IO;
using UnityEngine.UI;
using System;

public class UpdateHighscore : MonoBehaviour
{
    public Text score;
    private string currentHighscore;

    public void update()
    {
        if(System.IO.File.Exists(Directory.GetCurrentDirectory() + "/highscore.txt"))
        {
            currentHighscore = File.ReadAllText(Directory.GetCurrentDirectory() + "/highscore.txt");
        }
        else
        {
            System.IO.File.WriteAllText(Directory.GetCurrentDirectory() + "/highscore.txt", "0");
            currentHighscore = File.ReadAllText(Directory.GetCurrentDirectory() + "/highscore.txt");
        }

        int textValue = 0;
        int scoreValue = 0;

        Int32.TryParse(currentHighscore, out textValue);
        Int32.TryParse(score.text, out scoreValue);
        if (scoreValue > textValue)
        {
            System.IO.File.WriteAllText(Directory.GetCurrentDirectory() + "/highscore.txt", score.text);
        }
    }
    
}
