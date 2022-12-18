using System.Collections;
using System.Collections.Generic;
using UnityEngine;
///This is doing (just for reference)nothingggggggggggggggggggggggggggggggggggggggggggggggggg
public class PlayerCollision : MonoBehaviour
{

   void Start()
   {

   }

   void Update()
   {

   }

private void OnTriggerEnter(Collider other)

{

   // destroy if any any gameobject collision
   Destroy(gameObject);
   //Destroy(other.gameObject);
}

}







//{



  //  void OnCollisionEnter(Collision collision){
  // if (collision.gameObject.tag == "shot"){
   //  PlayerManager.isGameOver= true;
   //  gameObject.SetActive(false);
     
  // }
//}
       
   // private void OnCollisionEnter3D( Collision3D collision){
    //if( collision.transform.tag =="shot")
   // {
    //   PlayerManager.isGameOver= true;
    //   gameObject.SetActive(false);
   // }


//score=score+1;Debug.Log(score);


   // }

