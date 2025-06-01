using UnityEngine;

public class ProjecttileManager : BaseMonoBehaviour
{
    [SerializeField] protected ProjectileSpawner projectileSpawner;
    [SerializeField] protected ProjectilePrefabs projectilePrefabs;

    public ProjectileSpawner ProjectileSpawner => projectileSpawner;
    public ProjectilePrefabs ProjectilePrefabs => projectilePrefabs;
    protected override void LoadComponent()
    {
        base.LoadComponent();
        this.LoadSpawner();
        this.LoadPrefabs();
    }
    protected virtual void LoadSpawner()
    {
        if (this.projectileSpawner != null) return;
        this.projectileSpawner = GetComponentInChildren<ProjectileSpawner>();
    }
    protected virtual void LoadPrefabs()
    {
        if (this.projectilePrefabs != null) return;
        this.projectilePrefabs = GetComponentInChildren<ProjectilePrefabs>();
    }
}
