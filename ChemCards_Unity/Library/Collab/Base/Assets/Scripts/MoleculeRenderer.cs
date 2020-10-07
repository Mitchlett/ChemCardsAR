using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class MoleculeRenderer : MonoBehaviour
{
    private bool isBuilding;
    private GameObject[] targets;
    // Start is called before the first frame update
    void Start()
    {
        isBuilding = false;
        targets[0] = GameObject.find("Carbon1");
        targets[1] = GameObject.find("Carbon2");
        targets[2] = GameObject.find("Carbon3");
        targets[3] = GameObject.find("Hydrogen1");
        targets[4] = GameObject.find("Hydrogen2");
        targets[5] = GameObject.find("Hydrogen3");
        targets[6] = GameObject.find("Oxygen1");
        targets[7] = GameObject.find("Oxygen2");
        targets[8] = GameObject.find("Oxygen3");
    }

    // Update is called once per frame
    void Update()
    {
        foreach (var tar in targets)
        {
            TrackableBehavior status = tar.GetComponent<DefaultTrackableEventHandler>().mTrackableBehavior.CurrentStatus;
            if (status == TrackableBehaviour.Status.DETECTED ||
            status == TrackableBehaviour.Status.TRACKED ||
            status == TrackableBehaviour.Status.EXTENDED_TRACKED)
            {
                isBuilding = true;
                BuildMolecule(tar);
            }
    }
}
