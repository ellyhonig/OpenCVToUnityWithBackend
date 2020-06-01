using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class panelswitch : MonoBehaviour
{
    public GameObject page1;
    public GameObject page2;
    public GameObject page3;



    public void loadP1()
    {
        page1.SetActive(true);
        page2.SetActive(false);
        page3.SetActive(false);

    }
    public void loadP2()
    {
        page1.SetActive(false);
        page2.SetActive(true);
        page3.SetActive(false);
    }

    public void loadP3()
    {
        page1.SetActive(false);
        page2.SetActive(false);
        page3.SetActive(true);
    }







    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
