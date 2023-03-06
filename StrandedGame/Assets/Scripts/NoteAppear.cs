using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NoteAppear : MonoBehaviour
{
    public Canvas NoteObject;
    public Canvas InventoryObject;
    private int noteCount = 0;
    public TextMeshProUGUI noteText;
    public Slot slot;
    public bool noteUpdated;
    public TextMeshProUGUI UpdateNote;
    public bool hasRun;
    public bool hasRun1;
    public bool hasRun2;
    public bool hasRun3;
    public bool hasRun4;
    public Sprite map;

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

        GameObject noteUpdatesTemp = GameObject.Find("reminderText");
        UpdateNote = noteUpdatesTemp.GetComponent<TextMeshProUGUI>();
        UpdateNote.enabled=false;

    }

    // Update is called once per frame
    void Update()
    {

        noteCount = slot.AmountInSlot;
        if (noteCount == 55 && !hasRun)
        {
            noteUpdated= true;
            hasRun=true;
            noteText.text = "Im sorry I left you here on the island, but I need you to retrieve something for me. Somewhere on the island a very valuable treasure is hidden. I was here many years ago searching for it but could not find it, and now I am too old to do it myself!\r\n\r\n There are some spare parts around the island for you to find in order to fix the boat. At each location I have left a note for you, to help you find the next one. I also left you a shovel that might come in handy. \r\n\r\n For your first clue - I remember there were some rum smugglers operating on the eastern part of the island a while back, you might find something useful there. (FYI the boat points to the north).\r\n\r\n Good luck! //X";
        }
        else if (noteCount == 56 && !hasRun1)
        {
            noteUpdated= true;
            hasRun1 = true;
            noteText.text = "I remember burying some supplies next to a stump, if i remember correctly you will find some rope there to help fix your boat. If you go back to the boat, and find where the path splits, you will find it in the Y.\r\n\r\n//X";
        }
        else if (noteCount == 57 && !hasRun2)
        {
            noteUpdated= true;
            hasRun2 = true;
            noteText.text = "You will probably need some spare planks in order to fix the boat. If you carry on on the western path, you will get to the lagoon. Here, the planks can be found where the tall palm trees cross.\r\n\r\n//X";
        }
        else if (noteCount == 58 && !hasRun3)
        {
            noteUpdated = true;
            hasRun3 = true;
            noteText.text = "Now, you should have everything you need to fix the boat, time to get the treasure!\r\n\r\nLike I said I never did manage to get to the treasure last time I was here. The treasue is said to be deep in the cave, and the key is hidden somewhere on the island. I did find a clue as to where the key is, perhaps you will have more luck with it.\r\n\r\nThe clue is as follows:\r\n\r\n Under the cliff, you will find it in a jif\r\n\r\nBy the palm dead, search the white head";
        }
        else if (noteCount == 59 && !hasRun4)
        {
            noteUpdated = true;
            hasRun4 = true;
            noteText.text = " ";
            NoteObject.GetComponent<Image>().sprite = map;

        }
        if (Input.GetKeyDown("n"))
        {
            InventoryObject.enabled = !InventoryObject.enabled;
            NoteObject.enabled = !NoteObject.enabled;
            noteUpdated = false;
            UpdateNote.enabled = false;
        }
        if (noteUpdated) 
        {
            UpdateNote.enabled = true;
        }
    }

}
