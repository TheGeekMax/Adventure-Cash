using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Item : ScriptableObject{

    [SerializeField]
    private string idItem;
    [SerializeField]
    private new string name;
    [SerializeField]
    private int sellPrice;
    [SerializeField]
    private bool sellable;
    [SerializeField]
    private Sprite sprite;

    public string IdItem{
        get => idItem;
    }
    public string Name{
        get => name;
    }

    public int SellPrice{
        get => sellPrice;
    }

    public bool Sellable{
        get => sellable;
    }

    public Sprite Sprite{
        get => sprite;
    }
}
