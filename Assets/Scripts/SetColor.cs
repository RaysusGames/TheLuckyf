using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetColor : MonoBehaviour
{
    public Material[] materiales;
    public Throw num;

    void Update()
    {
        gameObject.GetComponent<Renderer>().material = materiales[num.randomNum];
    }

    
}
