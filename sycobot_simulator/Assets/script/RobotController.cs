using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotController : MonoBehaviour
{
    [System.Serializable]
    public struct Joint
    {
        public string inputAxis;
        public GameObject robotPart;
    }
    public Joint[] joints;
    
    public void ResetAllJointPosition()
    {
        for (int i = 0; i < joints.Length; i++)
        {
            GameObject robotPart = joints[i].robotPart;
            UpdatePositionState(0, robotPart);
        }
    }
    
    public void MoveJoint(int jointIndex, float position)
    {
        //StopAllJointRotations();
        Joint joint = joints[jointIndex];
        UpdatePositionState(position, joint.robotPart);
    }

    // HELPERS

    public void UpdatePositionState(float position, GameObject robotPart)
    {
        ArticulationJointController jointController = robotPart.GetComponent<ArticulationJointController>();
        jointController.position = position;
    }
}
