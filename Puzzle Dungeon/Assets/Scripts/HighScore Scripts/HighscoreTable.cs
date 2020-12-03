using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighscoreTable : MonoBehaviour
{
    private Transform entryContainer;
    private Transform entryTemplate;
    private float templateHeight = 20f;
    public List<HighScoreTemplate> highScoreEntries;
    private List<Transform> highscoreentryTransformList;
    private HighScoreTemplate highScoreTemplate;
    private void Awake()
    {
        entryContainer = transform.Find("highscoreEntryContainer");
        entryTemplate = transform.Find("HighScore Entry Template");
        entryTemplate.gameObject.SetActive(false);

        
    }

     
     public void ScoreTableUpdate()
     {
         foreach (HighScoreTemplate i in highScoreEntries)
         {
             CreateHighscoreEntryTransform(i, entryContainer, highscoreentryTransformList);
         }
     }

     public void SortHighScoresList(List<HighScoreTemplate> highScoreEntries)
     {
         for (int i = 0; i < highScoreEntries.Count; i++)
         {
             for (int j = i + 1; j < highScoreEntries.Count; j++)
             {
                 if (highScoreEntries[j].time < highScoreEntries[i].time)
                 {
                     HighScoreTemplate tmp = highScoreEntries[i];
                     highScoreEntries[i] = highScoreEntries[j];
                     highScoreEntries[j] = tmp;
                 }
             }
         }

         for (int i = 0; i < highScoreEntries.Count; i++)
         {
             CreateHighscoreEntryTransform(highScoreEntries[i], entryContainer, highscoreentryTransformList);
         }
     }
     
     
     
     
        private void CreateHighscoreEntryTransform(HighScoreTemplate highScoreEntry, Transform container, List<Transform> transformList)
    {
        Transform entryTransform = Instantiate(entryTemplate, container);
            RectTransform entryRectTransform = entryTransform.GetComponent<RectTransform>();
            entryRectTransform.anchoredPosition = new Vector2(0, -templateHeight*transformList.Count);
            entryTransform.gameObject.SetActive(true);

            int rank = transformList.Count + 1;
            string rankString;

            switch (rank)
            {
                default:
                    rankString = rank + "TH";
                    break;
                case 1: rankString = "1st";
                break;
                case 2: rankString = "2nd";
                break;
                case 3: rankString = "3rd";
                break;
            }
            entryTransform.Find("Rank").GetComponent<Text>().text = rankString;

            float time = highScoreTemplate.time;
            entryTransform.Find("Time").GetComponent<Text>().text = time.ToString();

            string nickname = highScoreEntry.nickname;
            entryTransform.Find("Time").GetComponent<Text>().text = nickname;

            transformList.Add(entryTransform);
    }
 

   
}

