using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateObs : MonoBehaviour
{
    public GameObject rocks;
    public GameObject player;
    int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateObstacle", 1f, 1.5f);
    }

    void CreateObstacle()
    {
        Instantiate(rocks);
        score++;    
    }

    void OnGUI()
    {
        GUI.color = Color.black;
        GUILayout.Label("Score : "+ score.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
