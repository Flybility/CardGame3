using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster27 : MonsterBase
{
    public override void MonsterAttack_end()
    {
        Skills.Instance.StartExchangeIntervalPosition(monster.gameObject);
    }
}
