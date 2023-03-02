using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class InventorySystem : MonoBehaviour
{
    public Text objective;
    [SerializeField] public Slot[] slots = new Slot[40];
    [SerializeField] GameObject InventoryUI;
    [SerializeField] TextMeshProUGUI pickUpScript;

    Transform cam;

    [SerializeField] LayerMask itemLayer;

    private void Awake() {


        for (int i = 0; i < slots.Length; i++)
        {
            if(slots[i].ItemInSlot == null)
            {
                for (int k = 0; k < slots[i].transform.childCount; k++)
                {
                    slots[i].transform.GetChild(k).gameObject.SetActive(false);
                }
            }
        }
    }

    private void Update() {
        //InventoryUI.SetActive(true);
        cam = Camera.main.transform;
        WinGame();
        pickUpScript.text = string.Empty;
        progress();
    }

    public void PickUpItem(ItemObject obj){

        for (int i = 0; i < slots.Length; i++)
        {
            if(slots[i].ItemInSlot != null && slots[i].ItemInSlot.id == obj.itemStats.id && slots[i].AmountInSlot != slots[i].ItemInSlot.maxStack)
            {
                if(!WillHitMaxStack(i, obj.amount))
                {
                    slots[i].AmountInSlot += obj.amount;
                    Destroy(obj.gameObject);
                    slots[i].SetStats();
                    return;
                }
                else
                {
                    int result = NeedToFill(i);
                    obj.amount = RemainingAmount(i, obj.amount);
                    slots[i].AmountInSlot += result;
                    PickUpItem(obj);
                    return;
                }
            }
            else if(slots[i].ItemInSlot == null)
            {
                slots[i].ItemInSlot = obj.itemStats;
                slots[i].AmountInSlot += obj.amount;
                Destroy(obj.gameObject);
                slots[i].SetStats();
                return;
            }
        }
    }

    public void WinGame() { 
     
            if (slots[5].ItemInSlot != null)
            {
                //kolla om player byggt båten
                SceneManager.LoadScene(4);
            }
    }

    bool WillHitMaxStack(int index, int amount)
    {
        if(slots[index].ItemInSlot.maxStack <= slots[index].AmountInSlot + amount)
            return true;
        else
            return false;
    }

    int NeedToFill(int index)
    {
        return slots[index].ItemInSlot.maxStack - slots[index].AmountInSlot;
    }

    int RemainingAmount(int index, int amount)
    {
        return (slots[index].AmountInSlot + amount) - slots[index].ItemInSlot.maxStack;
    }

    public void progress()
    {
        RaycastHit hit;

        if (slots[6].ItemInSlot != null) //skatt
        {
            //du får lov att laga båten
        }
        else if (slots[5].ItemInSlot != null) //nyckel
        {
            //du får lov att hitta skatten
        }
        else if (slots[4].ItemInSlot != null) //plankor
        {
            //du får hämta nyckeln
        }
        else if (slots[3].ItemInSlot != null) //rep
        {
            //du får hämta plankor
        }
        else if (slots[2].ItemInSlot != null) //segel
        {
            //du får hömta rep
        }
        else if (slots[1].ItemInSlot != null) //spade
        {
            //du får hämta segel
            Debug.Log("AIDS 2");
        }
        else if (slots[0].ItemInSlot != null) //notes
        {
            objective.text = "Current objective: Pick up the shovel";
            if (Physics.Raycast(cam.position, cam.forward, out hit, 4, itemLayer))
            {
                //if gametag == shovel, spaden är interagerbar
                //else alla andra items visar du måste plocka upp nått annat först
                if (hit.collider.GetComponent<ItemObject>().tag != "Shovel")
                {
                    pickUpScript.text = "You should pick up something else first...";
                    //interactable
                }
            }
            
        }
                
    }
}
        


