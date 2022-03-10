//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Dsr
{
    [Serializable]
    public class GetToolDigitalOutputResponse : Message
    {
        public const string k_RosMessageName = "dsr_msgs/GetToolDigitalOutput";
        public override string RosMessageName => k_RosMessageName;

        public sbyte value;
        //  Current output status (0 : ON, 1 : OFF)
        public bool success;

        public GetToolDigitalOutputResponse()
        {
            this.value = 0;
            this.success = false;
        }

        public GetToolDigitalOutputResponse(sbyte value, bool success)
        {
            this.value = value;
            this.success = success;
        }

        public static GetToolDigitalOutputResponse Deserialize(MessageDeserializer deserializer) => new GetToolDigitalOutputResponse(deserializer);

        private GetToolDigitalOutputResponse(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.value);
            deserializer.Read(out this.success);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.value);
            serializer.Write(this.success);
        }

        public override string ToString()
        {
            return "GetToolDigitalOutputResponse: " +
            "\nvalue: " + value.ToString() +
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
