using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CategorySelector : MonoBehaviour
{
    #region Variables

    [SerializeField]
    private BookManager BookMgr = null;

    [SerializeField]
    private SO_Category SelectedCategory = null;

    [SerializeField]
    private GameObject ScrollView = null;
    [SerializeField]
    private Text SelectedCategoryText = null;
    [SerializeField]
    private TextMeshProUGUI Description = null;

	#endregion

	#region Unity Methods

	// Start is called before the first frame update
	void Start()
    {
        SelectedCategoryText.text = SelectedCategory.Name;
        Description.text = SelectedCategory.Description;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    #endregion

    #region Methods

    public void OpenCloseSelector()
	{
        if (ScrollView.activeSelf)
            ScrollView.SetActive(false);
        else
            ScrollView.SetActive(true);
    }

    public void SetSelected(SO_Category NewCategory)
	{
        SelectedCategory = NewCategory;
        SelectedCategoryText.text = SelectedCategory.Name;
        Description.text = SelectedCategory.Description;
        BookMgr.SetSelectedCategory(SelectedCategory);
    }

    #endregion
}
