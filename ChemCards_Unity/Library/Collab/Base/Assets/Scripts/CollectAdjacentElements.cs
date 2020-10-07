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
        northElement = selectedObject.transform.FindChild("North").GetComponent<AdjacentElementRecognition>().isAdjacent();
        eastElement = selectedObject.transform.FindChild("East").GetComponent<AdjacentElementRecognition>().isAdjacent();
        southElement = selectedObject.transform.FindChild("South").GetComponent<AdjacentElementRecognition>().isAdjacent();
        westElement = selectedObject.transform.FindChild("West").GetComponent<AdjacentElementRecognition>().isAdjacent();
    }

    // Update is called once per frame
    void Update()
    {
        northElement = selectedObject.transform.FindChild("North").GetComponent<AdjacentElementRecognition>().isAdjacent();
        eastElement = selectedObject.transform.FindChild("East").GetComponent<AdjacentElementRecognition>().isAdjacent();
        southElement = selectedObject.transform.FindChild("South").GetComponent<AdjacentElementRecognition>().isAdjacent();
        westElement = selectedObject.transform.FindChild("West").GetComponent<AdjacentElementRecognition>().isAdjacent();
    }
}
