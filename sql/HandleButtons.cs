using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HandleButtons : MonoBehaviour
{
    private MyLog queue;

    public Text readtext;
    public InputField setText;

    // Start is cal  led before the first frame update

    string setURL = "http://localhost:8890/PostName.php?name=";
    string getURL = "http://localhost:8890/ReadName.php";
    public void SetText()
    {
        StartCoroutine(SetTheText(setText.text));
    }
    public void GetText()
    {
        StartCoroutine(GetTheText());
    }
    IEnumerator SetTheText(string name)
    {
        string URL = setURL + name;
        WWW www = new WWW(URL);
        yield return www;
    }
    IEnumerator GetTheText()
    // Update is called once per frame
    {
        string URL = getURL;
        WWW www = new WWW(URL);
        yield return www;

        readtext.text = www.text;

    }



     void Start()
    {
        queue = GetComponent<MyLog>();
    }



}
