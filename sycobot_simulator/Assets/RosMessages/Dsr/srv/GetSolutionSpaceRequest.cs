//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Dsr
{
    [Serializable]
    public class GetSolutionSpaceRequest : Message
    {
        public const string k_RosMessageName = "dsr_msgs/GetSolutionSpace";
        public override string RosMessageName => k_RosMessageName;

        // ____________________________________________________________________________________________
        //  get_solution_space(pos)  
        // ____________________________________________________________________________________________
        //  This service obtains the solution space value.
        public double[] pos;
        //  joint angle list [degree] 

        public GetSolutionSpaceRequest()
        {
            this.pos = new double[6];
        }

        public GetSolutionSpaceRequest(double[] pos)
        {
            this.pos = pos;
        }

        public static GetSolutionSpaceRequest Deserialize(MessageDeserializer deserializer) => new GetSolutionSpaceRequest(deserializer);

        private GetSolutionSpaceRequest(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.pos, sizeof(double), 6);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.pos);
        }

        public override string ToString()
        {
            return "GetSolutionSpaceRequest: " +
            "\npos: " + System.String.Join(", ", pos.ToList());
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
