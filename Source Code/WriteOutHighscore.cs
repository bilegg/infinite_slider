using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class WriteOutHighscore : MonoBehaviour
{
    public Text highscore;

    void Start()
    {
        
        string newHighscore = File.ReadAllText(Directory.GetCurrentDirectory() + "/highscore.txt");

        highscore.text = "Highscore: " + newHighscore;
    }

}
