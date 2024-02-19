using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class LootTable : ScriptableObject{
    public abstract List<Item> Drop();
}
