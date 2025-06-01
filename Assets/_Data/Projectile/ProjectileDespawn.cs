using UnityEngine;

public class ProjectileDespawn : Despawn<ProjectileCtrl>
{
    [SerializeField] protected bool isDespawn = false;

    protected new virtual void FixedUpdate()
    {
        this.CheckDespawn();
    }
    protected virtual void CheckDespawn()
    {
        if (!isDespawn) return;
        this.spawner.Despawn(transform.parent);
    }
}
