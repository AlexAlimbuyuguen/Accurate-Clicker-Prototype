using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PointsSystemAC : MonoBehaviour
{
    public int scoreAmount;
    public Text score; 
    // Start is called before the first frame update
    void Start()
    {
        scoreAmount = 0;
       // score = gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = scoreAmount.ToString();
    }

    public void AddScore()
    {
        scoreAmount += 1; 
    }

    //If the player presses on a hazardous object, the player will be sent to the endscreen scene. 
    //void Kill()
    //{
    //if()
    //}
}
