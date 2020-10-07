using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Bonding : MonoBehaviour
{
    private TextMeshPro bindingText;
    private List<string> adjacents;
    // Start is called before the first frame update
    void Start()
    {
        bindingText = gameObject.GetComponent<TextMeshPro>();
        adjacents = new List<string>();
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        switch (other.tag) {
            case "Carbon":
                bindingText.enabled = true;
                Debug.Log("Bonding");
                adjacents.Add("Carbon");
                break;
            case "Hydrogen":
                bindingText.enabled = true;
                Debug.Log("Bonding");
                adjacents.Add("Hydrogen");
                break;
            case "Oxygen":
                bindingText.enabled = true;
                Debug.Log("Bonding");
                adjacents.Add("Oxygen");
                break;
            default:
                break;
        }

    }

    void OnTriggerExit(Collider other)
    {
        bindingText.enabled = false;
        for (var i=0; i<adjacents.Count; i++)
        {
            if (adjacents[i] == other.tag) {
                for (var j=i; j<adjacents.Count; j++)
                {
                    adjacents[j] = adjacents[j + 1];
                }
                break;
            }
        }
    }
}
