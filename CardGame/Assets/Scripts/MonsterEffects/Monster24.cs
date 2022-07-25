using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster24 : MonsterBase
{
    public override void MonsterRound_Begin()
    {
        Skills.Instance.ArmoredBesides(monster.block, 20);
    }
}
