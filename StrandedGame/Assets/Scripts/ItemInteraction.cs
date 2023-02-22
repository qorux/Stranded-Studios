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
    public bool hasKey = false;

    private void Start() {
        cam = Camera.main.transform;
        inventorySystem = GetComponent<InventorySystem>();
    }

    private void Update() {
       
       RaycastHit hit;

     if(Physics.Raycast(cam.position, cam.forward, out hit, 2, itemLayer)){
        //if(hasKey == false)
                        {
            if(!hit.collider.GetComponent<ItemObject>())
                return;
            txt_HovItem.text = $"Press 'E' tp pickup {hit.collider.GetComponent<ItemObject>().itemStats.name}!";
                        }
        //else{
        //    if(!hit.collider.GetComponent<ItemObject>())
        //        return;
       //     txt_HovItem.text = $"You have a key, you can now pick it up {hit.collider.GetComponent<ItemObject>().itemStats.name}";
       // }

       
        
        

        if(Input.GetKeyDown(KeyCode.E))
        {
            inventorySystem.PickUpItem(hit.collider.GetComponent<ItemObject>());
            amountOfNotes = amountOfNotes + 1;
        }
        
         }
         else{
            txt_HovItem.text = string.Empty;
         }
        }

}
