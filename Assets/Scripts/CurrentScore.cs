
   using UnityEngine;

   public class CurrentScore:SingletonMonoBehavior<CurrentScore>
   {
       public int ScoreNumber;

       public void Score(int blockUtility)
       {
           ScoreNumber += blockUtility;
           Debug.Log($"{ScoreNumber}");
       }

   }
