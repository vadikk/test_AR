using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public GameObject[] images;
    public GameObject next;
    public GameObject Menu;

    // Use this for initialization
    void Start () {
        images[0].gameObject.SetActive(true);
        Menu.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {

        if (images[2].activeInHierarchy)
        {
            next.SetActive(false);
            Menu.SetActive(true);

        }

    }

    public void ChangeImage()
    {

        for (int i = 0; i < images.Length; i++)
        {
            if (images[i].activeInHierarchy)
            {
                images[i].gameObject.SetActive(false);
                images[i+1].gameObject.SetActive(true);
                return;
            }

            print(i);
        }
    }

  public void GoToMenu()
    {
        SceneManager.LoadScene("Menu");
    }


}
