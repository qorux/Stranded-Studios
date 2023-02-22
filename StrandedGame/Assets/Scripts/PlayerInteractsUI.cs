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

   public int hasPlanks = 0;


   private void Start() {
    cam = Camera.main.transform;
   }

    private void Update(){

        RaycastHit hit;
        
        if(Physics.Raycast(cam.position, cam.forward, out hit, 2, itemLayer)){
            if(playerInteracts.GetInteractableObject()!= null && hasPlanks == 3){
            //Show();
            txtInteractionScript.text = $"Hold 'B' to build the boat";
            }
            else{
            //Hide();
            txtInteractionScript.text = $"You need to gather more stuff for the boat to build!";
         }
        }
        else{
            txtInteractionScript.text = string.Empty;
        }
    }
   private void Show(){
    //containerGameObject.SetActive(true);
    
   }

   private void Hide(){
   //containerGameObject.SetActive(false);
   }
}
