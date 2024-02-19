using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Usable", menuName = "Item/Usable")]
public class Usable : Item{
    [SerializeField]
    private List<UsableBuff> buffs = new List<UsableBuff>();
}
