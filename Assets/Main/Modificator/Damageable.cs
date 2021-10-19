using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequireComponent(typeof(Rigidbody))]
public class Damageable : MonoBehaviour
{
    public float HP;

    public void GetDamage(float damage)
    {
        HP -= damage;
        if(HP <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Destroy(gameObject);
    }
}
