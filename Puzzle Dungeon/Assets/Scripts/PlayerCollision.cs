using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField] private GameObject button2;
    [SerializeField] private GameObject button3;

    [SerializeField] private GameObject boulder;

    [SerializeField] private GameObject flag;

    [SerializeField] private GameState gameState;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "button 1")
        {
            button2.SetActive(true);
            other.gameObject.SetActive(false);
        }
        if (other.gameObject.name == "button 2")
        {
            button3.SetActive(true);
            other.gameObject.SetActive(false);
        }
        if(other.gameObject.tag == "Button3")
        {
            boulder.SetActive(false);
            other.gameObject.SetActive(false);
        }
        if(other.gameObject.tag == "Flag")
        {
            gameState.LevelOver();
        }
    }
}
