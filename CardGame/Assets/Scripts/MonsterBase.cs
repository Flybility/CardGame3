using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterBase : MonoBehaviour
{
    public ThisMonster monster;
    public virtual void Start()
    {
        monster = GetComponent<ThisMonster>();
    }

    public virtual void PlayerRound_Begin()
    {

    }
    public virtual void PlayerRound_Over()
    {

    }

    public virtual void MonsterRound_Begin()
    {

    }
    public virtual void MonsterRound_Over()
    {

    }
    public virtual void MonsterAttack_add()
    {

    }
    public virtual void MonsterAttack_end()
    {

    }
    public virtual void MonsterChangePosition_Begin(Transform block)
    {
        if (block.GetComponent<Blocks>().thornCount > 0)
        {
            monster.HealthDecrease(block.GetComponent<Blocks>().thornCount*4, false, false);
        }
    }

    public virtual void MonsterChangePosition_Over(Transform block)
    {
        if (block.GetComponent<Blocks>().thornCount > 0)
        {
            monster.HealthDecrease(block.GetComponent<Blocks>().thornCount*4, false, false);
        }
        if (block.GetComponent<Blocks>().assimilationCount > 0)
        {
            monster.monsterCard.GetComponent<ThisMonsterCard>().summonTimes--;
            BattleField.Instance.StartMonsterDead(monster.gameObject, monster.monsterCard);

            BattleField.Instance.SummonTargetBlock(42, block);
        }

    }
}

