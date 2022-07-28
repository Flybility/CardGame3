using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using DG.Tweening;

public class Equipment32 : MonoBehaviour, IPointerClickHandler
{
    public bool isInEquipment;
    public MouseInteraction mi;
    public ThisEquiptmentCard card;


    public void OnPointerClick(PointerEventData eventData)
    {
        if (isInEquipment && eventData.button == PointerEventData.InputButton.Left)
        {
            transform.DOScale(1 / mi.clickSize, 0.1f);
            if (card.summonTimes > 0)
            {
                ClearScare();
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
    public void ClearScare()
    {
        //主动触发装备
        PlayerData.Instance.DecreaseScareCount(PlayerData.Instance.scareCount);
        card.summonTimes--;

    }
}
