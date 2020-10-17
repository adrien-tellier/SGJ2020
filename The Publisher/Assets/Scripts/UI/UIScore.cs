﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class UIScore : MonoBehaviour
{
    [SerializeField]
    private GameManager GameMgr = null;

    private Text ScoreText = null;

    // Start is called before the first frame update
    void Start()
    {
        ScoreText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScore()
	{
        ScoreText.text = GameMgr.GetScore() + " pts";
	}
}
