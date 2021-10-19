using System;
using UnityEngine;

public class Missile : MonoBehaviour
{
    public float speed = 1;
    public float lifetime = 1;
    public GameObject collisionParticles;

    private float time;

    private void Awake()
    {
        Reset();
    }

    private void Update()
    {
        time -= Time.deltaTime;
        if (time <= 0)
        {
            gameObject.SetActive(false);
        }
        
        transform.Translate(Vector3.forward * (speed * Time.deltaTime));
    }

    private void OnTriggerEnter(Collider other)
    {
        //gameObject.SetActive(false);
    }

    public void Reset()
    {
        time = lifetime;
    }
    
#if UNITY_EDITOR
    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawRay(transform.position, transform.forward * 10f);
    }
    #endif
}
