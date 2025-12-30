using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public List<ItemInstance> inventoryItems;
    public ItemInstance inHandItem;

    private void Start()
    {
        inHandItem = inventoryItems[0];

        InitiateItems();
        UIManager.Instance.UpdateCurrentInHandUI(inHandItem);
    }

    void Equip()
    {

    }

    void InitiateItems()
    {
        foreach (var item in inventoryItems)
        {
            item.InitCharges();
        }
    }
}
