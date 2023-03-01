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
    public Slot slot;

    [SerializeField] TextMeshProUGUI remindme;

    // Start is called before the first frame update
    void Start()
    {   
        remindme.enabled = false;

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
        GameObject notesInInventory = GameObject.Find("Slot");
        slot=notesInInventory.GetComponent<Slot>();
    }

    // Update is called once per frame
    void Update()
    {

        noteCount = slot.AmountInSlot;
        if (noteCount==55)
        {  
            noteText.text = "I�m sorry I left you here on the island, but I need you to retrieve something for me. Somewhere on the island a very valuable treasure is hidden. I was here many years ago searching for it but could not find it, and now I am too old to do it myself!\r\n\r\nOh and sorry about the broken boat, it was the only one I could spare. There should be some spare parts around the island for you to find. Last time I was here there were some rum smugglers operating on the eastern part of the island, you might find something useful there. (FYI the boat points to the north). I have left some notes around the island that should help you find what you need to. I also left you a shovel that might come in handy.\r\n\r\nGood luck! //X";
        }
        else if (noteCount == 56)
        {
            noteText.text = "I remember burying some supplies next to a stump, if i remember correctly you�ll find some rope there to help fix your boat. If you go back to the boat, and find where the path splits, you�ll find it in the Y.\r\n\r\n//X";
        }
        else if (noteCount == 57)
        {
            
            noteText.text = "You will probably need some spare planks in order to fix the boat. If you carry on on the left path, you�ll get to the lagoon. Here, the planks can be found where the tall palm trees cross.\r\n\r\n//X";
        }
        else if (noteCount==58)
        {
            noteText.text = "Now, you should have everything you need to fix the boat, time to get the treasure!\r\n\r\nLike I said I never did manage to get to the treasure last time I was here� The treasue is said to be deep in the cave, and the key is hidden somewhere on the island. I did find a clue as to where the key is, perhaps you�ll have more luck with it.\r\n\r\nThe clue is as follows:\r\n\r\n�Under the cliff, you�ll find it in a jif\r\n\r\nBy the palm dead, search the white head�";
        }
        if (Input.GetKeyDown("n"))
        {
            InventoryObject.enabled = !InventoryObject.enabled;
            NoteObject.enabled = !NoteObject.enabled;
        }
    }

}
