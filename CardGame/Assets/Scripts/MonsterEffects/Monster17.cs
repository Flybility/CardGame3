using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster17 : MonsterBase
{
    //public int attackAttachedScareCount;//攻击附加恐惧层数
    // Start is called before the first frame update
    //死亡时增加下次攻击力
    public override void Start()
    {
        monster = GetComponent<ThisMonster>();
        //monster.attackAttachedScare = attackAttachedScareCount;
        monster.isAddAward = true;
    }

    public override void MonsterAttack_add()
    {
        PlayerData.Instance.AddScareCount(2, Skills.Instance.scareCounter);
    }

}
