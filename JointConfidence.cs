using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JointConfidence : MonoBehaviour {

    
    public bool dontShowGameobjectWhenNotLegitimate = false;
    private MeshRenderer mesh;

    private ExternalControl serverData;


    public float threshold= 0.5f;
    private float _confidence;
    private bool _isLegitData;
    internal bool IsDataLegitimate()
    {
        return _isLegitData;
    }

    // Use this for initialization
    void Start () {
        _isLegitData = false;

        mesh = this.GetComponent<MeshRenderer>();

        serverData = this.GetComponent<ExternalControl>();

    }

    // Update is called once per frame
    void Update () {

        _confidence = serverData.GetConfidence();


        _isLegitData = (threshold < _confidence);

        

        if (dontShowGameobjectWhenNotLegitimate)
        {
            Color color;
            if (_isLegitData)
            {
                 color = new Color(0, 1, 0);

            }
            else
            {

                 color = new Color(1, 0, 0);
            }

            mesh.material.color = color;
        }
    }
}
