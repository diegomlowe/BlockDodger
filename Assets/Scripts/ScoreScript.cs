using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {

    //public static int scoreVal;

    public Text scoreText;

	// Use this for initialization
	void Start () {

        scoreText = GetComponent<Text>();

	}
	
	// Update is called once per frame
	void Update () {

        scoreText.text = FindObjectOfType<PlayerScript>().getScore().ToString();

	}
}
