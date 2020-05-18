using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static int score;
    
    void Start()
    {
        //initializing the player score
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //updating the score text
        GetComponent<UnityEngine.UI.Text>().text = score.ToString();
    }
}
