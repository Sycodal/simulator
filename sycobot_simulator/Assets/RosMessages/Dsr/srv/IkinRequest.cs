//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Dsr
{
    [Serializable]
    public class IkinRequest : Message
    {
        public const string k_RosMessageName = "dsr_msgs/Ikin";
        public override string RosMessageName => k_RosMessageName;

        // ____________________________________________________________________________________________
        //  ikin  
        // ____________________________________________________________________________________________
        public double[] pos;
        //  task pos(posx)  
        public sbyte sol_space;
        //  solution space : 0 ~ 7
        public sbyte @ref;
        // = 0      # DR_BASE(0), DR_WORLD(2)
        //  <ref is only available in M2.40 or later> 

        public IkinRequest()
        {
            this.pos = new double[6];
            this.sol_space = 0;
            this.@ref = 0;
        }

        public IkinRequest(double[] pos, sbyte sol_space, sbyte @ref)
        {
            this.pos = pos;
            this.sol_space = sol_space;
            this.@ref = @ref;
        }

        public static IkinRequest Deserialize(MessageDeserializer deserializer) => new IkinRequest(deserializer);

        private IkinRequest(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.pos, sizeof(double), 6);
            deserializer.Read(out this.sol_space);
            deserializer.Read(out this.@ref);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.pos);
            serializer.Write(this.sol_space);
            serializer.Write(this.@ref);
        }

        public override string ToString()
        {
            return "IkinRequest: " +
            "\npos: " + System.String.Join(", ", pos.ToList()) +
            "\nsol_space: " + sol_space.ToString() +
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
