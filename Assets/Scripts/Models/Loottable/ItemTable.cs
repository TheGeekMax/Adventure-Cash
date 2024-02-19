using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "ItemTable", menuName = "LootTable/ItemTable")]
public class ItemTable : LootTable{
    public Item item;

    public override List<Item> Drop(){
        return new List<Item>(){item};
    }
}
