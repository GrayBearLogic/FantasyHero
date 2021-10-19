using UnityEngine;

public class ConstantMoveForward : MonoBehaviour
{
    public float speed = 1;
    private void Update()
    {
        transform.Translate(Vector3.forward * (speed * Time.deltaTime));
    }

    #if UNITY_EDITOR
    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawRay(transform.position, transform.forward * 10f);
    }
    #endif
}
