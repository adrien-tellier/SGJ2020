using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookManager : MonoBehaviour
{
    #region Variables

    [SerializeField]
    private SO_Book CurrentBook = null;

    [SerializeField]
    private GameObject FrontCover = null;
    [SerializeField]
    private GameObject BackwardCover = null;

    private bool IsFront = true;

    #endregion

    #region Unity Methods

    // Start is called before the first frame update
    void Start()
    {
        if (FrontCover == null || BackwardCover == null)
            return;

        FrontCover.SetActive(IsFront);
        BackwardCover.SetActive(!IsFront);

        FrontCover.GetComponent<FrontCover>().ChangeCurrentBook(CurrentBook);
        BackwardCover.GetComponent<BackwardCover>().ChangeCurrentBook(CurrentBook);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    #endregion

    #region Methods

    public void Flip()
	{
        IsFront = !IsFront;
        FrontCover.SetActive(IsFront);
        BackwardCover.SetActive(!IsFront);
	}

    public void SetCurrentBook(SO_Book NewBook)
	{
        CurrentBook = NewBook;
        FrontCover.GetComponent<FrontCover>().ChangeCurrentBook(CurrentBook);
        BackwardCover.GetComponent<BackwardCover>().ChangeCurrentBook(CurrentBook);
    }

    #endregion
}
