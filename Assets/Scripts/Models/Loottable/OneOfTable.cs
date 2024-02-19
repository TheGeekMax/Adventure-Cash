using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "OneofTable", menuName = "LootTable/OneofTable")]
public class OneofTable : LootTable{
    public List<ElementWeight> list = new List<ElementWeight>();

    public override List<Item> Drop(){
        int totalWeight = 0;

        foreach(ElementWeight elt in list){
            totalWeight += elt.weight;
        }

        int random = Random.Range(0, totalWeight);

        foreach(ElementWeight elt in list){
            random -= elt.weight;
            if(random <= 0){
                return elt.lootTable.Drop();
            }
        }

        return null;
    }
}
