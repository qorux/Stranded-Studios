using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NoteAppear : MonoBehaviour
{
    public Canvas NoteObject;
    public Canvas InventoryObject;
    private int noteCount = 0;
    public TextMeshProUGUI noteText;

    // Start is called before the first frame update
    void Start()
    {
        GameObject inventoryTemp = GameObject.Find("InventoryCanvas");
        if (inventoryTemp != null )
        {
            InventoryObject = inventoryTemp.GetComponent<Canvas>();
        }
        NoteObject = GetComponent<Canvas>();
        NoteObject.enabled=false;
        GameObject noteTemp = GameObject.Find("Note text");
        if ( noteTemp != null )
        {
            noteText=noteTemp.GetComponent<TextMeshProUGUI>();
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (noteCount==0)
        {
            noteText.text = "I知 sorry I left you here on the island, but I need you to retrieve something for me. Somewhere on the island a very valuable treasure is hidden. I was here many years ago searching for it but could not find it, and now I am too old to do it myself!\r\n\r\nOh and sorry about the broken boat, it was the only one I could spare. There should be some spare parts around the island for you to find. Last time I was here there were some rum smugglers operating on the eastern part of the island, you might find something useful there. (FYI the boat points to the north). I have left some notes around the island that should help you find what you need to. I also left you a shovel that might come in handy.\r\n\r\nGood luck! //X";
        }
        else if (noteCount == 1)
        {
            noteText.text = "I remember burying some supplies next to a stump, if i remember correctly you値l find some rope there to help fix your boat. If you go back to the boat, and find where the path splits, you値l find it in the Y.\r\n\r\n//X";
        }
        else if (noteCount == 2)
        {
            noteText.text = "You will probably need some spare planks in order to fix the boat. If you carry on on the left path, you値l get to the lagoon. Here, the planks can be found where the tall palm trees cross.\r\n\r\n//X";
        }
        if (Input.GetKeyDown("n"))
        {
            InventoryObject.enabled = !InventoryObject.enabled;
            NoteObject.enabled = !NoteObject.enabled;
        }
    }
}
