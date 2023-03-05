using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EnterCave : MonoBehaviour
{
    public Text enterText;
    
    private void OnTriggerEnter(Collider other)
    {
        enterText.text = "You cant ent";
    }
}
