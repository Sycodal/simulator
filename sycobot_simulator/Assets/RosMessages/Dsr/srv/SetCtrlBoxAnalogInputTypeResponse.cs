//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Dsr
{
    [Serializable]
    public class SetCtrlBoxAnalogInputTypeResponse : Message
    {
        public const string k_RosMessageName = "dsr_msgs/SetCtrlBoxAnalogInputType";
        public override string RosMessageName => k_RosMessageName;

        public bool success;

        public SetCtrlBoxAnalogInputTypeResponse()
        {
            this.success = false;
        }

        public SetCtrlBoxAnalogInputTypeResponse(bool success)
        {
            this.success = success;
        }

        public static SetCtrlBoxAnalogInputTypeResponse Deserialize(MessageDeserializer deserializer) => new SetCtrlBoxAnalogInputTypeResponse(deserializer);

        private SetCtrlBoxAnalogInputTypeResponse(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.success);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.success);
        }

        public override string ToString()
        {
            return "SetCtrlBoxAnalogInputTypeResponse: " +
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
