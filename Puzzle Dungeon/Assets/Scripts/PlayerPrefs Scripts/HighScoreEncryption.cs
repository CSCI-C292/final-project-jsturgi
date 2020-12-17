using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;
using System.Security.Cryptography;
using System.Text;

public class HighScoreEncryption : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetPlayerPrefs(string scoreList)
    {
        ZPlayerPrefs.SetString("scoreList", scoreList);
        ZPlayerPrefs.Save();
        
    }
}
