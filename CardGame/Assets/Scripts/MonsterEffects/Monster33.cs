using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster33 : MonsterBase
{
    
    public int attackPlusRate;
    // Start is called before the first frame update
    //加入时增加邻位怪兽获取的情绪量
    public override void Start()
    {
        monster = GetComponent<ThisMonster>();
        monster.isAttackPlusbyAmount = true;
        monster.attackPlusRate = attackPlusRate;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
