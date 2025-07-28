using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class UyanmaScript : MonoBehaviour
{
    public GameObject karakter;
    // Start is called before the first frame update

    public void devam()
    {
        karakter.GetComponent<Animator>().enabled = true;
        karakter.GetComponent<Animator>().Play("Uyanma");

    }

    public void devam2()
    {
        karakter.GetComponent<Animator>().enabled = true;
        karakter.GetComponent<Animator>().Play("sýnavagit");

    }
    public void changeScene()
    {
        SceneManager.LoadScene("Scene3");
    }
    public void changeScene2()
    {
        SceneManager.LoadScene("Scene4");
    }
}
