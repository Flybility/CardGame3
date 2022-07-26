using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster28 : MonsterBase
{
    
    // Start is called before the first frame update
    public override void Start()
    {
        monster = GetComponent<ThisMonster>();
        monster.isRoundSwallowBeside = true;
    }
}
