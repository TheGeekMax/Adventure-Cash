using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ArmorBuff{
    public int value;
    public enum ArmorBuffType{
        Life = 1,
        Mp = 2,
        Damage = 3
    }
    public ArmorBuffType type;
}
