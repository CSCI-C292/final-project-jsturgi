using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonHandler : MonoBehaviour
{
    [SerializeField] private Button levels;
    [SerializeField] private Button Scores;
    // Start is called before the first frame update
    void Start()
    {
        levels.onClick.AddListener(LevelsClicked);
        Scores.onClick.AddListener(ScoresClicked);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LevelsClicked()
    {
        SceneManager.LoadScene("Levels");

    }
    private void ScoresClicked()
    {
        SceneManager.LoadScene("Scores");
    }
}
