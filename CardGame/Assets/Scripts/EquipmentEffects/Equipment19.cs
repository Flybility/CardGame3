using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equipment19 : MonoBehaviour
{
    public bool isInEquipment;
    public MouseInteraction mi;
    public int count;//层数
    //public int threshold;//临界值
    // Start is called before the first frame update
    void Start()
    {
        mi = GetComponent<MouseInteraction>();
        isInEquipment = mi.isInEquipment;
        //card = GetComponent<ThisEquiptmentCard>();
        if (isInEquipment)
        {
            PlayerData.Instance.extraRecover = count;
        }
    }
  
    private void OnDestroy()
    {
        if (isInEquipment)
        {
            PlayerData.Instance.extraRecover=0;
        }


    }
}
