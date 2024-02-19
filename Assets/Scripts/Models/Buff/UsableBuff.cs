using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class UsableBuff{

    public int time;

    public int value;

    public enum UsableBuffType{
        Life = 1,
        Mp = 2,
        Damage = 3
    }

    public UsableBuffType type;
}
