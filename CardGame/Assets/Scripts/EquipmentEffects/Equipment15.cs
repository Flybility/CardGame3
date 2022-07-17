using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equipment15 : MonoBehaviour
{
    public bool isInEquipment;
    public MouseInteraction mi;
    public ThisEquiptmentCard card;
    public int count;//层数
    // Start is called before the first frame update
    void Start()
    {
        mi = GetComponent<MouseInteraction>();
        isInEquipment = mi.isInEquipment;
        card = GetComponent<ThisEquiptmentCard>();
        if (isInEquipment)
        {
            PlayerData.Instance.extraMaxHealth = count;
            PlayerData.Instance.currentHealth +=count;//
            PlayerData.Instance.HealthBarChange();
        }
  
    }
    private void OnDestroy()
    {
        if (isInEquipment)
        {
            PlayerData.Instance.extraMaxHealth = 0;
            PlayerData.Instance.currentHealth -= count;
            PlayerData.Instance.HealthBarChange();
        }
        
    }
    private void Update()
    {
        if (mi.isInEquipment==true)
        {

        }
    }
    
}
