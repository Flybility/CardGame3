using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Monster6 : MonsterBase
{
    public int boomDamage;
    // Start is called before the first frame update
    public override void Start()//怪物上场时调用技能函数
    {
        monster = GetComponent<ThisMonster>();
        monster.isBoom = true;
        GameObject boomCounter = Instantiate(Skills.Instance.boomCounter, monster.stateBlock);
        boomCounter.transform.GetChild(0).GetChild(0).GetComponent<Text>().text = boomDamage.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnDestroy()
    {
        if(BattleField.Instance.isFinished == false && monster.isSwallowed == false) Skills.Instance.StartBoomAll(boomDamage);
    }
}
