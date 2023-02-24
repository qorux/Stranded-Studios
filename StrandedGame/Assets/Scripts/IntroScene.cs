using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class IntroScene : MonoBehaviour
{
    private TextMeshProUGUI introText;
    // Start is called before the first frame update
    void Start()
    {
        GameObject tempObject = GameObject.Find("IntroText");
        if (tempObject != null)
        {
            introText=tempObject.GetComponent<TextMeshProUGUI>();
        }
        introText.text = "You awake on an island";
        
    }

    // Update is called once per frame
    void Update()
    {
     if (Input.anyKey) 
        {
            introText.text += "<br> It's warm";
        }   
    }
}
