using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New item", menuName = "Create New Item")]
[System.Serializable]
public class Items : ScriptableObject
{
    public int id;
    public string itemName;

    [TextArea(3,3)] public string desription;

    public enum Types{
        crafting,
        equip,
        bullshit
    }
    public enum Rarity{
        nonrare, 
        hello
    };

    public GameObject prefab;
    public Texture icon;

    public Types type;
    public Rarity rarity;
    public int maxStack;
    public int weight;
    public int baseValue;

}
