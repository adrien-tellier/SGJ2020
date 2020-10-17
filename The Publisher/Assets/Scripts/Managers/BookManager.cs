using System;
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

        [Header("Cover")]

	    [SerializeField]
        private GameObject FrontCover = null;
        [SerializeField]
        private GameObject BackwardCover = null;
        private Image CoverColorImage = null;
        [SerializeField]
        private Image Illustration = null;

        #endregion

        #region PlayerChoice

        [Header("Player Choice")]

        [SerializeField]
        private SO_Category SelectedCategory = null;
        [SerializeField]
        private SO_Color SelectedColor = null;
        [SerializeField]
        private SO_Illustration SelectedIllustration = null;

        [SerializeField]
        private SO_Category DefaultCategory = null;
        [SerializeField]
        private SO_Color DefaultColor = null;
        [SerializeField]
        private SO_Illustration DefaultIllustration = null;

    #endregion

    #region Scores

    [Header("Scores")]

        [Tooltip("Scores according to the number of good answers")]
        [SerializeField]
        private uint[] Scores = { 0, 10, 30, 80 };

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
        Illustration.color = new Color(0, 0, 0, 0);
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

    public void SetSelectedIllustration(SO_Illustration NewIllustration)
	{
        SelectedIllustration = NewIllustration;
        Illustration.sprite = SelectedIllustration.Sprite;
        if (Illustration.sprite == null)
            Illustration.color = new Color(0, 0, 0, 0);
        else
            Illustration.color = new Color(1, 1, 1, 1);
    }

    public uint GetBookScore()
	{
        uint score = 0;
        if (Array.Find(CurrentBook.Categories, element => element == SelectedCategory))
            score++;
        if (Array.Find(CurrentBook.Colors, element => element == SelectedColor))
            score++;
        if (Array.Find(CurrentBook.Illustrations, element => element == SelectedIllustration))
            score++;

        return score;
	}

    public void ResetSelection()
	{
        SetSelectedCategory(DefaultCategory);
        SetSelectedColor(DefaultColor);
        SetSelectedIllustration(DefaultIllustration);
	}

    #endregion
}
