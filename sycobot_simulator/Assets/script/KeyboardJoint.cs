using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardJoint : MonoBehaviour
{
    public GameObject robot;
    public int jointNb;

    public float position;

    void Start()
    {
        RobotController robotController = robot.GetComponent<RobotController>();
        robotController.ResetAllJointPosition();
		Debug.Log("nb de joint : " + robotController.joints.Length);
    }
    void Update()
    {
        RobotController robotController = robot.GetComponent<RobotController>();
        robotController.UpdatePositionState(position, robotController.joints[jointNb].robotPart);
    }
}