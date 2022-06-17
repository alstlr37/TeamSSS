﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Item", menuName = "New Item/item")]
public class Item : ScriptableObject
{
    public enum ItemType
    {
        Equipment,
        Posion,
        QuestItem,
        ETC,
    }

    public string itemName; // 아이템 이름
    public ItemType itemType; // 아이템 유형
    public Sprite itemImage; // 아이템 이미지
    public GameObject itemPrefab; // 아이템 프리팹

    public string weaponType; // 무기 유형
}
