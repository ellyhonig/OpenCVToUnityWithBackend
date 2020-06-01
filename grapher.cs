

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class grapher : MonoBehaviour
{
    public float val = 5;
    public float targetTime = .02f;
    public float resetval = .02f;
    public float y ;
    public calculator calc;
    
    public float yeet;
    int x = 100;
    
    public void starttimer()
    {
        targetTime -= Time.deltaTime;
    }

    public void penis()
    {
        if (Input.GetKeyDown("space"))
        {
            val++;
        }
        
    }

    public GameObject hingeR;
    void Start()
    {
        val = 0;

        yeet = 1;
       // calc = hingeR.GetComponent<calculator>();
        int x = 0;



    }
   
    void createcube()
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //  cube.AddComponent<mover>();
        cube.transform.position = new Vector3(x, (float)(calc.numabs), 5000);
        cube.transform.localScale = new Vector3(16f, 16f, 16f);

    }
    void Update()
    {
        if (targetTime <= 0)
        {
            targetTime = resetval;
            //starttimer();
            createcube();
            x++;
            Debug.Log("angle;" + y);
        }
        targetTime -= Time.deltaTime;
        penis();

        y = yeet;
        yeet = calc.NA + 1;
    }
}
