using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelManager : MonoBehaviour
{
    public float levelTime;
    [SerializeField] private TextMeshProUGUI timeText;
    public float roundedTime;

    [SerializeField] private int goldTime = 8;
    [SerializeField] private int silverTime = 10;
    [SerializeField] private int bronzeTime = 12;
    private bool goldVisible = true;
    private bool silverVisible = true;
    private bool bronzeVisible = true;
    // Start is called before the first frame update
    void Start()
    {
        levelTime = 0;
        roundedTime = Mathf.Round(levelTime * 100.0f) / 100.0f;
        timeText.text = roundedTime.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        levelTime += Time.deltaTime;
        roundedTime = Mathf.Round(levelTime * 100.0f) / 100.0f;
        timeText.text = roundedTime.ToString();
        checkGold();
        checkSilver();
        checkBronze();
    }

    public string GetStar(float finishTime)
    {
        if (finishTime <= goldTime)
        {
            return "Gold Star";
        }
        else if(finishTime <= silverTime)
        {
            return "Silver Star";
        }
        else if(finishTime <= bronzeTime)
        {
            return "Bronze Star";
        }
        else
        {
            return "No Star";
        }
    }

    private void checkGold()
    {
        if (goldVisible)
        {
            if (levelTime > goldTime)
            {
            GameObject.Find("GoldStar").SetActive(false);
            goldVisible = false;
            }   
        }
        
    }

    private void checkSilver()
    {
        if (silverVisible)
        {
            if (levelTime > silverTime)
            {
                GameObject.Find("SilverStar").SetActive(false);
                silverVisible = false;
            }
        }
    }

    private void checkBronze()
    {
        if (bronzeVisible)
        {
            if (levelTime > bronzeTime)
            {
                GameObject.Find("BronzeStar").SetActive(false);
                bronzeVisible = false;
            }
        }
    }
}
