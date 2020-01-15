using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public Text texts;
    public static int score;
    public static int coinValue = 1 ;
    // Start is called before the first frame update
    void Start()
    {
        texts = GetComponent<Text>();
        score = 0;
    }

    // Update is called once per frame
     void Update()
    {
         texts.text = "X" + score.ToString();
    }
}
