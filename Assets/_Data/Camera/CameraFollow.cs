using UnityEngine;

public class CameraFollow : BaseMonoBehaviour
{
    [SerializeField] protected Transform target;
    [SerializeField] protected float camSpeed = 7f;
    protected void FixedUpdate()
    {
        this.CamFollow();
    }
    protected virtual void CamFollow()
    {
        if (this.target == null) return;
        transform.position = Vector3.Lerp(transform.position, this.target.position, camSpeed * Time.deltaTime);
    }
}
