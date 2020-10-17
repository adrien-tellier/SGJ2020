using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Book", menuName = "ScriptableObjects/Book", order = 1)]
public class SO_Book : ScriptableObject
{
    #region Variables

    public String Title = "Title";
    public String Author = "Author";
    public String Summary = "Summary";

    [Header("Validation")]

    public SO_Category[] Categories = { null };
    public SO_Color[] Colors = { null };
    public SO_Illustration[] Illustrations = { null };

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
    #endregion
}
