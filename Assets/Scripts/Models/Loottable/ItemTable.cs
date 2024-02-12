using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemTable : LootTable{
    public Item item;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override List<Item> Drop(){
        return item;
    }
}
