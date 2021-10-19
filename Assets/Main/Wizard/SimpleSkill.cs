using UnityEngine;

[RequireComponent(typeof(Animator))]
public class SimpleSkill : MonoBehaviour
{
    [SerializeField] private GameObject skill;
    [SerializeField] private Transform point;
    
    private readonly int attackId =
        Animator.StringToHash("attack");

    private Animator ac;

    private void Awake()
    {
        ac = GetComponent<Animator>();
    }

    private void Update()
    {
        
        ac.SetBool(attackId, Input.GetMouseButton(0));
        /*
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(skill, point.position, point.rotation);
            
        }
        */
    }
}
