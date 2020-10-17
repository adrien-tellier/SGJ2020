using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FrontCover : MonoBehaviour
{
    #region Variables
    
    [SerializeField]
    private Text TitleText = null;
    [SerializeField]
    private Text AuthorText = null;
    
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    #region Methods

    public void ChangeCurrentBook(SO_Book CurrentBook)
    {
        if (CurrentBook == null)
            return;

        TitleText.text = CurrentBook.Title;
        AuthorText.text = CurrentBook.Author;
    }

    #endregion
}
