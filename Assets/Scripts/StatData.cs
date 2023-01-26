using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public enum StatType { Venom, Bliss, Cyber, Cold, Heart }

public struct StatData
{
    public int value;
    public StatType type;
}