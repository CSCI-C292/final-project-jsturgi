using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScoreTemplate : MonoBehaviour
{

   private List<newHighScore> scoreEntries;

   private HighScoreEncryption HighScoreEncryption;

   


   public void HighScoreWrite(float time, string nickname)
   {
       newHighScore scoreToWrite = new newHighScore();
       scoreToWrite.time = time;
       scoreToWrite.nickname = nickname;
       Debug.Log(scoreToWrite);
       scoreEntries.Add(scoreToWrite);
       SortHighScoresList(scoreEntries);
       Debug.Log(scoreEntries);
   }

   private void SortHighScoresList(List<newHighScore> scoreEntries)
   {
       for (int i = 0; i < scoreEntries.Count; i++)
         {
             for (int j = i + 1; j < scoreEntries.Count; j++)
             {
                 if (scoreEntries[j].time < scoreEntries[i].time)
                 {
                     newHighScore tmp = scoreEntries[i];
                     scoreEntries[i] = scoreEntries[j];
                     scoreEntries[j] = tmp;
                 }
             }
         }
         Highscores highscores = new Highscores{highscoreEntryList = scoreEntries};
         string json = JsonUtility.ToJson(highscores);
         HighScoreEncryption.SetPlayerPrefs(json);
   }




    public class newHighScore
    {
        public float time;
        public string nickname;
    }

    public class Highscores 
    {
    public List<newHighScore> highscoreEntryList;
    }
}
