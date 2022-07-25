using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster18 : MonsterBase
{
    //public int attackAttachedScareCount;//攻击附加恐惧层数
    // Start is called before the first frame update
    public override void Start()
    {
        monster = GetComponent<ThisMonster>();
        Instantiate(Skills.Instance.intangibleCounter, monster.stateBlock);
        //monster.attackAttachedScare = attackAttachedScareCount;
        monster.isIntangible = true;
        monster.isAddAward = true;
    }

    // Update is called once per frame
    public override void MonsterAttack_add()
    {
        PlayerData.Instance.AddScareCount(1, Skills.Instance.scareCounter);
    }
}
