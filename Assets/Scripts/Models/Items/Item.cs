using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Item{
    private string idItem;
    private string name;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public string IdItem{
        get => idItem;
    }
    public string Name{
        get => name;
    }

}
