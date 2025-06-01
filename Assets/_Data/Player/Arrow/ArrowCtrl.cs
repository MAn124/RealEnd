using UnityEngine;

public class ArrowCtrl : ProjectileCtrl
{
    [SerializeField] protected float flySpeed = 10f;
    
    protected void Update()
    {
        transform.position += (Vector3)(direction * flySpeed * Time.deltaTime);
    }

}
