using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScoreTemplate : MonoBehaviour
{
   public float time;
   public string nickname;
   [SerializeField] private HighscoreTable scoreTable;

   public HighScoreTemplate(float time, string nickname)
   {
       this.time = time;
       this.nickname = nickname;
   }


   public void HighScoreWrite(float time, string nickname)
   {
       HighScoreTemplate scoreToWrite = new HighScoreTemplate(time, nickname);
       scoreTable.highScoreEntries.Add(scoreToWrite);
       scoreTable.ScoreTableUpdate();
       scoreTable.SortHighScoresList(scoreTable.highScoreEntries);
   }


}
