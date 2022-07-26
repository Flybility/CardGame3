using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class Blocks : MonoBehaviour, IPointerClickHandler
{
    public GameObject card;
    public GameObject highLightImage;
    public bool canAddAwards;
    public bool canAddAttacks;
    public float multipleAttacks;
    public float multipleAwards;

    public int thornCount;//荆棘层数
    public int assimilationCount;//同化层数
    public int parasiteCount;//寄生层数

    void Start()
    {
        multipleAttacks = 1;
        multipleAwards = 1;
        highLightImage = transform.GetChild(0).gameObject;
        highLightImage.SetActive(false);
        BattleField.Instance.highlightClear.AddListener(HighlightClear);
        //BattleField.Instance.BattleEnd.AddListener(ClearMonster);
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        if (highLightImage.activeInHierarchy&& eventData.button == PointerEventData.InputButton.Left)
        {
            BattleField.Instance.SummonConfirm(transform, multipleAttacks, multipleAwards);            
        }
        if (eventData.button == PointerEventData.InputButton.Left && BattleField.Instance.exchangeMonster == true && BattleField.Instance.usingEquipment == null && BattleField.Instance.SelectingMonster != 1 && BattleField.Instance.chosenMonster != null)
        {
            BattleField.Instance.SecondBlock(this.transform);
        }
    }

    // Start is called before the first frame update
   public void AddAttack(float count)
    {
        multipleAttacks = count;
    }
    public void AddAwards(float count)
    {
        multipleAwards = count;
    }
    public void HighlightClear()
    {
        highLightImage.SetActive(false);
    }
   //public void ClearMonster()
   //{
   //    if (transform.childCount>1)
   //    {
   //        card = null;
   //        Destroy(transform.GetChild(1));
   //        Destroy(transform.GetChild(2));
   //    }
   //    else return;
   //}

    // Update is called once per frame
    void Update()
    {
        //if (transform.childCount > 1)
        //{
        //    if (transform.GetChild(1).CompareTag("Monster"))
        //    {
        //        Destroy(transform.GetChild(1).gameObject);
        //    }
        //}        
    }
}
