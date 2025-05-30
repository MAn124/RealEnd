
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : BaseSingleton<InventoryManager>
{
    [SerializeField] protected List<InventoryCtrl> inventories = new();
    protected override void LoadComponent()
    {
        base.LoadComponent();
        this.LoadInventoryCtrl();
    }
    protected virtual void LoadInventoryCtrl()
    {
        if (this.inventories.Count > 0) return;
        foreach(Transform child in transform)
        {
            InventoryCtrl inventoryCtrl = GetComponentInChildren<InventoryCtrl>();
            if (inventoryCtrl == null) continue;
            inventories.Add(inventoryCtrl);
        }
    }
}
