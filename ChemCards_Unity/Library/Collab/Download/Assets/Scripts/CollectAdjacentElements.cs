using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectAdjacentElements : MonoBehaviour
{
    bool northElement;
    bool eastElement;
    bool southElement;
    bool westElement;

    void Start()
    {
        northElement = transform.Find("North").GetComponent<AdjacentElementRecognition>().isAdjacent;
        eastElement = transform.Find("East").GetComponent<AdjacentElementRecognition>().isAdjacent;
        southElement = transform.Find("South").GetComponent<AdjacentElementRecognition>().isAdjacent;
        westElement = transform.Find("West").GetComponent<AdjacentElementRecognition>().isAdjacent;
    }

    // Update is called once per frame
    void Update()
    {
        northElement = transform.Find("North").GetComponent<AdjacentElementRecognition>().isAdjacent;
        eastElement = transform.Find("East").GetComponent<AdjacentElementRecognition>().isAdjacent;
        southElement = transform.Find("South").GetComponent<AdjacentElementRecognition>().isAdjacent;
        westElement = transform.Find("West").GetComponent<AdjacentElementRecognition>().isAdjacent;
    }
}
