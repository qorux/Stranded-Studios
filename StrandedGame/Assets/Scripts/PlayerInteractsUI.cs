using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractsUI : MonoBehaviour
{
[SerializeField] private PlayerInteracts playerInteracts;
   [SerializeField] private GameObject containerGameObject;

    private void Update(){
        if(playerInteracts.GetInteractableObject()!= null){
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
