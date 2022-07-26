using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster40 : MonsterBase
{
    bool isKilled=true;
    // Start is called before the first frame update
    public override void PlayerRound_Begin()
    {
        isKilled = false;
        monster.monsterCard.GetComponent<ThisMonsterCard>().summonTimes--;
        BattleField.Instance.StartMonsterDead(monster.gameObject, monster.monsterCard);
    }

    // Update is called once per frame
    private void OnDestroy()
    {
        if (BattleField.Instance.isFinished == false&&isKilled)
        {
            PlayerData.Instance.awardMonsterCardAmount += 1;
            PlayerData.Instance.awardEquipCardAmount += 1;
        }
    }
}
