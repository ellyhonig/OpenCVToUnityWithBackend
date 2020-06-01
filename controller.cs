using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class controller : MonoBehaviour
{
   // public GameObject item1;
    //public GameObject item2;
    public GameObject b1;
    public GameObject b2;
    public GameObject check1;
    public GameObject check2;

    //TIMER STUFF
    public float tartime;
    public float restime;
    public float curtime;

    public bool timersw;
    public bool ucall;
    public bool ustp;
    public bool sessionswitch;
    public bool sesh1done;
    public bool sesh2done;


    public Text txt; 
    // Start is called before the first frame update
    public void Timer()
    {
        



        if (timersw)
        { curtime -= Time.deltaTime; }

        if (curtime <= tartime || ustp == true)
        {
            
            curtime = restime;
            timersw = false;
            Debug.Log("Session Upload Requested");
            ustp = false;  


           // item2.SetActive(false);
            //item1.SetActive(true);
            switchto1();
            sessionswitch = true;
        
        }
        if ( sesh1done )
        {

            check1.SetActive(true);

        }
        if(  sesh2done ){
            check2.SetActive(true);
            check1.SetActive(false);

        }
        if(timersw && sessionswitch == false)  
        {
            sesh1done = true;
        }
        if(timersw && sessionswitch == true)  
        {
            sesh2done = true;
        }
              
              
           
            
    }
    public void tcall()
    {
        ucall = true;
        timersw = true;

    }
    public void tstop()
    {
        ustp = true;
    }

    public void Activate2()
    {
        //item1.SetActive(false);
        //item2.SetActive(true);
    }

    public  void Activate1()
    {
        //item2.SetActive(false);
       // item1.SetActive(true);
    }
    public void switchto2()
    {
        b1.SetActive(false);
        b2.SetActive(true);
    }

    public void switchto1()
    {
        b2.SetActive(false);
        b1.SetActive(true);
    }


    void Start()
    {
        tartime = 0;
        restime = 4;
        curtime = restime;
        ustp = false;
        sesh1done = false;
        sesh2done = false;

    }

// Update is called once per frame
void Update()
{
        if (ucall )
        { Timer(); }


        txt.text =  curtime.ToString("N0");
}
}
