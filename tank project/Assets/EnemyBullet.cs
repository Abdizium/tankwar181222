using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public Rigidbody rb;
    
    void Start()
    {
        rb.GetComponent<Rigidbody>();
        rb.velocity = transform.forward * 12; // bullet to go forward
    }


}
