using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster25 : MonsterBase
{
    public override void MonsterRound_Begin()
    {
        Skills.Instance.ArmoredSelf(monster, 50);
    }
}
