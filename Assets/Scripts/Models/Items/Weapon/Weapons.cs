using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Weapons : Item{
    [SerializeField]
    private int damage;
    [SerializeField]
    private int mp;
    [SerializeField]
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
