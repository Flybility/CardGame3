using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster26 : MonsterBase
{
    public override void MonsterRound_Begin()
    {
        Skills.Instance.ArmoredSelf(monster, 20);
        Skills.Instance.StartExchangeBesidePosition(monster.gameObject);
    }

}
