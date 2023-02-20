using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ItemInteraction : MonoBehaviour
{
    Transform cam;
    [SerializeField] LayerMask itemLayer;
    
    InventorySystem inventorySystem;

    [SerializeField] TextMeshProUGUI txt_HovItem;

    public int amountOfNotes = 0;

    private void Start() {
        cam = Camera.main.transform;
        inventorySystem = GetComponent<InventorySystem>();
    }

    private void Update() {
       
       RaycastHit hit;

     if(Physics.Raycast(cam.position, cam.forward, out hit, 2, itemLayer))
      
        if(Input.GetKeyDown(KeyCode.E))
        {
            inventorySystem.PickUpItem(hit.collider.GetComponent<ItemObject>());
            amountOfNotes = amountOfNotes + 1;
        }
        
       

        }

}
