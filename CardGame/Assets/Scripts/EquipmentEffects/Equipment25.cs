using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equipment25 : MonoBehaviour
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
            PlayerData.Instance.slayAddAnger = true;
        }
    }

    private void OnDestroy()
    {
        if (isInEquipment)
        {
            PlayerData.Instance.slayAddAnger = false;
        }


    }
}
