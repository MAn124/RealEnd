using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]
public class PlayerCtrl : BaseMonoBehaviour
{
    [SerializeField] protected PlayerMovement playerMovement;
    [SerializeField] protected Animator animator;
    [SerializeField] protected Transform model;
    [SerializeField] protected PlayerShooting shooting;
    [SerializeField] protected Transform weapon;
    public Animator Animator => animator;
    protected override void LoadComponent()
    {
        base.LoadComponent();
        this.LoadMovement();
        this.LoadAnimation();
        this.LoadModel();
        this.LoadShooting();
        this.LoadWeapon();
    }
    protected virtual void LoadMovement()
    {
        if (playerMovement != null) return;
        this.playerMovement = GetComponentInChildren<PlayerMovement>();
    }
    protected virtual void LoadAnimation()
    {
        if (this.animator != null) return;
        this.animator = GetComponent<Animator>();
    }
    protected virtual void LoadModel()
    {
        if (this.weapon != null) return; 
        this.weapon = transform.Find("Weapon");
    }
    protected virtual void LoadShooting() { 
        if (this.shooting != null) return;
        this.shooting = GetComponentInChildren<PlayerShooting>();
    }
    protected virtual void LoadWeapon()
    {
        if (this.model != null) return;
        this.model = transform.Find("Model");
    }
}
