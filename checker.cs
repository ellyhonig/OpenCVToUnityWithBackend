using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checker : MonoBehaviour
{
    public GameObject check;
    public GameObject x;
    public bool insight;
    // Start is called before the first frame update
    void Start()
    {
        x.SetActive(true);
        check.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(insight)
        {
            x.SetActive(false);
            check.SetActive(true); 
        }
        else{
            x.SetActive(true);
            check.SetActive(false); 
        }
    }
}
