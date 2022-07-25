using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster16 : MonsterBase
{
    // Start is called before the first frame update
    //死亡时增加下次攻击力
    public override void Start()
    {
        monster = GetComponent<ThisMonster>();
        //monster.isAddScareCount = true;
        monster.isAddAward = true;
    }
    public override void MonsterAttack_add()
    {
        PlayerData.Instance.AddScareCount(BattleField.Instance.monsterInBattle.Count, Skills.Instance.scareCounter);
    }

    // Update is called once per frame

}
