using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster31 : MonsterBase
{
    public override void PlayerRound_Begin()
    {
        int extralCardDrawing = 6 - BattleField.Instance.monsterInBattle.Count;
        PlayerData.Instance.tempExtraCardMax += extralCardDrawing;
        //Debug.Log("∂‡≥È»°"+ extralCardDrawing.ToString() + "’≈ø®≈∆");
    }
}
