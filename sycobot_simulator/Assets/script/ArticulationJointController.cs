using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArticulationJointController : MonoBehaviour
{
    // Start is called before the first frame update
    private ArticulationBody articulation;
    public float position = 0.0f;

    void Start()
    {
        articulation = GetComponent<ArticulationBody>();
    }

    // Update is called once per frame
    void FixedUpdate() 
    {
        Debug.Log("joint " + articulation.name + ": " + position);
        var drive = articulation.xDrive;
        drive.target = position;
        articulation.xDrive = drive;
    }
    


}
