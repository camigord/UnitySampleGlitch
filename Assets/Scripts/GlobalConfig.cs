using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.MLAgents;

public class GlobalConfig : MonoBehaviour
{
    GameObject gameInstance;
    public int numberOfInstances = 1;    
    public float instancesSeparation = 70f;

    void Awake()
    {
        numberOfInstances = Mathf.Max(numberOfInstances, 1);      // Make sure there is at least one instance
        gameInstance = GameObject.Find("GameInstance");
  
        // This is were we instantiate the game areas when the game is launched
        for (int i = 0; i<(numberOfInstances-1); i++) {
            var gameArea = Instantiate(gameInstance, new Vector3(instancesSeparation+i*instancesSeparation, 0f, 0f), Quaternion.identity, GameObject.Find("SceneObjects").transform);
            gameArea.name = "GameInstance" + (i+1).ToString();
        }        

    }
}
