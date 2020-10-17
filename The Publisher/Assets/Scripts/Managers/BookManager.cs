using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class BookManager : MonoBehaviour
{
    #region Variables

    [SerializeField]
    private SO_Book CurrentBook = null;

	    #region Cover

	    [SerializeField]
        private GameObject FrontCover = null;
        [SerializeField]
        private GameObject BackwardCover = null;
        private Image CoverColorImage = null;

    #endregion

    #region PlayerChoice

    [SerializeField]
    private SO_Color SelectedColor = null;
    [SerializeField]
    private SO_Category SelectedCategory = null;

    #endregion

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

		CoverColorImage = GetComponent<Image>();
        CoverColorImage.color = SelectedColor.Color;
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

    public void SetSelectedColor(SO_Color NewColor)
    {
        SelectedColor = NewColor;
        CoverColorImage.color = SelectedColor.Color;
    }

    public void SetSelectedCategory(SO_Category NewCategory)
	{
        SelectedCategory = NewCategory;
	}

    #endregion
}
