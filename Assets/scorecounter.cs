using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scorecounter : MonoBehaviour
{
    private int smallc = 2;
    private int largec = 3;
    private int smalls = 1;
    private int larges = 4;
    int score=0;
    private GameObject scoreText;


    // Start is called before the first frame update
    void Start()
    {
        this.scoreText = GameObject.FindGameObjectWithTag("Score");

    }

    // Update is called once per frame
    void Update()
    {
        this.scoreText.GetComponent<Text>().text = "得点："+score.ToString();
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="SmallCloudTag")
        {
            score += 2;
        }
        if(collision.gameObject.tag=="LargeCloudTag")
        {
            score += 3;
        }
        if(collision.gameObject.tag=="SmallStarTag")
        {
            ++score;
        }
        if(collision.gameObject.tag=="LargeStarTag")
        {
            score += 4;
        }

    }
}
