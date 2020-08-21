using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRHand : MonoBehaviour
{
    public string triggerName;
    private Color originalColor;

    void Start()
    {
        originalColor = GetComponent<MeshRenderer>().material.color;
    }

    void Update()
    {
        if(Input.GetAxis(triggerName) > 0.2)
        {
            GetComponent<MeshRenderer>().material.color = Color.green;
        }
        else
        {
            GetComponent<MeshRenderer>().material.color = originalColor;
        }
    }
}
