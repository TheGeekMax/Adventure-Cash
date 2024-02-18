using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : User{
    private Boolean boss;
    private LootTable drop;

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