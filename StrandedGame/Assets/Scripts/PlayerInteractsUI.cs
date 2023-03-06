using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerInteractsUI : MonoBehaviour
{
[SerializeField] private PlayerInteracts playerInteracts;
   [SerializeField] TextMeshProUGUI txtInteractionScript;

   Transform cam;
    [SerializeField] LayerMask itemLayer;
    public Slot[] slots;



    InventorySystem inventorysystem; 


   private void Start() {
    cam = Camera.main.transform;
   }

    private void Update(){

        RaycastHit hit;
        
        if(Physics.Raycast(cam.position, cam.forward, out hit, 2, itemLayer)){
            if(playerInteracts.GetInteractableObject()!= null && slots[1].ItemInSlot != null)
                txtInteractionScript.text = $"Hold 'B' to build the boat";

            else{
            txtInteractionScript.text = $"When you have gathered all of the items, press 'B' to build the boat!";
         }
        }
        else{
            txtInteractionScript.text = string.Empty;
        }
    }
}
