using System;
using UnityEngine;

public class PlayerMovement : BaseMonoBehaviour
{

    [SerializeField] protected PlayerCtrl playerCtrl;
    [SerializeField] protected float moveSpeed = 5f;
    protected Vector3 moveInput;
    protected bool isMoving = false;
    [SerializeField] protected SpriteRenderer spriteRenderer;
    protected void FixedUpdate()
    {
        this.HandleMoving();
        this.LookMousePos();
    }
    protected override void LoadComponent()
    {
        base.LoadComponent();
        this.LoadPlayerCtrl();
        this.LoadSprite();
    }
    protected virtual void LoadPlayerCtrl()
    {
        if (this.playerCtrl != null) return;
        this.playerCtrl = GetComponentInParent<PlayerCtrl>();
    }
    protected virtual void LoadSprite()
    {
        if(this.spriteRenderer != null) return;
        this.spriteRenderer = transform.parent.GetComponentInChildren<SpriteRenderer>();
    }
    protected virtual void HandleMoving()
    {
        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.y = Input.GetAxisRaw("Vertical");
        transform.parent.position += moveSpeed * Time.fixedDeltaTime * moveInput;
        if (moveInput.sqrMagnitude > 0.01f) {
            this.isMoving = true;
            this.playerCtrl.Animator.SetBool("isMoving", isMoving); }
        else {
            this.isMoving = false;
            this.playerCtrl.Animator.SetBool("isMoving", isMoving); }
    }
    protected virtual void LookMousePos()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Debug.Log("mousePos: " + mousePos);
        if(mousePos.x < transform.position.x) spriteRenderer.flipX = false;
        else spriteRenderer.flipX = true;
    }
}
