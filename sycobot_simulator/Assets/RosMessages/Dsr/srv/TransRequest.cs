//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Dsr
{
    [Serializable]
    public class TransRequest : Message
    {
        public const string k_RosMessageName = "dsr_msgs/Trans";
        public override string RosMessageName => k_RosMessageName;

        // ____________________________________________________________________________________________
        //  trans  
        // ____________________________________________________________________________________________
        public double[] pos;
        //  task pos(posx)  
        public double[] delta;
        //  delta (posx)  
        public sbyte @ref;
        // = 0      # DR_BASE(0), DR_TOOL(1), DR_WORLD(2)
        //  <DR_WORLD is only available in M2.40 or later> 
        public sbyte ref_out;
        // = 0      # DR_BASE(0), DR_WORLD(2)
        //  <ref_out is only available in M2.40 or later>

        public TransRequest()
        {
            this.pos = new double[6];
            this.delta = new double[6];
            this.@ref = 0;
            this.ref_out = 0;
        }

        public TransRequest(double[] pos, double[] delta, sbyte @ref, sbyte ref_out)
        {
            this.pos = pos;
            this.delta = delta;
            this.@ref = @ref;
            this.ref_out = ref_out;
        }

        public static TransRequest Deserialize(MessageDeserializer deserializer) => new TransRequest(deserializer);

        private TransRequest(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.pos, sizeof(double), 6);
            deserializer.Read(out this.delta, sizeof(double), 6);
            deserializer.Read(out this.@ref);
            deserializer.Read(out this.ref_out);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.pos);
            serializer.Write(this.delta);
            serializer.Write(this.@ref);
            serializer.Write(this.ref_out);
        }

        public override string ToString()
        {
            return "TransRequest: " +
            "\npos: " + System.String.Join(", ", pos.ToList()) +
            "\ndelta: " + System.String.Join(", ", delta.ToList()) +
            "\n@ref: " + @ref.ToString() +
            "\nref_out: " + ref_out.ToString();
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
