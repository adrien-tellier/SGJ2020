using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class IllustrationSelector : MonoBehaviour
{
    #region Variables

    [SerializeField]
    private SO_Illustration SelectedIllustration = null;

	#endregion

	#region Unity Methods

	// Start is called before the first frame update
	void Start()
    {
        if (SelectedIllustration == null)
            return;

        GetComponent<Image>().sprite = SelectedIllustration.Sprite;
        if (SelectedIllustration.Sprite == null)
            GetComponent<Image>().color = new Color(0, 0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    #endregion

    #region Methods


    #endregion
}
