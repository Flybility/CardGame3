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


    public virtual void MonsterChangePosition_Begin()
    {

    }

    public virtual void MonsterChangePosition_Ovrt()
    {

    }
}

