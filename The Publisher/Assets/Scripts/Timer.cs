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

    bool IsRunning = false;
    bool IsFinished = false;
    
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
        if (IsRunning)
        {
            RemainingTime = Mathf.Max(RemainingTime - Time.fixedDeltaTime, 0);
            TimerText.text = ((int)RemainingTime).ToString() + " s";
        }

        if (!IsFinished && RemainingTime <= 0f)
        {
            IsFinished = true;
            IsRunning = false;
            GameMgr.EndGame();
        }
    }

    public void StartTimer(bool Start)
	{
        IsRunning = Start;
	}
}
