//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Dsr
{
    [Serializable]
    public class GetDrlStateResponse : Message
    {
        public const string k_RosMessageName = "dsr_msgs/GetDrlState";
        public override string RosMessageName => k_RosMessageName;

        public sbyte drl_state;
        //  <DRL_PROGRAM_STATE>
        public bool success;

        public GetDrlStateResponse()
        {
            this.drl_state = 0;
            this.success = false;
        }

        public GetDrlStateResponse(sbyte drl_state, bool success)
        {
            this.drl_state = drl_state;
            this.success = success;
        }

        public static GetDrlStateResponse Deserialize(MessageDeserializer deserializer) => new GetDrlStateResponse(deserializer);

        private GetDrlStateResponse(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.drl_state);
            deserializer.Read(out this.success);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.drl_state);
            serializer.Write(this.success);
        }

        public override string ToString()
        {
            return "GetDrlStateResponse: " +
            "\ndrl_state: " + drl_state.ToString() +
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
