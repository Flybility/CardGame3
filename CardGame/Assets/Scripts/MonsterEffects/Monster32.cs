using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster32 : MonsterBase
{

    // Start is called before the first frame update
    public override void MonsterAttack_end()
    {
        monster = GetComponent<ThisMonster>();
        BattleField.Instance.SummonRandomPos(33);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
