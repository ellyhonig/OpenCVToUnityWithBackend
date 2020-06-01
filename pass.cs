using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pass : MonoBehaviour
{
    public calculator calc;
    public double passie;

    // Start is called before the first frame update
    void Start()
    {
        calc = GetComponent<calculator>();
    }

    // Update is called once per frame
    void Update()
    {
        passie = calc.numabs;
    }
}
