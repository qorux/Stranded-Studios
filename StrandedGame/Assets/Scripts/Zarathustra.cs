using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Zarathustra : MonoBehaviour
{
    private GameStateManager gsm;
    public ParticleSystem current;
    public ParticleSystem next;
    public Text textOutput;
    void Start()
    {
        GameObject gob;
        gob = GameObject.Find("GameState");
        gsm = gob.GetComponent<GameStateManager>();
    }
    void OnTriggerEnter(Collider ent)
    {
        if (current.isPlaying == true)
        {
            gsm.setAtObelisk(true);
            current.Stop();
            if (next != null)
            {
                next.Play();
                textOutput.text = "Quickly!  Hit " + gsm.queryTargetNum() + "!";
            }
        }
        else
        {
            gsm.setAtObelisk(false);
        }
    }
    void OnTriggerExit(Collider ext)
    {
        gsm.setAtObelisk(false);
    }
}