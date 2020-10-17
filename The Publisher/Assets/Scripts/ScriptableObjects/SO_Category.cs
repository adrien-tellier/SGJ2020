using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Category", menuName = "ScriptableObjects/Category", order = 3)]
public class SO_Category : ScriptableObject
{
    #region Variables

    public string Name = "Name";
    public string Description = "Description";

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
}
