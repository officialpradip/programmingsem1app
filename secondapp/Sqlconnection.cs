using System;
using System.Data;

namespace secondapp
{
    internal class Sqlconnection
    {
        public Sqlconnection()
        {
        }

        public string ConnecctionString { get; internal set; }
        public ConnectionState State { get; internal set; }

        internal void Open()
        {
            throw new NotImplementedException();
        }
    }
}