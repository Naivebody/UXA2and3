using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggledButtonText : MonoBehaviour
{
    public GameObject buttonclick;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void ToggledText()
    {
        if (buttonclick.activeSelf)
        {
            buttonclick.SetActive(false);
        }
        else
        {
            buttonclick.SetActive(true);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
