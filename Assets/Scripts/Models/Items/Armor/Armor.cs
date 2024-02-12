using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armor{
    private int protection;
    private List<ArmorBuff> buffs = new List<ArmorBuff>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public int Protection{
        get => protection;
    }
}
