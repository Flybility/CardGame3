using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster37 : MonsterBase
{
    [Range(0, 1)] public float drawCardProbability;

    public override void MonsterRound_Begin()
    {
        float random = Random.Range(0f, 1f);
        if(random < drawCardProbability)
        {
            BattleField.Instance.StartFlyToHand(1);
            monster.isRoundExchangeBeside = false;
        }
        else
        {
            monster.isRoundExchangeBeside = true;
        }
    }
}