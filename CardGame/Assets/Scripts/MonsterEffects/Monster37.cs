using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster37 : MonsterBase
{

   
    public override void MonsterChangePosition_Over(Transform block)
    {
        if (BattleField.Instance.gameState == GameState.玩家回合)
        {
            BattleField.Instance.StartFlyToHand(1);
        }

    }
}