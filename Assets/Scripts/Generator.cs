using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public GameObject[] randomObject;
    public int randomNum;
    
    


    private void Awake()
    {
        randomNum = Random.Range(1, 6);
    }
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(randomObject[randomNum], transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
