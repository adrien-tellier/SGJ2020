using System.Collections;
using System.Collections.Generic;
using TMPro.Examples;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class ColorSelector : MonoBehaviour
{
    [SerializeField]
    private SO_Color Color = null;

    // Start is called before the first frame update
    void Start()
    {
        if (Color == null)
            return;

        GetComponent<Image>().color = Color.Color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
