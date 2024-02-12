using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class LootTable{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public abstract List<Item> Drop();
    public LootTable(){}
}
