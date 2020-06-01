using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchbutt : MonoBehaviour
{
    public GameObject item1;
    public GameObject item2;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void Activate2()
    {
        item1.SetActive(false);
        item2.SetActive(true);
    }

    public void Activate1()
    {
        item2.SetActive(false);
        item1.SetActive(true);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
