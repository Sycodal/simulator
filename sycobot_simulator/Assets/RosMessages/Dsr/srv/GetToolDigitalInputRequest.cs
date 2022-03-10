//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Dsr
{
    [Serializable]
    public class GetToolDigitalInputRequest : Message
    {
        public const string k_RosMessageName = "dsr_msgs/GetToolDigitalInput";
        public override string RosMessageName => k_RosMessageName;

        // ____________________________________________________________________________________________
        //  get_tool_digital_input  
        //  This service gets the current controlbox io output status.
        // ____________________________________________________________________________________________
        public sbyte index;
        //  Digital Input in Flange(1 ~ 6) 
        //  <GPIO_TOOL_DIGITAL_INDEX> 

        public GetToolDigitalInputRequest()
        {
            this.index = 0;
        }

        public GetToolDigitalInputRequest(sbyte index)
        {
            this.index = index;
        }

        public static GetToolDigitalInputRequest Deserialize(MessageDeserializer deserializer) => new GetToolDigitalInputRequest(deserializer);

        private GetToolDigitalInputRequest(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.index);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.index);
        }

        public override string ToString()
        {
            return "GetToolDigitalInputRequest: " +
            "\nindex: " + index.ToString();
        }

#if UNITY_EDITOR
        [UnityEditor.InitializeOnLoadMethod]
#else
        [UnityEngine.RuntimeInitializeOnLoadMethod]
#endif
        public static void Register()
        {
            MessageRegistry.Register(k_RosMessageName, Deserialize);
        }
    }
}