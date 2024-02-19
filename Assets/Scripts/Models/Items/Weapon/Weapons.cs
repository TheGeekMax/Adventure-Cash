using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Weapons{
    private int damage;
    private int mp;
    private List<WeaponBuff> buffs = new List<WeaponBuff>();
    public int Damage{
        get => damage;
    }
    public int Mp{
        get => mp;
    }
    public List<WeaponBuff> Buffs{
        get => buffs;
    }
}
