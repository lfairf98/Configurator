using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] StatData[] stats;
    public StatType type;

    enum itemType { head, back, body, shoes, face, background, colour };

    /// <summary>
    /// Takes a stat type and value then iterates through the item's stats array until a stat of the given type is found
    /// </summary>
    /// <param name="type">the stat we want to set</param>
    /// <param name="value">the value we want to set it to</param>
    public void SetStat(StatType type, int value)
    {
        for (var i = 0; i < stats.Length; i++)
        {
            if(stats[i].type == type)
            {
                stats[i].value = value;
                return;
            }
        }
        GetComponent<CharacterController>().UpdateStats();
    }

    /// <summary>
    /// Takes a stat type then iterates through the item's stats array until a stat of the given type is found
    /// </summary>
    /// <param name="type">Stat type we are looking for</param>
    /// <returns>Value of the stat or -1 if not found</returns>
    internal int GetValue(StatType type)
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
