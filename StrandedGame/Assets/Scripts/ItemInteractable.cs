using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ItemInteractable : MonoBehaviour
{

    public Text objective;
    public void Interact(){
        Debug.Log("MICHEAL");
        objective.text = "Current objective: pick up the shovel";
    }
}
