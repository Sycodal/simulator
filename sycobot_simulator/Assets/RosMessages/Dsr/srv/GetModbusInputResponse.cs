//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Dsr
{
    [Serializable]
    public class GetModbusInputResponse : Message
    {
        public const string k_RosMessageName = "dsr_msgs/GetModbusInput";
        public override string RosMessageName => k_RosMessageName;

        public int value;
        //  modbus signal value
        public bool success;

        public GetModbusInputResponse()
        {
            this.value = 0;
            this.success = false;
        }

        public GetModbusInputResponse(int value, bool success)
        {
            this.value = value;
            this.success = success;
        }

        public static GetModbusInputResponse Deserialize(MessageDeserializer deserializer) => new GetModbusInputResponse(deserializer);

        private GetModbusInputResponse(MessageDeserializer deserializer)
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
            return "GetModbusInputResponse: " +
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
