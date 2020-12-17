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

    [SerializeField] private GameObject player;
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
        if (other.gameObject.tag == "panel1")
        {
            GameObject.FindGameObjectWithTag("panel2").GetComponent<CircleCollider2D>().enabled = true;
            GameObject.FindGameObjectWithTag("panel3").GetComponent<CircleCollider2D>().enabled = true;
            GameObject.FindGameObjectWithTag("panel4").GetComponent<CircleCollider2D>().enabled = true;
            GameObject.FindGameObjectWithTag("panel10").GetComponent<CircleCollider2D>().enabled = false;
            player.transform.position = new Vector3(17.66f, 10.3f, 2f);
        }

        if (other.gameObject.tag == "panel2")
        {
            GameObject.FindGameObjectWithTag("panel1").GetComponent<CircleCollider2D>().enabled = true;
            GameObject.FindGameObjectWithTag("panel3").GetComponent<CircleCollider2D>().enabled = true;
            GameObject.FindGameObjectWithTag("panel4").GetComponent<CircleCollider2D>().enabled = true;
            GameObject.FindGameObjectWithTag("panel6").GetComponent<CircleCollider2D>().enabled = true;
            GameObject.FindGameObjectWithTag("panel7").GetComponent<CircleCollider2D>().enabled = true;
            GameObject.FindGameObjectWithTag("panel5").GetComponent<CircleCollider2D>().enabled = true;
            GameObject.FindGameObjectWithTag("panel8").GetComponent<CircleCollider2D>().enabled = false;
            player.transform.position = new Vector3(17.66f, -1.58f, 2f);
        }
        if (other.gameObject.tag == "panel3")
        {
            GameObject.FindGameObjectWithTag("panel1").GetComponent<CircleCollider2D>().enabled = true;
            GameObject.FindGameObjectWithTag("panel2").GetComponent<CircleCollider2D>().enabled = true;
            GameObject.FindGameObjectWithTag("panel4").GetComponent<CircleCollider2D>().enabled = true;
            GameObject.FindGameObjectWithTag("panel13").GetComponent<CircleCollider2D>().enabled = true;
            GameObject.FindGameObjectWithTag("panel16").GetComponent<CircleCollider2D>().enabled = true;
            GameObject.FindGameObjectWithTag("panel15").GetComponent<CircleCollider2D>().enabled = true;
            GameObject.FindGameObjectWithTag("panel14").GetComponent<CircleCollider2D>().enabled = false;
            player.transform.position = new Vector3(-2.27f, 7.26f, 2f);
            
        }

        if (other.gameObject.tag == "panel4")
        {
            GameObject.FindGameObjectWithTag("panel1").GetComponent<CircleCollider2D>().enabled = true;
            GameObject.FindGameObjectWithTag("panel2").GetComponent<CircleCollider2D>().enabled = true;
            GameObject.FindGameObjectWithTag("panel3").GetComponent<CircleCollider2D>().enabled = true;
            GameObject.FindGameObjectWithTag("panel6").GetComponent<CircleCollider2D>().enabled = true;
            GameObject.FindGameObjectWithTag("panel7").GetComponent<CircleCollider2D>().enabled = true;
            GameObject.FindGameObjectWithTag("panel8").GetComponent<CircleCollider2D>().enabled = true;
            GameObject.FindGameObjectWithTag("panel5").GetComponent<CircleCollider2D>().enabled = false;
            player.transform.position = new Vector3(10.7f, -1.7f, 2);
        }

        if (other.gameObject.tag == "panel5")
        {
            GameObject.FindGameObjectWithTag("panel6").GetComponent<CircleCollider2D>().enabled = true;
            GameObject.FindGameObjectWithTag("panel7").GetComponent<CircleCollider2D>().enabled = true;
            GameObject.FindGameObjectWithTag("panel8").GetComponent<CircleCollider2D>().enabled = true;
            player.transform.position = new Vector3(8.21f, -12f, 2f);
        }

        if (other.gameObject.tag == "panel6")
        {
            GameObject.FindGameObjectWithTag("panel6").GetComponent<CircleCollider2D>().enabled = true;
            GameObject.FindGameObjectWithTag("panel7").GetComponent<CircleCollider2D>().enabled = true;
            GameObject.FindGameObjectWithTag("panel8").GetComponent<CircleCollider2D>().enabled = true;
            GameObject.FindGameObjectWithTag("panel2").GetComponent<CircleCollider2D>().enabled = true;
            GameObject.FindGameObjectWithTag("panel3").GetComponent<CircleCollider2D>().enabled = true;
            GameObject.FindGameObjectWithTag("panel4").GetComponent<CircleCollider2D>().enabled = true;
            GameObject.FindGameObjectWithTag("panel1").GetComponent<CircleCollider2D>().enabled = false;
            player.transform.position = new Vector3(4.59f, 1.42f, 2);
        }

        if (other.gameObject.tag == "panel7")
        {
            GameObject.FindGameObjectWithTag("panel6").GetComponent<CircleCollider2D>().enabled = true;
            GameObject.FindGameObjectWithTag("panel5").GetComponent<CircleCollider2D>().enabled = true;
            GameObject.FindGameObjectWithTag("panel8").GetComponent<CircleCollider2D>().enabled = true;
            GameObject.FindGameObjectWithTag("panel15").GetComponent<CircleCollider2D>().enabled = true;
            GameObject.FindGameObjectWithTag("panel14").GetComponent<CircleCollider2D>().enabled = true;
            GameObject.FindGameObjectWithTag("panel13").GetComponent<CircleCollider2D>().enabled = true;
            GameObject.FindGameObjectWithTag("panel16").GetComponent<CircleCollider2D>().enabled = false;
            player.transform.position = new Vector3(4.72f, 10.3f, 2f);
        }

        if (other.gameObject.tag == "panel8")
        {
            GameObject.FindGameObjectWithTag("panel6").GetComponent<CircleCollider2D>().enabled = true;
            GameObject.FindGameObjectWithTag("panel5").GetComponent<CircleCollider2D>().enabled = true;
            GameObject.FindGameObjectWithTag("panel7").GetComponent<CircleCollider2D>().enabled = true;
            GameObject.FindGameObjectWithTag("panel11").GetComponent<CircleCollider2D>().enabled = true;
            GameObject.FindGameObjectWithTag("panel10").GetComponent<CircleCollider2D>().enabled = true;
            GameObject.FindGameObjectWithTag("panel9").GetComponent<CircleCollider2D>().enabled = true;
            GameObject.FindGameObjectWithTag("panel12").GetComponent<CircleCollider2D>().enabled = false;
            player.transform.position = new Vector3(10.6f, 7.26f, 2f);
        }
        if (other.gameObject.tag == "panel9")
        {
            GameObject.FindGameObjectWithTag("panel10").GetComponent<CircleCollider2D>().enabled = true;
            GameObject.FindGameObjectWithTag("panel11").GetComponent<CircleCollider2D>().enabled = true;
            GameObject.FindGameObjectWithTag("panel12").GetComponent<CircleCollider2D>().enabled = true;
            GameObject.FindGameObjectWithTag("panel1").GetComponent<CircleCollider2D>().enabled = true;
            GameObject.FindGameObjectWithTag("panel3").GetComponent<CircleCollider2D>().enabled = true;
            GameObject.FindGameObjectWithTag("panel4").GetComponent<CircleCollider2D>().enabled = true;
            GameObject.FindGameObjectWithTag("panel2").GetComponent<CircleCollider2D>().enabled = false;
            player.transform.position = new Vector3(-2.37f,1.42f, 2);
        }
        if (other.gameObject.tag == "panel10")
        {
            GameObject.FindGameObjectWithTag("panel9").GetComponent<CircleCollider2D>().enabled = true;
            GameObject.FindGameObjectWithTag("panel11").GetComponent<CircleCollider2D>().enabled = true;
            GameObject.FindGameObjectWithTag("panel12").GetComponent<CircleCollider2D>().enabled = true;
            GameObject.FindGameObjectWithTag("panel13").GetComponent<CircleCollider2D>().enabled = false;
            GameObject.FindGameObjectWithTag("panel14").GetComponent<CircleCollider2D>().enabled = true;
            GameObject.FindGameObjectWithTag("panel15").GetComponent<CircleCollider2D>().enabled = true;
            GameObject.FindGameObjectWithTag("panel16").GetComponent<CircleCollider2D>().enabled = true;
            player.transform.position = new Vector3(4.53f, 7.26f, 2f);
        }

        if (other.gameObject.tag == "panel11")
        {
            GameObject.FindGameObjectWithTag("panel9").GetComponent<CircleCollider2D>().enabled = true;
            GameObject.FindGameObjectWithTag("panel10").GetComponent<CircleCollider2D>().enabled = true;
            GameObject.FindGameObjectWithTag("panel12").GetComponent<CircleCollider2D>().enabled = true;
            GameObject.FindGameObjectWithTag("panel5").GetComponent<CircleCollider2D>().enabled = true;
            GameObject.FindGameObjectWithTag("panel7").GetComponent<CircleCollider2D>().enabled = true;
            GameObject.FindGameObjectWithTag("panel8").GetComponent<CircleCollider2D>().enabled = true;
            GameObject.FindGameObjectWithTag("panel6").GetComponent<CircleCollider2D>().enabled = false;
            player.transform.position = new Vector3(10.7f, 1.42f, 2f);
        }

        if (other.gameObject.tag == "panel12")
        {
            GameObject.FindGameObjectWithTag("panel9").GetComponent<CircleCollider2D>().enabled = true;
            GameObject.FindGameObjectWithTag("panel10").GetComponent<CircleCollider2D>().enabled = true;
            GameObject.FindGameObjectWithTag("panel11").GetComponent<CircleCollider2D>().enabled = true;
            GameObject.FindGameObjectWithTag("panel1").GetComponent<CircleCollider2D>().enabled = true;
            GameObject.FindGameObjectWithTag("panel2").GetComponent<CircleCollider2D>().enabled = true;
            GameObject.FindGameObjectWithTag("panel4").GetComponent<CircleCollider2D>().enabled = true;
            GameObject.FindGameObjectWithTag("panel3").GetComponent<CircleCollider2D>().enabled = false;
            player.transform.position = new Vector3 (-2.37f, -1.69f, 2f);
        }

        if (other.gameObject.tag == "panel13")
        {
            GameObject.FindGameObjectWithTag("panel14").GetComponent<CircleCollider2D>().enabled = true;
            GameObject.FindGameObjectWithTag("panel15").GetComponent<CircleCollider2D>().enabled = true;
            GameObject.FindGameObjectWithTag("panel16").GetComponent<CircleCollider2D>().enabled = true;
            GameObject.FindGameObjectWithTag("panel12").GetComponent<CircleCollider2D>().enabled = true;
            GameObject.FindGameObjectWithTag("panel10").GetComponent<CircleCollider2D>().enabled = true;
            GameObject.FindGameObjectWithTag("panel9").GetComponent<CircleCollider2D>().enabled = true;
            GameObject.FindGameObjectWithTag("panel11").GetComponent<CircleCollider2D>().enabled = false;
            player.transform.position = new Vector3(10.6f, 10.3f, 2f);
        }

        if (other.gameObject.tag == "panel14")
        {
            GameObject.FindGameObjectWithTag("panel13").GetComponent<CircleCollider2D>().enabled = true;
            GameObject.FindGameObjectWithTag("panel15").GetComponent<CircleCollider2D>().enabled = true;
            GameObject.FindGameObjectWithTag("panel16").GetComponent<CircleCollider2D>().enabled = true;
            GameObject.FindGameObjectWithTag("panel6").GetComponent<CircleCollider2D>().enabled = true;
            GameObject.FindGameObjectWithTag("panel5").GetComponent<CircleCollider2D>().enabled = true;
            GameObject.FindGameObjectWithTag("panel8").GetComponent<CircleCollider2D>().enabled = true;
            GameObject.FindGameObjectWithTag("panel7").GetComponent<CircleCollider2D>().enabled = false;
            player.transform.position = new Vector3(17.66f, 1.42f, 2f);
        }

        if (other.gameObject.tag == "panel15")
        {
            GameObject.FindGameObjectWithTag("panel13").GetComponent<CircleCollider2D>().enabled = true;
            GameObject.FindGameObjectWithTag("panel14").GetComponent<CircleCollider2D>().enabled = true;
            GameObject.FindGameObjectWithTag("panel16").GetComponent<CircleCollider2D>().enabled = true;
            GameObject.FindGameObjectWithTag("panel1").GetComponent<CircleCollider2D>().enabled = true;
            GameObject.FindGameObjectWithTag("panel2").GetComponent<CircleCollider2D>().enabled = true;
            GameObject.FindGameObjectWithTag("panel3").GetComponent<CircleCollider2D>().enabled = true;
            GameObject.FindGameObjectWithTag("panel4").GetComponent<CircleCollider2D>().enabled = false;
            player.transform.position = new Vector3 (4.67f, -1.69f, 2);
        }
        if (other.gameObject.tag == "panel16")
        {
            GameObject.FindGameObjectWithTag("panel13").GetComponent<CircleCollider2D>().enabled = true;
            GameObject.FindGameObjectWithTag("panel15").GetComponent<CircleCollider2D>().enabled = true;
            GameObject.FindGameObjectWithTag("panel14").GetComponent<CircleCollider2D>().enabled = true;
            GameObject.FindGameObjectWithTag("panel10").GetComponent<CircleCollider2D>().enabled = true;
            GameObject.FindGameObjectWithTag("panel11").GetComponent<CircleCollider2D>().enabled = true;
            GameObject.FindGameObjectWithTag("panel12").GetComponent<CircleCollider2D>().enabled = true;
            GameObject.FindGameObjectWithTag("panel9").GetComponent<CircleCollider2D>().enabled = false;
            player.transform.position = new Vector3 (17.66f, 7.26f, 2f);

        }


        
    }
}
