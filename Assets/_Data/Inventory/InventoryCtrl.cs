
using System.Collections.Generic;
using UnityEngine;

public abstract class InventoryCtrl : BaseMonoBehaviour
{
    [SerializeField] protected List<ItemInventory> items = new();
}
