using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shoulderADJ : MonoBehaviour {
    public calculator script;
    public Text text;
	// Use this for initialization
	void Start () {

        text.GetComponent<Text>().text = script.numabs + " Degrees";

        script = GetComponent<calculator>();
    }

    // Update is called once per frame
    void Update () {
      
	}
}
