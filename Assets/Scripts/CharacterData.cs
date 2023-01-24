using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public enum StatType { Venom, Bliss, Cyber, Cold, Heart }

public class CharacterData : MonoBehaviour
{
    public GameObject character;
    [SerializeField] Item[] items;
    [SerializeField] StatData[] stats;
    public StatType type;

    //additem
    public void AddItem(Item item)
    {
        //add the item to the array
        //update stat
    }

    //Remove item

    public void RemoveItem()
    {
        //Removes item from array
        //Update stats
    }

    private void UpdateStats()
    {
        //iterate over stats array and set to 0
        for (var i = 0; i<stats.Length; i++) 
        {
            stats[i].value = 0;
        }

        //Iterate over stats array
        //For each character stat update with corresponding item stat
        for (var i = 0; i < stats.Length; i++)
        {
            for (var j = 0; j < items.Length; j++)
            {
                stats[i].value += items[j].GetValue(stats[i].type);
            }
        }
    }
    public void SetStat(StatType type, int value)
    {
        for (var i = 0; i < stats.Length; i++)
        {
            if (stats[i].type == type)
            {
                stats[i].value = value;
                return;
            }
        }
        GetComponent<CharacterController>().UpdateStats();
    }

    internal int GetStat(StatType type)
    {
        for (var i = 0; i < stats.Length; i++)
        {
            if (stats[i].type == type)
            {
                return stats[i].value;
            }
        }
        return -1;
    }
}