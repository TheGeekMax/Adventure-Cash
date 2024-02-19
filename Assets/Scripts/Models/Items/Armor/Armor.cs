using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armor : Item{

    [SerializeField]
    private int protection;
    [SerializeField]
    private List<ArmorBuff> buffs = new List<ArmorBuff>();
    // Start is called before the first frame update
    public int Protection{
        get => protection;
    }
}
