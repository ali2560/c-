using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReadSerial
{
    
    class Serial
    {
        SerialPort _serial = null;
        int baud = 115200;
        const int bufSize = 80;
        String port = "";
        Func<string, string> proccess = null;
        public Serial()
        {
            _serial = new SerialPort();
            _serial.BaudRate = baud;
         
        }

        public String[] getPorts()
        {
            return SerialPort.GetPortNames();
        }

        public void open(string port)
        {
            try
            {
                _serial.PortName = port;
                if (!_serial.IsOpen)
                    _serial.Open();
                Console.WriteLine("Waiting");
                _serial.DataReceived += _serial_DataReceived;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public void proccessor(Func<string, string> method)
        {
            this.proccess = method;
        }
       


        private void _serial_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string read = _serial.ReadLine();
            if (this.proccess != null) this.proccess(read);
        }

        public void close()
        {
            if (_serial.IsOpen)
                _serial.Close();
        }


    }
}
