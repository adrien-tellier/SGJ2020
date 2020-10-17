using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region Variables

    [SerializeField]
    SO_Book[] BooksPool = { };

    BookManager BookMgr;
    int CurrentBookID = 0;
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
            Debug.Log("EndGame");
            return;
        }

        CurrentBookID++;
        BookMgr.SetCurrentBook(BooksPool[CurrentBookID]);
	}

    #endregion
}
