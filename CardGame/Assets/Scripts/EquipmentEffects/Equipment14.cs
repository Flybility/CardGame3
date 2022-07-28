using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equipment14 : MonoBehaviour
{
    public bool isInEquipment;
    public MouseInteraction mi;
    //public ThisEquiptmentCard card;
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
            PlayerData.Instance.nodeRecoverValue += count;
        }
    }
    private void Update()
    {

    }
    private void OnDestroy()
    {
        if (isInEquipment)
        {
            PlayerData.Instance.nodeRecoverValue -= count;
        }
        

    }
}
