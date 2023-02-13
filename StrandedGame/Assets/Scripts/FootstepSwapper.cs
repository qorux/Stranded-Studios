using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class FootstepSwapper : MonoBehaviour
{
private TerrainChecker checker;
private FirstPersonController fpc;
private string currentLayer;

public FootstepCollection[] terrainFootstepCollections;


    void Start()
    {
        checker = new TerrainChecker();
        fpc = GetComponent<FirstPersonController>();

    }

    public void CheckLayers()
    {
        //raycast down
        RaycastHit hit;
        if(Physics.Raycast(transform.position, Vector3.down, out hit, 3))
        {
            //check if terrain exists
            if(hit.transform.GetComponent<Terrain>()!= null)
            {
                Terrain t = hit.transform.GetComponent<Terrain>();
                //if layer matches our curren layer
                if(currentLayer != checker.GetLayerName(transform.position, t))
                {
                    currentLayer = checker.GetLayerName(transform.position, t);
                }
                //swap footsteps!
                foreach(FootstepCollection collection in terrainFootstepCollections)
                {
                    if(currentLayer == collection.name)
                    {
                        fpc.SwapFootsteps(collection);
                    }
                }
            }
        }
        

    }

}
