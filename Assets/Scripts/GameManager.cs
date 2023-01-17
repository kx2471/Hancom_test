using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{

    private string[] word = new string[10] {"바나나", "사과",
        "귤", "망고", "딸기", "Banana", "Apple", "Orange",
        "Mango", "Strawberry" };

    public int score;
    public TMP_Text myScore;
    public TMP_Text myTime;
    public float timeCount;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        myScore.text = "나의 점수 : " + score;
    }
}
