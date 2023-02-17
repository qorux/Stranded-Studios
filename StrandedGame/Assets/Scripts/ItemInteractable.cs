using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInteractable : MonoBehaviour
{
    public void Interact(){
        Debug.Log("MICHEAL");
        Destroy(gameObject);
    }
}
