using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class WeaponBuff{
    public int time;

    public int value;

    public enum weaponBuffType{
        Fire = 1,
        Ice = 2,
        Poison = 3,
        Thunder = 4,
        light = 5,
        Shadow = 6
    }

    public weaponBuffType type;
}
