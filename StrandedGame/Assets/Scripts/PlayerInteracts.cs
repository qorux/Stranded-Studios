using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInteracts : MonoBehaviour
{

    private void Update()
    {

        if(Input.GetKeyDown(KeyCode.E)){
        float interactRange = 2f;
        Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactRange); 
        foreach(Collider collider in colliderArray){
            if(collider.TryGetComponent(out ItemInteractable itemInteractable)){
                itemInteractable.Interact();
              
            }
        }
        }
        
    }

    public ItemInteractable GetInteractableObject()
    {
        float interactRange = 2f;
        Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactRange); 
        foreach(Collider collider in colliderArray){
            if(collider.TryGetComponent(out ItemInteractable itemInteractable)){
                return itemInteractable;
            }
        }
        return null;
    }
}
