using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    private float radius = 5;

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
    }

    public void GameOver()
    {
        SceneManager.LoadScene("game");
    }

    public void Win()
    {
        
    }
}
