//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Dsr
{
    [Serializable]
    public class GetCurrentPosxResponse : Message
    {
        public const string k_RosMessageName = "dsr_msgs/GetCurrentPosx";
        public override string RosMessageName => k_RosMessageName;

        public Std.Float64MultiArrayMsg[] task_pos_info;
        //  task pos = task_pos_info[0][0:5], solution sapce = task_pos_info[0][6]
        public bool success;

        public GetCurrentPosxResponse()
        {
            this.task_pos_info = new Std.Float64MultiArrayMsg[0];
            this.success = false;
        }

        public GetCurrentPosxResponse(Std.Float64MultiArrayMsg[] task_pos_info, bool success)
        {
            this.task_pos_info = task_pos_info;
            this.success = success;
        }

        public static GetCurrentPosxResponse Deserialize(MessageDeserializer deserializer) => new GetCurrentPosxResponse(deserializer);

        private GetCurrentPosxResponse(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.task_pos_info, Std.Float64MultiArrayMsg.Deserialize, deserializer.ReadLength());
            deserializer.Read(out this.success);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.WriteLength(this.task_pos_info);
            serializer.Write(this.task_pos_info);
            serializer.Write(this.success);
        }

        public override string ToString()
        {
            return "GetCurrentPosxResponse: " +
            "\ntask_pos_info: " + System.String.Join(", ", task_pos_info.ToList()) +
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
