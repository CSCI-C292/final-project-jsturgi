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

    public void SetPlayerPrefs(string name, string time, string rank)
    {
        ZPlayerPrefs.SetString(name, name);
        ZPlayerPrefs.SetString(time, time);
        ZPlayerPrefs.SetString(rank, rank);
    }
}
