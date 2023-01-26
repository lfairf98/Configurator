using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField]
    private Dictionary<StatType, int> stats = new Dictionary<StatType, int>();

    /// <summary>
    /// Takes a stat type and value then iterates through the item's stats array until a stat of the given type is found
    /// </summary>
    /// <param name="type">the stat we want to set</param>
    /// <param name="value">the value we want to set it to</param>
    public void SetStat(StatType type, int value)
    {
        if (stats.ContainsKey(type))
        {
            stats[type] = value;
            GetComponent<CharacterController>().UpdateStats();
            return;
        }
    }

    /// <summary>
    /// Takes a stat type then iterates through the item's stats array until a stat of the given type is found
    /// </summary>
    /// <param name="type">Stat type we are looking for</param>
    /// <returns>Value of the stat or -1 if not found</returns>
    internal int GetStat(StatType type)
    {
        if (stats.ContainsKey(type))
        {
            return stats[type];
        }
        return 0;
    }
}
