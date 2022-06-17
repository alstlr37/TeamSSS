using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField]
    private GameObject go_SlotsParent;

    public Slot[] slots;

    void Awake()
    {
        go_SlotsParent = GameObject.Find("Inventory");
        slots = go_SlotsParent.GetComponentsInChildren<Slot>();
    }
    
    void Start()
    {
        
    }

    public void AcquireItem(Item _item, int _count = 1)
    {
        if(Item.ItemType.Equipment != _item.itemType)
        {
            for(int i = 0; i < slots.Length; i++)
            {
                if(slots[i].item != null)
                {
                    slots[i].SetSlotCount(_count);
                    return;
                }
            }
        }

        for(int i = 0; i < slots.Length; i++)
        {
            if (slots[i].item == null)
            {
                slots[i].AddItem(_item, _count);
                return;
            }
        }
    }
}