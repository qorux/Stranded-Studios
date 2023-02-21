using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteAppear : MonoBehaviour
{
    public Canvas NoteObject;
    public Canvas InventoryObject;

    // Start is called before the first frame update
    void Start()
    {
        GameObject inventoryTemp = GameObject.Find("InventoryCanvas");
        if (inventoryTemp != null )
        {
            InventoryObject = inventoryTemp.GetComponent<Canvas>();
        }
        NoteObject = GetComponent<Canvas>();
        NoteObject.enabled=false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("n"))
        {
            InventoryObject.enabled=!InventoryObject.enabled;
            NoteObject.enabled = !NoteObject.enabled;
        }
    }
}
