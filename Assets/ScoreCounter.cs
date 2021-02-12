using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;


public class ScoreCounter : MonoBehaviour
{
    private GameObject scoreText;

    private int score = 0;


    // Start is called before the first frame update
    void Start()
    {
        SetScore();
    }


    // Update is called once per frame
    void Update()
    {
       
    }

    void OnCollisionEnter(Collision other)
    {
        
        SetScore();
        string tag = other.gameObject.tag;

        if (tag == "SmallStarTag")
        {
            score += 5;
        }
        else if (tag == "LargeStarTag")
        {
            score += 15;
        }
        else if (tag == "SmallCloudTag")
        {
            score += 10;
        }
        else if (tag == "LargeCloudTag")
        {
            score += 20;
        }

    }
    void SetScore()
    {
        this.scoreText = GameObject.Find("ScoreText");

        scoreText.GetComponent<Text>().text = score.ToString();
    }
}
