using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Unity.Robotics.ROSTCPConnector;
using RosMove = RosMessageTypes.Std.Float64MultiArrayMsg;
public class rosSub : MonoBehaviour
{
    public GameObject robot;

    private ArticulationBody[] articulationChain;
    // Start is called before the first frame update
    void Start()
    {
        articulationChain = robot.GetComponentsInChildren<ArticulationBody>();
        //Debug.Log("lenght: " +articulationChain.Length);
        ROSConnection.GetOrCreateInstance().Subscribe<RosMove>("/dsr01/dsr_joint_position_controller/command", moveRobot);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void moveRobot(RosMove moveMessage)
    {
        
        RobotController robotController = robot.GetComponent<RobotController>();
        for (int i = 0; i < robotController.joints.Length; i++)
        {
           // Debug.Log("on a recu un msg: " + Convert.ToSingle(moveMessage.data[i]*180.0/3.1415));
            robotController.UpdatePositionState(Convert.ToSingle(moveMessage.data[i]*180.0/3.1415), robotController.joints[i].robotPart);
            
        }
        //ArticulationBody joint = articulationChain[i];
        //ArticulationDrive drive = joint.xDrive;
        
    }
}
