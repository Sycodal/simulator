//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Dsr
{
    [Serializable]
    public class CheckMotionResponse : Message
    {
        public const string k_RosMessageName = "dsr_msgs/CheckMotion";
        public override string RosMessageName => k_RosMessageName;

        public sbyte status;
        //  DR_STATE_IDLE(0) : no motion in action
        //  DR_STATE_INIT(1) : motion being calculated
        //  DR_STATE_BUSY(2) : motion in operation
        public bool success;

        public CheckMotionResponse()
        {
            this.status = 0;
            this.success = false;
        }

        public CheckMotionResponse(sbyte status, bool success)
        {
            this.status = status;
            this.success = success;
        }

        public static CheckMotionResponse Deserialize(MessageDeserializer deserializer) => new CheckMotionResponse(deserializer);

        private CheckMotionResponse(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.status);
            deserializer.Read(out this.success);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.status);
            serializer.Write(this.success);
        }

        public override string ToString()
        {
            return "CheckMotionResponse: " +
            "\nstatus: " + status.ToString() +
            "\nsuccess: " + success.ToString();
        }

#if UNITY_EDITOR
        [UnityEditor.InitializeOnLoadMethod]
#else
        [UnityEngine.RuntimeInitializeOnLoadMethod]
#endif
        public static void Register()
        {
            MessageRegistry.Register(k_RosMessageName, Deserialize, MessageSubtopic.Response);
        }
    }
}