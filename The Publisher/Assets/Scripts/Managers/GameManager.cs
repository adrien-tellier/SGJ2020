using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    #region Variables

    [SerializeField]
    private SO_Book[] BooksPool = { };

    private BookManager BookMgr;
    private int CurrentBookID = 0;
    private uint Score = 0;

    [SerializeField]
    private GameObject GUIPanel = null;
    [SerializeField]
    private GameObject EndGamePanel = null;
    [SerializeField]
    private UIScore EndGameScore = null;

    #endregion

    #region Properties

    public uint GetScore()
	{
        return Score;
	}

    #endregion

    #region Unity Methods

    // Start is called before the first frame update
    void Start()
    {
        BookMgr = GetComponentInChildren<BookManager>();
        ShuffleBooksPool();
        BookMgr.SetCurrentBook(BooksPool[CurrentBookID]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    #endregion

    #region Methods

    void ShuffleBooksPool()
	{
        for (int i = 0; i < BooksPool.Length; i++)
		{
            SO_Book Temp = BooksPool[i];
            int randomID = Random.Range(i, BooksPool.Length - 1);
            BooksPool[i] = BooksPool[randomID];
            BooksPool[randomID] = Temp;
		}
	}

    public void NextBook()
	{
        if (CurrentBookID > BooksPool.Length - 2)
        {
            EndGame();
            return;
        }

        CurrentBookID++;
        BookMgr.SetCurrentBook(BooksPool[CurrentBookID]);
	}

    public void UpdateScore()
	{
        Score += BookMgr.GetBookScore();
        Debug.Log(Score);
	}

    public void EndGame()
	{
        GUIPanel.SetActive(false);
        EndGamePanel.SetActive(true);
        EndGameScore.UpdateScore();
    }

    public void QuitGame()
	{
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }

    public void LoadLevel(string SceneName)
	{
        SceneManager.LoadScene(SceneName);
	}

    #endregion
}
