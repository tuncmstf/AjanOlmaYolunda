using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class TanısmaScript : MonoBehaviour
{
    public GameObject veripaneli;
    public GameObject veripaneli2;
    public GameObject veripaneli3;
    public GameObject veripaneli4;

    // Start is called before the first frame update
    void Start()
    {
        veripaneli.SetActive(true);
        veripaneli2.SetActive(false);
        veripaneli3.SetActive(false);
        veripaneli4.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Devam()
    {
        veripaneli.SetActive(false);
        veripaneli2.SetActive(true);
        veripaneli3.SetActive(false);
        veripaneli4.SetActive(false);
    }
    public void Onceki()
    {
        veripaneli.SetActive(true);
        veripaneli2.SetActive(false);
        veripaneli3.SetActive(false);
        veripaneli4.SetActive(false);
    }
    public void Devam2()
    {
        veripaneli2.SetActive(false);
        veripaneli3.SetActive(true);
        veripaneli.SetActive(false);
        veripaneli4.SetActive(false);

    }
    public void Devam3()
    {
        veripaneli3.SetActive(false);
        veripaneli4.SetActive(true);
        veripaneli.SetActive(false);
        veripaneli2.SetActive(false);
    }
    public void changeScene()
    {
        SceneManager.LoadScene("Activity1");
    }
}
