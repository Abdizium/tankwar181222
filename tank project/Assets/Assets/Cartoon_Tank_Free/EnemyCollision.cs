using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource deadSound;
    //public AudioClip deadclip;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
       if (other.gameObject.tag == "Bullet")// for enmey tank
        {
            deadSound.Play();// sound playing
            StartCoroutine(killEnemy());
        }
    }

    IEnumerator killEnemy()
    {
        yield return new WaitForSeconds(0.5f);// wait half sec wait
        Destroy(this.gameObject);
    }
}
