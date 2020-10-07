using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdjacentElementRecognition : MonoBehaviour
{
    bool isAdjacent;
    string adjElement;

    void Start()
    {
        isAdjacent = false;
        adjElement = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        isAdjacent = true;
        adjElement = other.transform.name;
    }
}
