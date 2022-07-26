using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster12 : MonsterBase
{
    
    public int value;
    // Start is called before the first frame update
    //死亡时增加下次攻击力
    public override void Start()
    {
        monster = GetComponent<ThisMonster>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnDestroy()
    {
        if (BattleField.Instance.isFinished == false && monster.isSwallowed == false) PlayerData.Instance.StartAddTempAttacks(value);
    }
}
