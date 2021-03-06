//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Dsr
{
    [Serializable]
    public class SetUserCartCoord3Request : Message
    {
        public const string k_RosMessageName = "dsr_msgs/SetUserCartCoord3";
        public override string RosMessageName => k_RosMessageName;

        // ____________________________________________________________________________________________
        //  set_user_cart_coord(u1, v1, pos, ref) 
        // ____________________________________________________________________________________________
        public double[] u1;
        //  X-axis unit vector  
        public double[] v1;
        //  Y-axis unit vector 
        public double[] pos;
        //  task pos(posx) 
        public sbyte @ref;
        //  DR_BASE(0), DR_WORLD(2)
        //  <ref is only available in M2.40 or later> 

        public SetUserCartCoord3Request()
        {
            this.u1 = new double[3];
            this.v1 = new double[3];
            this.pos = new double[6];
            this.@ref = 0;
        }

        public SetUserCartCoord3Request(double[] u1, double[] v1, double[] pos, sbyte @ref)
        {
            this.u1 = u1;
            this.v1 = v1;
            this.pos = pos;
            this.@ref = @ref;
        }

        public static SetUserCartCoord3Request Deserialize(MessageDeserializer deserializer) => new SetUserCartCoord3Request(deserializer);

        private SetUserCartCoord3Request(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.u1, sizeof(double), 3);
            deserializer.Read(out this.v1, sizeof(double), 3);
            deserializer.Read(out this.pos, sizeof(double), 6);
            deserializer.Read(out this.@ref);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.u1);
            serializer.Write(this.v1);
            serializer.Write(this.pos);
            serializer.Write(this.@ref);
        }

        public override string ToString()
        {
            return "SetUserCartCoord3Request: " +
            "\nu1: " + System.String.Join(", ", u1.ToList()) +
            "\nv1: " + System.String.Join(", ", v1.ToList()) +
            "\npos: " + System.String.Join(", ", pos.ToList()) +
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
