//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Dsr
{
    [Serializable]
    public class GetCtrlBoxDigitalInputResponse : Message
    {
        public const string k_RosMessageName = "dsr_msgs/GetCtrlBoxDigitalInput";
        public override string RosMessageName => k_RosMessageName;

        public sbyte value;
        //  0=OFF, 1=ON
        public bool success;

        public GetCtrlBoxDigitalInputResponse()
        {
            this.value = 0;
            this.success = false;
        }

        public GetCtrlBoxDigitalInputResponse(sbyte value, bool success)
        {
            this.value = value;
            this.success = success;
        }

        public static GetCtrlBoxDigitalInputResponse Deserialize(MessageDeserializer deserializer) => new GetCtrlBoxDigitalInputResponse(deserializer);

        private GetCtrlBoxDigitalInputResponse(MessageDeserializer deserializer)
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
            return "GetCtrlBoxDigitalInputResponse: " +
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