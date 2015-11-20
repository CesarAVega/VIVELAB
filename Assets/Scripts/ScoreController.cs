using System;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour {

    private Text scoreText;
    private float totalScore = 0;
    private GameObject[] cookies;

    // Use this for initialization
    void Start () {
        scoreText = FindObjectOfType(typeof(Text)) as Text;
        cookies = GameObject.FindGameObjectsWithTag("Cookie");
        foreach (GameObject cookie in cookies) {
            cookie.GetComponent<Cookie>().touched += setTotalScore;
        }

    }

    public void setTotalScoreSuper() {
        totalScore += 200;
    }

    void FixedUpdate() {
        scoreText.text = "Este es su puntaje: " + totalScore;        
    }

    void setTotalScore() {
        totalScore += 100;
    }
}
