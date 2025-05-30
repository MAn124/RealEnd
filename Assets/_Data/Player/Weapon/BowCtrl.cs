using UnityEngine;

public class BowCtrl : WeaponAbstract
{
    [SerializeField] protected float angleOffset = 0f;
    protected void FixedUpdate()
    {
        this.LookMousePos();
    }
    protected virtual void LookMousePos()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = mousePos - transform.position;

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, angle + angleOffset);
    }
}
