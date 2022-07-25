using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster21 : MonsterBase
{
    // Start is called before the first frame update
    //死亡时增加下次攻击力
    public override void Start()
    {
        monster = GetComponent<ThisMonster>();
        monster.isAddAward = true;
    }

    // Update is called once per frame
    public override void MonsterAttack_add()
    {
        PlayerData.Instance.AddBondages(1, Skills.Instance.bondageCounter);
    }
}
