using System. Collections; 
using System. Collections.Generic; 
using UnityEngine;

public class enemy : MonoBehaviour

{

    public Transform shot;
    public hero heroScript;
    public Transform shootingPosition;
    float speed;
    int level;

void Start()
{
        speed = 1;
        StartCoroutine(delayShot());

}
void Update( )	


{ //look of he tank 
    transform.LookAt (hero. currentPos) ;
       level  = PlayerPrefs.GetInt("DIF");
        //move in the derection you are faceign 
        int score = PlayerPrefs.GetInt("Score");// getting the scored value 
        if(level == 0)
        {
            speed = 1f;//easy
        }
        else if (level == 1)
        {
            speed = 1.5f;//med
        }

        else if (level == 2)
        {
            speed = 2f;//dif
        }



        GetComponent<Rigidbody>().velocity = transform. forward * speed;
        //heroScript = hero.Find()
       

    }
   
IEnumerator delayShot ()
{
  // delay shot 4 second
yield return new WaitForSeconds (4);
//instatiate the shot on the tank
Instantiate(shot, shootingPosition.position, transform.rotation);
        Debug.Log("shooting");
// keep shoting loop
  StartCoroutine(delayShot());
}


}