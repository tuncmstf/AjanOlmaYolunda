using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class denem : MonoBehaviour
{

    public GameObject a1;
    public GameObject a2;
    public GameObject a3;


    public void PlayAnimation()
    {
        a1.SetActive(true);
        a2.SetActive(true);
        a3.SetActive(true);
    }

    // Start is called before the first frame update
    void Start()
    {
        a1.SetActive(false);
        a2.SetActive(false);
        a3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
