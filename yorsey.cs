using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class yorsey : MonoBehaviour
{

    public calculator calc;
    private MyLog queue;
    public InputField mainInputField;
    int bee = 3;

    // Start is called before the first frame update
    void Start()
    {
       // queue = GetComponent<MyLog>();   
      //  queue = GetComponent<MyLog>();
      //  calc = GetComponent<calculator>();
    }

    // Update is called once per frame
    void Update()
    {
       // PlayerPrefs.SetString("date_time", System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
       // mainInputField.text = queue.Mytext;
       
         //queue.NewActivity("borse"); 
        //if (Input.GetKey(KeyCode.A))
//        queue.NewActivity(PlayerPrefs.GetString("date_time") + "_" + calc.numabs.ToString("N3")+ "_"  + gameObject.name +  "_" + calc.ID.ToString("N") + "_" + calc.uname ); 
    }
}
