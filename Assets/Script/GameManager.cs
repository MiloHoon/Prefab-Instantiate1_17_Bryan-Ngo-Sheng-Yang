using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    float points;

    public static GameManager gmInstance;
    public Text PointsScore;

    // Start is called before the first frame update
    void Start()
    {
        if (gmInstance == null)
        {
            gmInstance = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void addscore()
    {
        points++;
        PointsScore.GetComponent<Text>().text = "Points: " + points;
    }
}
