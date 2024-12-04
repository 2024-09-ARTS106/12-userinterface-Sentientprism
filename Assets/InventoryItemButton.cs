using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InventoryItemButton : MonoBehaviour
{
    private Text buttontext;
    private string[] itemTypes = { "Armor", "Weapon", "Spell" };
    public int typeIndex;
    // Start is called before the first frame update
    void Awake()
    {
        typeIndex = Random.Range(0, 3);
        buttontext = GetComponentInChildren<Text>();
        buttontext.text = itemTypes[typeIndex];
    }
}
