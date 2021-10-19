using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class MoveInput : MonoBehaviour
{
    [SerializeField] private float speed = 1f;
    private CharacterController cc;
    [HideInInspector] public Vector3 motion;

    private Vector3 rootMotion;
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        cc = GetComponent<CharacterController>();
    }

    private void Update()
    {
        var dx = Input.GetAxis("Horizontal");
        var dz = Input.GetAxis("Vertical");

        motion = new Vector3(dx, 0, dz);
        if (motion.magnitude > 1)
            motion.Normalize();


        //cc.Move(motion * (speed * Time.deltaTime));
    }
    private void OnAnimatorMove()
    {
        rootMotion += animator.deltaPosition;
    }
    void FixedUpdate()
    {
        cc.Move(rootMotion);
        rootMotion = Vector3.zero;
    }
}
