using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] private Button levelOne;
    // Start is called before the first frame update
    void Start()
    {
        levelOne.onClick.AddListener(OpenLevelOne);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OpenLevelOne()
    {
        SceneManager.LoadScene("Level One");
    }
}
