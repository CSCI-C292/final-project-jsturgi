using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameState : MonoBehaviour
{
    [SerializeField] private LevelManager levelManager;
    [SerializeField] private PlayerMovement playerMovement;
    [SerializeField] private TextMeshProUGUI LevelWinText;
    [SerializeField] private TextMeshProUGUI FinalTimeText;
    [SerializeField] private TextMeshProUGUI StarEarnedText;

    [SerializeField] private Image GoldStar;
    [SerializeField] private Image SilverStar;
    [SerializeField] private Image BronzeStar;
    
    [SerializeField] private Canvas LevelOverUI;

    [SerializeField] private HighScoreTemplate scoreHandler;
    [SerializeField] private TMP_InputField playerName;
    [SerializeField] private Button submitName;
    public string nickname;
    public float finalTime;
    

    
    // Start is called before the first frame update
    void Start()
    {
       // submitName.onClick.AddListener(setName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LevelOver()
    {
        playerMovement.enabled = false;
        string Star = levelManager.GetStar(levelManager.levelTime);
        finalTime = levelManager.roundedTime;
        FinalTimeText.text = "Your time was: " + finalTime.ToString();
        levelManager.enabled = false;
        if (Star != "No Star")
        {
            StarEarnedText.text = "You earned a " + Star;
        }
        else
        {
                StarEarnedText.text = "You did not earn a star";
        }
        if (Star == "Gold Star")
        {
            GoldStar.gameObject.SetActive(true);
        }
        if (Star == "Silver Star")
        {
            SilverStar.gameObject.SetActive(true);
        }
        if (Star == "BronzeStar")
        {
            BronzeStar.gameObject.SetActive(true);
        }

        LevelOverUI.gameObject.SetActive(true);
        //playerName.ActivateInputField();

        EndLevel();

    }
        
    

    private void setName()
    {
        nickname = playerName.text;
        scoreHandler.HighScoreWrite(finalTime, nickname);
    }

    private IEnumerator EndLevel()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("Levels");
        
    }


}
