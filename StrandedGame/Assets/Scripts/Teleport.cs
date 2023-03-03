using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Teleport : MonoBehaviour
{
    public Transform teleportTarget;
    public GameObject thePlayer;
    public Slot[] slots;
    public Text enterText;

    private void OnTriggerEnter(Collider other)
    {
        if (slots[5].ItemInSlot != null)
        {
            thePlayer.transform.position = teleportTarget.transform.position;
        }
        else
        {
            enterText.text = "You can't enter here without a key!";
        }
    }

    private void OnTriggerExit(Collider other)
    {
        enterText.text = string.Empty;
    }
}
