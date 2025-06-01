using UnityEngine;

public class ProjectileCtrl : PoolObj
{
    [SerializeField] protected Transform model;
    protected Vector2 direction;
    protected override void LoadComponent()
    {
        base.LoadComponent();
        this.LoadModel();
    }
    protected virtual void LoadModel()
    {
        if (this.model != null) return;
        this.model = transform.Find("Model");
    }
    public void SetDirection(Vector2 dir)
    {
        this.direction = dir.normalized;

        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, angle );
    }
}
