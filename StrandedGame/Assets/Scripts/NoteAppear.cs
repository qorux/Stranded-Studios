using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteAppear : MonoBehaviour
{
    private Canvas CanvasObject;

    // Start is called before the first frame update
    void Start()
    {
        CanvasObject = GetComponent<Canvas>();
        CanvasObject.enabled=false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("n"))
        {
            CanvasObject.enabled = !CanvasObject.enabled;
        }
    }
}
