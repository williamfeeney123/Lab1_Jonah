using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public static int score;
    public static int score2;
    private Text text;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        score = 0;
        score2 = 0;
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Score : " + score + "/ " + score2;
    }
}
