using System.Collections.Generic;
using UnityEngine;

public class Weapon : BaseMonoBehaviour
{
    [SerializeField] protected List<WeaponAbstract> weapons;
    protected override void LoadComponent()
    {
        base.LoadComponent();
        this.LoadWeaponAbstract();
    }
    protected virtual void LoadWeaponAbstract()
    {
        if (this.weapons.Count > 0) return;
        foreach (Transform child in transform)
        {
            WeaponAbstract weapon = GetComponentInChildren<WeaponAbstract>();
            if (weapon == null) continue;
            weapons.Add(weapon);
        }
    }
}
