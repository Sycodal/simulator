//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Dsr
{
    [Serializable]
    public class IkinExResponse : Message
    {
        public const string k_RosMessageName = "dsr_msgs/IkinEx";
        public override string RosMessageName => k_RosMessageName;

        public double[] conv_posj;
        //  joint pos(posj)  
        public bool status;
        public bool success;

        public IkinExResponse()
        {
            this.conv_posj = new double[6];
            this.status = false;
            this.success = false;
        }

        public IkinExResponse(double[] conv_posj, bool status, bool success)
        {
            this.conv_posj = conv_posj;
            this.status = status;
            this.success = success;
        }

        public static IkinExResponse Deserialize(MessageDeserializer deserializer) => new IkinExResponse(deserializer);

        private IkinExResponse(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.conv_posj, sizeof(double), 6);
            deserializer.Read(out this.status);
            deserializer.Read(out this.success);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.conv_posj);
            serializer.Write(this.status);
            serializer.Write(this.success);
        }

        public override string ToString()
        {
            return "IkinExResponse: " +
            "\nconv_posj: " + System.String.Join(", ", conv_posj.ToList()) +
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
