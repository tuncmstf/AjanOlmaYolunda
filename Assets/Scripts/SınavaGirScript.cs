using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class SınavaGirScript : MonoBehaviour
{

    public GameObject veripaneli;
    public GameObject veripaneli2;

    private void Start()
    {
        veripaneli.SetActive(true);
        veripaneli2.SetActive(false);
    }
    public void VeriPaneliAc()
    {

        veripaneli.SetActive(false);
        veripaneli2.SetActive(true);
    }
    public void changeScene()
    {
        SceneManager.LoadScene("Scene5");
    }
}