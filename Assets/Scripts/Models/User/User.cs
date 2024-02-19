using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class User{
    private int lifepoint;
    private int maxLifePoint;
    private int magicPoint;
    private int maxMagicPoint;
    private int experience;
    private int maxExperience;
    private int deffensePoint;
    private int money;
    private int level;
    private Chestplate chestplate;
    private Boots boots;
    private Glove glove;
    private MeleeRanged meleeRanged;
    private Magic magic;




    public abstract int attack();
    public abstract int defend(int damage);
    public abstract int used(Usable item);
}
