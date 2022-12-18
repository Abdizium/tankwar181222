using System. Collections; 
using System.Collections.Generic; 
using UnityEngine; 
using TMPro;

public class gameflow : MonoBehaviour
{
               
        public GameObject[] tank; 
        private int anytank;
        int dif;
       
   
        void Start()
        {
        StartCoroutine(spawnTimer());
          dif = 6;// decrease this to make enemy tank appear faster, after 6 sec 
                     //call the methode
        

        InvokeRepeating("Difficulty", 120f, 120f);//diificulty , repeats after sometime , sec
        }

      public void Difficulty()
    {
        dif=dif - 1;
    }
        IEnumerator spawnTimer ()
        {
        // wait enamy tank by 4 min after
        yield return new WaitForSeconds(dif);
        // the number of the tanks are 3 rang
        anytank = Random.Range(0,3);
         // two tank at a time
          Instantiate(tank [anytank]);
        anytank = Random. Range(0,3); 
          Instantiate(tank[anytank]);
          //Keep repating it self
        StartCoroutine(spawnTimer());
        }
}