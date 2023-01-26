using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CharacterData : MonoBehaviour
{
    public GameObject character;
    //[SerializeField] Item[] items;
    //[SerializeField] StatData[] stats;
    //public StatType type;
    public enum itemType { head, back, body, shoes, face, background, colour };
    public Dictionary<itemType, Item> itemsDict = new Dictionary<itemType, Item>();
    public Dictionary<StatType, int> statsDict = new Dictionary<StatType, int>();

    //additem
    public void AddItem(Item item, itemType type)
    {
        itemsDict[type] = item;
        GetComponent<CharacterController>().UpdateStats();
    }

    public void RemoveItem(Item item, itemType type)
    {
        //Removes item from array
        if(item == itemsDict[type])
        {
            itemsDict.Remove(type);
        }
        GetComponent<CharacterController>().UpdateStats();
    }

    private void UpdateStats()
    {
        //iterate over stats and set to 0
        foreach (KeyValuePair<StatType, int> entry in statsDict)
        {
            statsDict[entry.Key] = 0;
        }

        foreach (KeyValuePair<StatType, int> stat in statsDict)
        {
            foreach (KeyValuePair<itemType, Item> item in itemsDict)
            {
                statsDict[stat.Key] += itemsDict[item.Key].GetStat(stat.Key);
            }
        }
    }

    public void SetStat(StatType type, int value)
    {
        statsDict[type] = value;
        GetComponent<CharacterController>().UpdateStats();
    }

    internal int GetStat(StatType type)
    {
        int value = 0;
        statsDict.TryGetValue(type, out value);
        return value;
    }
}