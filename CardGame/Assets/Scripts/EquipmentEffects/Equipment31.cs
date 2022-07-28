using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using DG.Tweening;

public class Equipment31 : MonoBehaviour,IPointerClickHandler
{
    public bool isInEquipment;
    public int armorBase;
    public MouseInteraction mi;
    public ThisEquiptmentCard card;


    public void OnPointerClick(PointerEventData eventData)
    {
        if (isInEquipment && eventData.button == PointerEventData.InputButton.Left)
        {
            transform.DOScale(1 / mi.clickSize, 0.1f);
            if (card.summonTimes > 0)
            {
                Debug.Log("clear");
                ArmorAddByScare();
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        mi = GetComponent<MouseInteraction>();
        isInEquipment = mi.isInEquipment;
        card = GetComponent<ThisEquiptmentCard>();
    }
    public void ArmorAddByScare()
    {
        //主动触发装备
        Skills.Instance.AddArmorToPlayer(armorBase*PlayerData.Instance.scareCount);
        card.summonTimes--;

    }
}
