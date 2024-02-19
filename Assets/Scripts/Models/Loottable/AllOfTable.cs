using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "AllOfTable", menuName = "LootTable/AllOfTable")]
public class AllOfTable : LootTable{
    public List<LootTable> list = new List<LootTable>();

    public override List<Item> Drop(){
        List<Item> newList = new List<Item>();

        foreach(LootTable current in list){
            newList.AddRange(current.Drop());
        }

        return newList;
    }
}
