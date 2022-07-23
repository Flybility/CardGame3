using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster33 : MonoBehaviour
{
    public ThisMonster monster;
    public int attackPlusRate;
    // Start is called before the first frame update
    //加入时增加邻位怪兽获取的情绪量
    void Start()
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
