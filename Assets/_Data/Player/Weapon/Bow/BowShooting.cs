using UnityEngine;

public class BowShooting : BowCtrl
{
    [SerializeField] protected ProjectileCtrl prefabs;
    [SerializeField] protected ProjecttileManager projectTileManager;
    [SerializeField] protected BowCtrl bowCtrl;
    protected void Update()
    {
        this.Shooting();
    }
    protected override void LoadComponent()
    {
        base.LoadComponent();
        this.LoadManager();
        this.LoadBowCtrl();
    }
    protected virtual void LoadManager()
    {
        if (this.projectTileManager != null) return;
        this.projectTileManager = FindAnyObjectByType<ProjecttileManager>();
    }
    protected virtual void LoadBowCtrl()
    {
        if (this.bowCtrl != null) return;
        this.bowCtrl = GetComponentInParent<BowCtrl>();
    }
    protected virtual void Shooting()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Vector2 shootDir = bowCtrl.transform.right;
            AttackPoint attackPoint = this.GetAttackPoint();
          ProjectileCtrl arrow =  this.projectTileManager.ProjectileSpawner.Spawn(prefabs,attackPoint.transform);
          arrow.gameObject.SetActive(true);
            arrow.SetDirection(shootDir);
        }        
    }
    protected virtual AttackPoint GetAttackPoint()
    {
        AttackPoint attackPoint = this.bowCtrl.AttackPoint;
        return attackPoint;
    }
}
