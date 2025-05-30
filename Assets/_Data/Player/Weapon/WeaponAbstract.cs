using UnityEngine;

public class WeaponAbstract : BaseMonoBehaviour
{
    [SerializeField] protected AttackPoint attackPoint;

    public AttackPoint AttackPoint => attackPoint;

    protected override void LoadComponent()
    {
        base.LoadComponent();
        this.LoadAttackPoint();
    }
    protected virtual void LoadAttackPoint()
    {
        if (this.attackPoint != null) return;
        this.attackPoint = GetComponentInChildren<AttackPoint>();
    }
}
