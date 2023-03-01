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

   // [SerializeField] TextMeshProUGUI remindme;

    private void Start() {
        cam = Camera.main.transform;
        inventorySystem = GetComponent<InventorySystem>();
    }

    private void Update() {
       
       RaycastHit hit;

     if(Physics.Raycast(cam.position, cam.forward, out hit, 4, itemLayer)){
        //if(hasKey == false)
                        {
            if(!hit.collider.GetComponent<ItemObject>())
                return;
            txt_HovItem.text = $"Press 'E' to {hit.collider.GetComponent<ItemObject>().itemStats.itemName}";
                        }
        //else{
        //    if(!hit.collider.GetComponent<ItemObject>())
        //        return;
       //     txt_HovItem.text = $"You have a key, you can now pick it up {hit.collider.GetComponent<ItemObject>().itemStats.name}";
       // }

    

        if(Input.GetKeyDown(KeyCode.E) )
        {
            inventorySystem.PickUpItem(hit.collider.GetComponent<ItemObject>());
            
        
        }
        
         }
         else{
            txt_HovItem.text = string.Empty;
         }
        }

}
