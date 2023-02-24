using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class IntroScene : MonoBehaviour
{
    private bool keyPressed;
    private TextMeshProUGUI introText;
    // Start is called before the first frame update
    void Start()
    {
        GameObject tempObject = GameObject.Find("IntroText");
        if (tempObject != null)
        {
            introText=tempObject.GetComponent<TextMeshProUGUI>();
        }
        introText.text = "...You open your eyes and find yourself laying on a beach.";
        
    }

    // Update is called once per frame
    void Update()
    {
     if (Input.anyKey && !keyPressed) 
        {
            keyPressed= true;
            introText.text += "<br> You can’t remember how you got here but you see what you think is parts of your trusty ship laying on the beach. <br> Still dazed and trying to remember how you ended up here, maybe it's a good idea to take a look around...";
        }   
    }
}
