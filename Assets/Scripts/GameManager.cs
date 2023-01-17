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
    public float currentTime;

    public TMP_Text question;

    public string input;
    public string randomWord;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = 3.5f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        

        myScore.text = "나의 점수 : " + score;

        if (currentTime > 0)
        {
            currentTime -= Time.deltaTime;
            myTime.text = currentTime.ToString("F0");
        }

        
    }


    public void ReadStringInput(string s)
    {
        input = s;
        Debug.Log(input);
        if (randomWord == input)
        {
            score++;
        }

        randomWord = word[Random.Range(0, 10)];
        question.text = randomWord;
    }

}
