using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dogruyanlıs : MonoBehaviour
{
    public GameObject button;
    public GameObject[] objeler;
    Camera maincam;
    Vector3 startpos;
    bool isinside = false;
    public string hedeftag = "";
    public int matchstatus = 0;//0 eşleşmemiş 1-yanlış 2-doğru

    public Sprite[] myIcons;

    // Start is called before the first frame update
    void Start()
    {
        maincam = Camera.main;
        startpos = this.transform.position;
        button.SetActive(false);
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
            transform.GetChild(0).gameObject.SetActive(false);
            transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite = myIcons[0];

        }
        else
        {
            this.transform.position = icindeoldugumobje.transform.position;
            if (icindeoldugumobje.tag == hedeftag)
            {
                matchstatus = 2;
                transform.GetChild(0).gameObject.SetActive(true);
                transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite = myIcons[1];
            }
            else
            {
                matchstatus = 1;
                transform.GetChild(0).gameObject.SetActive(true);
                transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite = myIcons[0];

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
        Debug.Log("etkileşim alanına girdi!");
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        icindeoldugumobje = null;
        isinside = false;
    }

    int dogrusayısı = 0;
    int yanissayisi = 0;
    int bossayisi = 0;
    public void kontrol()
    {
        dogrusayısı = 0;
        yanissayisi = 0;
        bossayisi = 0;

        objeler = GameObject.FindGameObjectsWithTag("obje");

        foreach (GameObject obje in objeler)
        {
            switch (obje.GetComponent<dogruyanlıs>().matchstatus)
            {
                case 0:
                    bossayisi++;
                    break;
                case 1:
                    yanissayisi++;
                    break;
                case 2:
                    dogrusayısı++;
                    break;
            }
        }
        if (dogrusayısı == 3)
		{
            button.SetActive(true);
		}
    }
}
