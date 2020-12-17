using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] private Button levelOne;
    [SerializeField] private Button levelTwo;
    [SerializeField] private Button levelThree;

    [SerializeField] private Button mainMenu;
    // Start is called before the first frame update
    void Start()
    {
        levelOne.onClick.AddListener(OpenLevelOne);
        levelTwo.onClick.AddListener(OpenLevelTwo);
        levelThree.onClick.AddListener(OpenLevelThree);
        mainMenu.onClick.AddListener(OpenMainMenu);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OpenLevelOne()
    {
        SceneManager.LoadScene("Level One");
    }

    private void OpenLevelTwo()
    {
        SceneManager.LoadScene("Level Two");
    }

    private void OpenLevelThree()
    {
        SceneManager.LoadScene("Level Three");
    }
    
    private void OpenMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
