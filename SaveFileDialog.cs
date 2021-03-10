using System;
using System.IO;

namespace _071120
{
    internal class SaveFileDialog
    {
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