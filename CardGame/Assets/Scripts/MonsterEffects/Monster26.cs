using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster26 : MonsterBase
{
    public override void MonsterAttack_end()
    {
        Skills.Instance.ArmoredSelf(monster, 30);
        Skills.Instance.StartExchangeBesidePosition(monster.gameObject);
    }

}
