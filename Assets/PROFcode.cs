using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PROFcode : MonoBehaviour
{
    // Start is called before the first frame update

    //public bool dead=true;

    void Start()
    {

      /* int life;
       int dead;
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
       Debug.Log(playerLives);*/

       /*int a=1;
       float b=2.0f;
       Debug.Log((1+1.5).GetType());  //the result type is double


       string firstName="Israa";
       string lastName="Amro";
       Debug.Log(firstName == lastName);
       Debug.Log(firstName.Length);
       Debug.Log(firstName + " " + lastName);*/

      /*  int a=1;
       {
         Debug.Log(a);
       }

       Debug.Log(a);*/


       /*int counter=0;
       while(counter<10)
       {

         int randomNambur= Random.Range(1,7);
         Debug.Log(randomNambur);
         counter++;
         if(randomNambur==1)
         {
           continue;
         }
         Debug.Log("the random number not = 1");*/


        //طريقة تعريف المتغيرات بشكل طبيعي
       /* int tuna= 10;
        int sardin= 5;
        int basal= 10;
        int bandora= 20;

        // تعريف نفس القيم لكن في مصفوفة وحجم هذه المصفوفة هو 4 
        int[] shop = new int[4];

        //كيف اعرف مصفوفة واسند اليها قيم في نفس الوقت
        int[] shope = new int[4] {10 , 5 , 10 , 20};*/

        

        //كيف نستعرض محتويات المصفوفة؟المصفوفة تبدا من 0 وليس 1
       /* Debug.Log(shopp[0]);
        Debug.Log(shopp[1]);
        Debug.Log(shopp[2]);
        Debug.Log(shopp[3]);*/

        //اذا اردنا اسناد قيم للمصفوفة في نفس سطر التعريف فلا داعي لتحديد حجم المصفوفة
        int[] shopp = {10 , 5 , 10 , 20};

        //اكثر طريقة فعالة لعرض محتويات المصفوفة مهما بلغ حجمها
        int counter =0;
        while(counter<shopp.Length)
        {
         Debug.Log(shopp[counter]);
         counter++;
        }



       
       

    }

  
}
