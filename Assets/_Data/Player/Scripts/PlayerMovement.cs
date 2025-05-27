using UnityEngine;

public class PlayerMovement : BaseMonoBehaviour
{

    [SerializeField] protected PlayerCtrl playerCtrl;
    [SerializeField] protected float moveSpeed = 5f;
    protected Vector3 moveInput;
    protected void FixedUpdate()
    {
        this.HandleMoving();
    }
    protected override void LoadComponent()
    {
        base.LoadComponent();
        this.LoadPlayerCtrl();
    }
    protected virtual void LoadPlayerCtrl()
    {
        if (this.playerCtrl != null) return;
        this.playerCtrl = GetComponentInParent<PlayerCtrl>();
    }
    protected virtual void HandleMoving()
    {
        moveInput.x = Input.GetAxis("Horizontal");
        moveInput.y = Input.GetAxis("Vertical");

        transform.parent.position += moveInput * moveSpeed * Time.fixedDeltaTime;
    }
}
