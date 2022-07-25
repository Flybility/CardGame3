using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster23 : MonsterBase
{
    public override void MonsterRound_Begin()
    {
        Skills.Instance.RecoverBesides(monster.block, 10);
    }
}
