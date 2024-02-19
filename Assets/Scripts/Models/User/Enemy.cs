using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Enemy", menuName = "User/Enemy")]
public class Enemy : User{
    [SerializeField]
    private Boolean boss;
    [SerializeField]
    private LootTable drop;
    [SerializeField]
    private Sprite sprite;

    public override int attack(){
        return 0;
    }
    public override int defend(int damage){
        return 0;
    }
    public override int used(Usable item){
        return 0;
    }
}