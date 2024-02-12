using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Item{
    private string idItem;
    private string name;

    public string IdItem{
        get => idItem;
    }
    public string Name{
        get => name;
    }
}
