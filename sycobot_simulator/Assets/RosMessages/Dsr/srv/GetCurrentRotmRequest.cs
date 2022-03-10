//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Dsr
{
    [Serializable]
    public class GetCurrentRotmRequest : Message
    {
        public const string k_RosMessageName = "dsr_msgs/GetCurrentRotm";
        public override string RosMessageName => k_RosMessageName;

        // ____________________________________________________________________________________________
        //  get_current_rotm(ref)  
        // ____________________________________________________________________________________________
        //  This service returns the direction and matrix of the current tool based on the ref coordinate.
        public sbyte @ref;
        //  DR_BASE(0), DR_WORLD(2)

        public GetCurrentRotmRequest()
        {
            this.@ref = 0;
        }

        public GetCurrentRotmRequest(sbyte @ref)
        {
            this.@ref = @ref;
        }

        public static GetCurrentRotmRequest Deserialize(MessageDeserializer deserializer) => new GetCurrentRotmRequest(deserializer);

        private GetCurrentRotmRequest(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.@ref);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.@ref);
        }

        public override string ToString()
        {
            return "GetCurrentRotmRequest: " +
            "\n@ref: " + @ref.ToString();
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
