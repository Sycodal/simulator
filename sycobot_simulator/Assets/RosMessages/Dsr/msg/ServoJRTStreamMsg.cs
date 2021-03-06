//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Dsr
{
    [Serializable]
    public class ServoJRTStreamMsg : Message
    {
        public const string k_RosMessageName = "dsr_msgs/ServoJRTStream";
        public override string RosMessageName => k_RosMessageName;

        // ____________________________________________________________________________________________
        //  servoj_rt
        //  
        // ____________________________________________________________________________________________
        public double[] pos;
        //  position  
        public double[] vel;
        //  velocity
        public double[] acc;
        //  acceleration
        public double time;
        //  time

        public ServoJRTStreamMsg()
        {
            this.pos = new double[6];
            this.vel = new double[6];
            this.acc = new double[6];
            this.time = 0.0;
        }

        public ServoJRTStreamMsg(double[] pos, double[] vel, double[] acc, double time)
        {
            this.pos = pos;
            this.vel = vel;
            this.acc = acc;
            this.time = time;
        }

        public static ServoJRTStreamMsg Deserialize(MessageDeserializer deserializer) => new ServoJRTStreamMsg(deserializer);

        private ServoJRTStreamMsg(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.pos, sizeof(double), 6);
            deserializer.Read(out this.vel, sizeof(double), 6);
            deserializer.Read(out this.acc, sizeof(double), 6);
            deserializer.Read(out this.time);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.pos);
            serializer.Write(this.vel);
            serializer.Write(this.acc);
            serializer.Write(this.time);
        }

        public override string ToString()
        {
            return "ServoJRTStreamMsg: " +
            "\npos: " + System.String.Join(", ", pos.ToList()) +
            "\nvel: " + System.String.Join(", ", vel.ToList()) +
            "\nacc: " + System.String.Join(", ", acc.ToList()) +
            "\ntime: " + time.ToString();
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
