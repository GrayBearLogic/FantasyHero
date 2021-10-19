using UnityEngine;

[RequireComponent(typeof(MoveInput))]
public class RotateInMoveDir : MonoBehaviour
{
    private MoveInput mi;

    private void Awake()
    {
        mi = GetComponent<MoveInput>();
    }

    private void Update()
    {
        if (mi.motion.magnitude > 0.2f)
        {
            var target = transform.position + mi.motion.normalized;
            target.y = 0;
            transform.LookAt(target, Vector3.up);
        }
    }
}
