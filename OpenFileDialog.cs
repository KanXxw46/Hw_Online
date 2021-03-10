using System;
using System.IO;

namespace _071120
{
    internal class OpenFileDialog
    {
        public string InitialDirectory { get; internal set; }
        public string Filter { get; internal set; }
        public int FilterIndex { get; internal set; }
        public bool RestoreDirectory { get; internal set; }

        internal object ShowDialog()
        {
            throw new NotImplementedException();
        }

        internal Stream OpenFile()
        {
            throw new NotImplementedException();
        }
    }
}