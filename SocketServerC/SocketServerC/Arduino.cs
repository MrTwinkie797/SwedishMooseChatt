using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocketServerC
{
    class Arduino
    {
        public void SendToArduino(string input)
        {
            SerialPort port = new SerialPort();
            port.PortName = "COM3";
            port.BaudRate = 9600;

            try
            {
                port.Open();

                if (port.IsOpen)
                {
                    port.Write(input);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
