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
        introText.text = "Yesterday you met a strange fellow called mr X at the pub. He seemed nice but a bit suspicious.. You remember him handing you a bottle of rum, but after that your memory fails you.";
        
    }

    // Update is called once per frame
    void Update()
    {
     if (Input.anyKey && !keyPressed) 
        {
            keyPressed= true;
            introText.text += "<br> You now awaken on a desert island, with no clue as to how you got there. There appears to be a broken boat next to you and a note waiting for you…";
        }   
    }
}
