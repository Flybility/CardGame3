using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster39 : MonsterBase
{

    public override void MonsterRound_Begin()
    {
        int addArmor = 20 *(BattleField.Instance.monsterInBattle.Count - 1);
        monster.AddArmor(addArmor,Skills.Instance.armorCounter);
        //Debug.Log("Ìí¼Ó»¤¼×" + addArmor);
    }
}
