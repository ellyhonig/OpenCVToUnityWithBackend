


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{
    public int speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 29;
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector3.right * Time.deltaTime * speed);
    }
}
