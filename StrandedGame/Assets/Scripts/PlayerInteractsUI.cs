using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractsUI : MonoBehaviour
{
[SerializeField] private PlayerInteracts playerInteracts;
   [SerializeField] private GameObject containerGameObject;

   public bool hasKey = false;

    private void Update(){
        if(playerInteracts.GetInteractableObject()!= null && hasKey){
            Show();
        }
        else{
            Hide();
        }
    }
   private void Show(){
    containerGameObject.SetActive(true);
    
   }

   private void Hide(){
    containerGameObject.SetActive(false);
   }
}
