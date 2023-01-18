using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

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

    private string input;
    private string randomWord;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = 3.5f;

        RandomWordCreate();
        gameOverPanel.SetActive(false);
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
        question.text = randomWord;

        if(currentTime < 0.1f)
        {
            RandomWordCreate();
        }


        GameOver();
        
    }


    public void ReadStringInput(string s)
    {
        input = s;
        Debug.Log(input);
        if (randomWord == input)
        {
            score++;
            RandomWordCreate();
        }

        
    }

    void RandomWordCreate()
    {

        int randomint =  Random.Range(1, 10);
        randomWord = word[randomint];
        

        currentTime = 3.5f;
    }


    public GameObject gameOverPanel;
    public TMP_Text currentScore;
    void GameOver()
    {
        if(score == 10)
        {
            gameOverPanel.SetActive(true);
            currentScore.text = "맞춘 갯수 : " + score.ToString();
        }
    }

    public void ReturnLoby()
    {
        SceneManager.LoadScene(0);
    }
}
