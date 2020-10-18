using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[RequireComponent(typeof(TextMeshProUGUI))]
public class Timer : MonoBehaviour
{
    [SerializeField]
    private float Duration = 60f;
    private float RemainingTime = 0f;
    private TextMeshProUGUI TimerText;

    [SerializeField]
    GameManager GameMgr = null;

    bool isFinished = false;

    // Start is called before the first frame update
    void Start()
    {
        RemainingTime = Duration;
        TimerText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	private void FixedUpdate()
	{
        RemainingTime = Mathf.Max(Duration - Time.timeSinceLevelLoad, 0);
        TimerText.text = ((int)RemainingTime).ToString() + " s";
        if (!isFinished && RemainingTime <= 0f)
        {
            isFinished = true;
            GameMgr.EndGame();
        }
	}
}
