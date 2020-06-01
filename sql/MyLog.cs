using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class MyLog : MonoBehaviour
{

    public int maxLines = 89999900;
    public Queue<string> queue = new Queue<string>();
    public string Mytext = "";

    public void NewActivity(string activity)
    {
        if (queue.Count >= maxLines)
            queue.Dequeue();

        queue.Enqueue(activity);

        Mytext = "";
        foreach (string st in queue)
            Mytext = Mytext + st + "\n";
    }


    void OnGUI()
    {

        GUI.Label(new Rect(5,                             // x, left offset
                     (Screen.height - 150),            // y, bottom offset
                     300f,                                // width
                     150f), Mytext, GUI.skin.textArea);    // height, text, Skin features

    }




}