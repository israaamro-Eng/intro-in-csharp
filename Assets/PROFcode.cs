using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PROFcode : MonoBehaviour
{
    // Start is called before the first frame update

    //public bool dead=true;

    void Start()
    {
       int playerLives=3;

       while(playerLives>0)
       {
          if(playerLives==3)
          { 
             Debug.Log(playerLives);
             Debug.Log("Many lives");
          }
          

          else if(playerLives==1)
          {
            Debug.Log(playerLives);
            Debug.Log("The last life");
          } 

          playerLives--;
       }

       Debug.Log("Game Over");
       Debug.Log(playerLives);
    }

  
}
