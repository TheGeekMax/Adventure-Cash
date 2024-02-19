using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class User : ScriptableObject{
    [SerializeField]
    private int lifepoint;
    [SerializeField]
    private int maxLifePoint;
    [SerializeField]
    private int magicPoint;
    [SerializeField]
    private int maxMagicPoint;
    [SerializeField]
    private int experience;
    [SerializeField]
    private int maxExperience;
    [SerializeField]
    private int deffensePoint;
    [SerializeField]
    private int money;
    [SerializeField]
    private int level;
    [SerializeField]
    private Chestplate chestplate;
    [SerializeField]
    private Boots boots;
    [SerializeField]
    private Glove glove;
    [SerializeField]
    private MeleeRanged meleeRanged;
    [SerializeField]
    private Magic magic;

    public abstract int attack();
    public abstract int defend(int damage);
    public abstract int used(Usable item);
}
