using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class CanvasScript : MonoBehaviour 
{
 [SerializeField] TextMeshProUGUI remindme;
   void Start () 
   {
      Invoke("DisableText", 5f);//invoke after 5 seconds
   }
   void DisableText()
   { 
      remindme.enabled = false; 
   }    
}