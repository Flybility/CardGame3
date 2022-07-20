using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster30 : MonoBehaviour
{
    public ThisMonster monster;
    public int recoverValue;
    // Start is called before the first frame update
    //死亡时增加下次攻击力
    void Start()
    {
        monster = GetComponent<ThisMonster>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnDestroy()
    {
        if (BattleField.Instance.isFinished == false && monster.isSwallowed == false) Skills.Instance.StartRecoverAll(recoverValue);
    }
}

