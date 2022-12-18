using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shotcon : MonoBehaviour
{
    public Rigidbody rb;
    bool once;
    void Start()
    {
        //bolet should shut forward 12 speed
        rb.GetComponent<Rigidbody>();
        rb.velocity = transform.forward * 12;
       once = false;
        // destroy object and wiat for 5 sec
        Destroy(gameObject, 5);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")// checks if the tag is enmy 
        {
            
             
            if (once == false)
            {
                int score = PlayerPrefs.GetInt("Score");
                score = score + 10;// on each kill
                PlayerPrefs.SetInt("Score", score);
                once = true;
            }
            Destroy(this.gameObject);

        }

        
    }
}
