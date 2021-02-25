using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
   public Text mytext;
   public static int scorePoint;
   public int scoree;

   public void ScoreUpdate(int score)
   {
       scoree += score;
       scorePoint = scoree;
       mytext.text = scoree.ToString("0");
   }

}
