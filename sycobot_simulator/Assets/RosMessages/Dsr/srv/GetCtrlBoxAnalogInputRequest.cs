//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Dsr
{
    [Serializable]
    public class GetCtrlBoxAnalogInputRequest : Message
    {
        public const string k_RosMessageName = "dsr_msgs/GetCtrlBoxAnalogInput";
        public override string RosMessageName => k_RosMessageName;

        // ____________________________________________________________________________________________
        //  get_analog_input 
        // ____________________________________________________________________________________________
        public sbyte channel;
        //  1 = ch1, 2= ch2

        public GetCtrlBoxAnalogInputRequest()
        {
            this.channel = 0;
        }

        public GetCtrlBoxAnalogInputRequest(sbyte channel)
        {
            this.channel = channel;
        }

        public static GetCtrlBoxAnalogInputRequest Deserialize(MessageDeserializer deserializer) => new GetCtrlBoxAnalogInputRequest(deserializer);

        private GetCtrlBoxAnalogInputRequest(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.channel);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.channel);
        }

        public override string ToString()
        {
            return "GetCtrlBoxAnalogInputRequest: " +
            "\nchannel: " + channel.ToString();
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
