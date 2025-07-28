using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Drag1 : MonoBehaviour
{
    Camera maincam;
    Vector3 startpos;
    bool isinside = false;
    public string hedeftag = "";
    public int matchstatus = 0;//0 eþleþmemiþ 1-yanlýþ 2-doðru
    public GameObject panel;
    public GameObject dogru;
    public GameObject yanlýs;


    // Start is called before the first frame update
    void Start()
    {
        maincam = Camera.main;
        startpos = this.transform.position;
        panel.SetActive(false);
        dogru.SetActive(false);
        yanlýs.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseUp()
    {
        //ilk pozisyona geri dön
        if (!isinside)
        {
            this.transform.position = startpos;
            matchstatus = 0;



        }
        else
        {
            this.transform.position = icindeoldugumobje.transform.position;
            if (icindeoldugumobje.tag == hedeftag)
            {
                matchstatus = 2;
                panel.SetActive(true);
                dogru.SetActive(true);
                yanlýs.SetActive(false);


            }
            else
            {
                matchstatus = 1;
                panel.SetActive(true);
                dogru.SetActive(false);
                yanlýs.SetActive(true);


            }
        }
    }

    private void OnMouseDrag()
    {
        Vector3 mousepos = maincam.ScreenToWorldPoint(Input.mousePosition);
        this.transform.position = new Vector3(mousepos.x, mousepos.y, 0);
    }

    GameObject icindeoldugumobje;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        icindeoldugumobje = collision.gameObject;
        isinside = true;
        Debug.Log("etkileþim alanýna girdi!");
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        icindeoldugumobje = null;
        isinside = false;
    }
    public void changeScene()
    {
        SceneManager.LoadScene("Activity2");
    }
    public void changeScene1()
    {
        SceneManager.LoadScene("Activity2 1");
    }
    public void changeScene2()
    {
        SceneManager.LoadScene("Activity2 2");
    }
    public void changeScene3()
    {
        SceneManager.LoadScene("Activity2");
    }
}