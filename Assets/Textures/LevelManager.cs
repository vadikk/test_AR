using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    public float loadnextLevel;
    // Use this for initialization
    void Start () {
        Invoke("LoadLevel", loadnextLevel);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void LoadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void LoadMain()
    {
        SceneManager.LoadScene("Main");
    }
}
