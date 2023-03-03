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
    public int noteCount = 0;
   

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
        noteCount = slots[0].AmountInSlot;
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
     
            if (slots[6].ItemInSlot != null)
            {
            if (Input.GetKeyDown(KeyCode.B))
            {

                //kolla om player byggt båten
                SceneManager.LoadScene(4);
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
            }
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
            objective.text = "Current objective: Fix the boat and escape the island";
            if (Physics.Raycast(cam.position, cam.forward, out hit, 4, itemLayer))
            {
                if (hit.collider.GetComponent<ItemObject>().tag != "Win")
                {
                    pickUpScript.text = "You should pick up something else first...";
                }
            }
        }
        else if (slots[5].ItemInSlot != null) //nyckel
        {
            objective.text = "Current objective: Find the treasure in the cave";
            if (Physics.Raycast(cam.position, cam.forward, out hit, 4, itemLayer))
            {
                if (hit.collider.GetComponent<ItemObject>().tag != "Treasure")
                {
                    pickUpScript.text = "You should pick up something else first...";
                }
            }
        }
        else if (slots[4].ItemInSlot != null && noteCount >= 58) //plankor
        {
            objective.text = "Current objective: Find the key by the dead palm tree";
            if (Physics.Raycast(cam.position, cam.forward, out hit, 4, itemLayer))
            {
                if (hit.collider.GetComponent<ItemObject>().tag != "Key")
                {
                    pickUpScript.text = "You should pick up something else first...";
                }
            }
        }
        else if (slots[3].ItemInSlot != null && noteCount >= 57) //rep
        {
            objective.text = "Current objective: Find the tall palm trees that cross";
            if (Physics.Raycast(cam.position, cam.forward, out hit, 4, itemLayer))
            {
                if (hit.collider.GetComponent<ItemObject>().tag != "Planks")
                {
                    pickUpScript.text = "You should pick up something else first...";
                }
            }
        }
        else if (slots[2].ItemInSlot != null &&  noteCount >= 56) //segel
        {
            objective.text = "Current objective: Find the stump and dig up the rope";
            if (Physics.Raycast(cam.position, cam.forward, out hit, 4, itemLayer))
            {
                if (hit.collider.GetComponent<ItemObject>().tag != "Rope")
                {
                    pickUpScript.text = "You should pick up something else first...";
                }
            }
        }
        else if (slots[1].ItemInSlot != null) //spade
        {
            objective.text = "Current objective: Find the smugglers base";
            if (Physics.Raycast(cam.position, cam.forward, out hit, 4, itemLayer))
            {
                if (hit.collider.GetComponent<ItemObject>().tag != "Sails")
                {
                    pickUpScript.text = "You should pick up something else first...";
                }
            }
        }
        else if (slots[0].ItemInSlot != null) //notes
        {
            objective.text = "Current objective: Pick up the shovel";
            if (Physics.Raycast(cam.position, cam.forward, out hit, 4, itemLayer))
            {
                if (hit.collider.GetComponent<ItemObject>().tag != "Shovel")
                {
                    pickUpScript.text = "You should pick up something else first...";
                }
            }

        }      
    }
}
        


