using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BackwardCover : MonoBehaviour
{
	#region Variables

    [SerializeField]
    private Text TitleText = null;
    [SerializeField]
    private Text AuthorText = null;
    [SerializeField]
    private TextMeshProUGUI SummaryText = null;

	#endregion

	#region Unity Methods

	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    #endregion

    #region Methods

    public void ChangeCurrentBook(SO_Book CurrentBook)
    {
        if (CurrentBook == null)
            return;

        TitleText.text = CurrentBook.Title;
        AuthorText.text = CurrentBook.Author;
        SummaryText.text = CurrentBook.Summary;
    }

    #endregion
}
