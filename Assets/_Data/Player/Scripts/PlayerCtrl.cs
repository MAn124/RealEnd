using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]
public class PlayerCtrl : BaseMonoBehaviour
{
    [SerializeField] protected PlayerMovement playerMovement;
    [SerializeField] protected Animator animator;

    public Animator Animator => animator;
    protected override void LoadComponent()
    {
        base.LoadComponent();
        this.LoadMovement();
        this.LoadAnimation();
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
}
