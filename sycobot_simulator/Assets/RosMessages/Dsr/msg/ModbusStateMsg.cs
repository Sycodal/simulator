//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Dsr
{
    [Serializable]
    public class ModbusStateMsg : Message
    {
        public const string k_RosMessageName = "dsr_msgs/ModbusState";
        public override string RosMessageName => k_RosMessageName;

        // ____________________________________________________________________________________________
        // Custom msg for RobotState.msg -- MAX_SIZE = 100
        // ____________________________________________________________________________________________
        public string modbus_symbol;
        //  Modbus Signal Name
        public int modbus_value;
        //  Modbus Register Value (Unsigned : 0 ~ 65535)

        public ModbusStateMsg()
        {
            this.modbus_symbol = "";
            this.modbus_value = 0;
        }

        public ModbusStateMsg(string modbus_symbol, int modbus_value)
        {
            this.modbus_symbol = modbus_symbol;
            this.modbus_value = modbus_value;
        }

        public static ModbusStateMsg Deserialize(MessageDeserializer deserializer) => new ModbusStateMsg(deserializer);

        private ModbusStateMsg(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.modbus_symbol);
            deserializer.Read(out this.modbus_value);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.modbus_symbol);
            serializer.Write(this.modbus_value);
        }

        public override string ToString()
        {
            return "ModbusStateMsg: " +
            "\nmodbus_symbol: " + modbus_symbol.ToString() +
            "\nmodbus_value: " + modbus_value.ToString();
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
