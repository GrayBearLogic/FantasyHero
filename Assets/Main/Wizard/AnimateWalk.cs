using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(MoveInput))]
public class AnimateWalk : MonoBehaviour
{
    private MoveInput mi;
    private Animator ac;
    
    private readonly int xId =
        Animator.StringToHash("speedX");

    private readonly int yId =
        Animator.StringToHash("speedY");

    
    private void Awake()
    {
        mi = GetComponent<MoveInput>();
        ac = GetComponent<Animator>();
    }

    private void Update()
    {
        var local = transform.worldToLocalMatrix *
                    new Vector3(mi.motion.x, 0, mi.motion.z);
        
        ac.SetFloat(xId, local.x);
        ac.SetFloat(yId, local.z);
    }
}
