using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equipment21 : MonoBehaviour
{
    public bool isInEquipment;
    public MouseInteraction mi;
    
    // Start is called before the first frame update
    void Start()
    {
        mi = GetComponent<MouseInteraction>();
        isInEquipment = mi.isInEquipment;
        //card = GetComponent<ThisEquiptmentCard>();
        if (isInEquipment)
        {
            PlayerData.Instance.isArmorClear = false;
        }
    }

    private void OnDestroy()
    {
        if (isInEquipment)
        {
            PlayerData.Instance.isArmorClear = true;
        }


    }
}
