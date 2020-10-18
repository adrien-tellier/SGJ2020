using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(TextMeshProUGUI))]
public class UIScore : MonoBehaviour
{
    [SerializeField]
    private GameManager GameMgr = null;

    private TextMeshProUGUI ScoreText = null;

    // Start is called before the first frame update
    void Awake()
    {
        ScoreText = GetComponent<TextMeshProUGUI>();
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
