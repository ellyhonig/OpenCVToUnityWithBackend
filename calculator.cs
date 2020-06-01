using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class calculator : MonoBehaviour
{


    //public InputField mainInputField;
    //num = script.toR * script.toR -= script.toL * script.toL -= script2.dist * script2.dist;
    //Debug.Log(num);

    private MyLog queue;


    public InputField Ename;
    public InputField IDnum;
  

    public VARdist script2;
    public TWOsidesTRI script;
    public double cos;
    public float num;
    public float NA;
    public double numabs;
    public GameObject source;
    public TextMesh text1;
    public string uname;
    public string ID;
    public string seshNum;
    public string bp;
    // Start is called before the first frame update
   public  void Start()
    {
      
        bp = gameObject.name;
        Debug.Log(Application.persistentDataPath);
        //queue = GetComponent<MyLog>();
        seshNum = " A ";
        Dbg.Trace("ID__" + uname );
        script2 = source.GetComponent<VARdist>();
        script = GetComponent<TWOsidesTRI>();

    }
    public void yeet()
    {
        text1.GetComponent<TextMesh>().text = numabs.ToString("N0") ;
    }
    // Update is called once per frame
    void Update()
    {
        uname = Ename.text;
        ID = IDnum.text;
        cos = Math.Acos(num);
        num = (((script2.dist * script2.dist) - (script.toR * script.toR) - (script.toL * script.toL)) / (script.toL * script.toR * -2));
        numabs = cos * 180 / 3.141592653589793238;

        yeet();

       
       // PlayerPrefs.SetString("date_time", System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")); Dbg.Trace(PlayerPrefs.GetString("date_time") +      " angle.is "+ numabs + " " + gameObject.name  );
         //mainInputField.text = gameObject.name + numabs.ToString("N") + " " + ID.ToString("N") +" "+ uname;
       
        //queue = GetComponent<MyLog>();

       // mainInputField.text = queue.Mytext;

        // queue.NewActivity(numabs.ToString("N3")); 
        //queue.NewActivity("nnn"); 

            
    }
}






