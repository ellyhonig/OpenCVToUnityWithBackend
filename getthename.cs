using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleSQL;
using UnityEngine.UI;

public class getthename : MonoBehaviour
{
    public SimpleSQL.SimpleSQLManager dbManager;
    public Text outputText;
    void Awake()
    {


        string sql = "SELECT MIN(name)" +"AS name " + " FROM logentry GROUP BY name";
        List<Myclass> names = dbManager.Query<Myclass>(sql);
    
    
    
    
    
        foreach (Myclass name in names)
        {
            {
                outputText.text += "<color=#1abc9c>Name</color>: '" + name.name +"" +
                    "" ;
              
                                   
            }

        }
    
    }
}
