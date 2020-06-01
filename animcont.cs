using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animcont : MonoBehaviour
{
    public Animator anim;
    public GameObject boolhold;
    public controller mnger;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        mnger = boolhold.GetComponent<controller>();
    }

    // Update is called once per frame
    void Update()
    {
        if (mnger.timersw)
        {
            anim.SetBool("isWorking", true);
            anim.SetBool("isIdle", false);
        }
        else
        {
            anim.SetBool("isWorking", false);
            anim.SetBool("isIdle", true);
        }
    }
}
