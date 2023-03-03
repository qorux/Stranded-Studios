using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterCave : MonoBehaviour
{
    public InventorySystem inventorySystem;
    public Slot[] slots;
    private void OnTriggerEnter(Collider other)
    {
        if (slots[5].ItemInSlot != null)
            SceneManager.LoadScene(2);
    }
}
