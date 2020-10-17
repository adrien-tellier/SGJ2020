using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Color", menuName = "ScriptableObjects/Color", order = 2)]
public class SO_Color : ScriptableObject
{
    #region Variables

    public Color Color = new Color(1, 1, 1, 1);

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
