using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class hero : MonoBehaviour
{
   // the shot
   public Transform cannoball;
    public AudioSource deadclip;
   // the dirction of the tank
   public static Vector3 currentPos;
   //delay between shots
   private string waittoshoot = "n";
    public GameObject resatrtbutton;
   public TextMeshProUGUI gameOverText;
    
    

  

    void Start()
    {
         
       gameOverText.gameObject.SetActive(false);
    }



    // Update is called once per frame
    void Update()
    {
        // constantly updating the current position of the tank
       
        currentPos = transform.position;
        

        if(Input.GetKey("d")) 
        {
            GetComponent<Transform>().eulerAngles = new Vector3(0,-90,0);
            GetComponent<Rigidbody>().velocity = transform.forward *2.5f;
        }

       else 
       if (Input.GetKey("a"))
        { 
            GetComponent<Transform>().eulerAngles = new Vector3(0,90,0);
            GetComponent<Rigidbody>().velocity = transform.forward * 2.5f;
        }

         else 
         if (Input.GetKey("s"))
        {
            GetComponent<Transform>().eulerAngles= new Vector3(0,0,0);
            GetComponent<Rigidbody>().velocity=transform.forward * 2.5f;
        }


         else 
         if (Input.GetKey("w"))
        {
            GetComponent<Transform>().eulerAngles= new Vector3(0,180,0);
            GetComponent<Rigidbody>().velocity=transform.forward*2.5f;
        }

        else
        {
            GetComponent<Rigidbody>().velocity=transform.forward* 0;
        }
                                                // delay between shot
        if ((  Input.GetMouseButtonDown(0)) && ( waittoshoot =="n"))
        {
            waittoshoot = "y";
            // cannoball will be instantiate on the position of tank
            Instantiate(cannoball, new Vector3(transform.position.x, 1.57f, transform.position.z),transform.rotation);
            StartCoroutine(shotReset());
        }

    }
                                       
            //if the hero tank colledes with shot2 the destroy.
  
            private void OnTriggerEnter( Collider other)
{
    if (other.tag == "shot2")
    {
            deadclip.Play();
            resatrtbutton.SetActive(true);
        Destroy(gameObject,1f);
       gameOverText.gameObject.SetActive(true);
            Time.timeScale = 0;

    }
}

        // shou by cliking the mouse ,waittoshoot recaled 
    IEnumerator shotReset()
    {
        yield return new WaitForSeconds(.5f);
        waittoshoot="n";

    }

    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
    }

}
