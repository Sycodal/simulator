//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Dsr
{
    [Serializable]
    public class FkinResponse : Message
    {
        public const string k_RosMessageName = "dsr_msgs/Fkin";
        public override string RosMessageName => k_RosMessageName;

        public double[] conv_posx;
        //  task pos(posx)
        public bool success;

        public FkinResponse()
        {
            this.conv_posx = new double[6];
            this.success = false;
        }

        public FkinResponse(double[] conv_posx, bool success)
        {
            this.conv_posx = conv_posx;
            this.success = success;
        }

        public static FkinResponse Deserialize(MessageDeserializer deserializer) => new FkinResponse(deserializer);

        private FkinResponse(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.conv_posx, sizeof(double), 6);
            deserializer.Read(out this.success);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.conv_posx);
            serializer.Write(this.success);
        }

        public override string ToString()
        {
            return "FkinResponse: " +
            "\nconv_posx: " + System.String.Join(", ", conv_posx.ToList()) +
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