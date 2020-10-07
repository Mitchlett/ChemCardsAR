using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class MoleculeRenderer : MonoBehaviour
{
    private bool isBuilding;
    private GameObject[] targets = new GameObject[9];
    // Start is called before the first frame update
    void Start()
    {
        isBuilding = false;
        targets[0] = GameObject.Find("Carbon");
        targets[1] = GameObject.Find("Hydrogen");
        targets[2] = GameObject.Find("Oxygen");
    }

    // Update is called once per frame
    void Update()
    {
        foreach (var tar in targets)
        {
            bool status = tar.GetComponent<NewTrackableEventHandler>().tracked;
            if (status == true && isBuilding == false)
            {
                isBuilding = true;
                BuildMolecule(tar);
            }
        }
    }

    void BuildMolecule(GameObject target)
    {
        Debug.Log("Building molecule");
    }
}
