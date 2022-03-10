using UnityEngine;
using Unity.Robotics.ROSTCPConnector;
using RosMove = RosMessageTypes.Std.Float64MultiArrayMsg;

public class RosSubscriberExample : MonoBehaviour
{
    public GameObject robot;

    private ArticulationBody[] articulationChain;
    void Start()
    {
        //Debug.Log("Text: " + myText.text);
        
        articulationChain = robot.GetComponentsInChildren<ArticulationBody>();
        //Debug.Log("lenght: " +articulationChain.Length);
        ROSConnection.GetOrCreateInstance().Subscribe<RosMove>("/dsr01/dsr_joint_position_controller/command", moveRobot);
    }

    void moveRobot(RosMove moveMessage)
    {
        //ArticulationBody joint = articulationChain[i].;
        //ArticulationDrive drive = joint.xDrive;
        
    }
}