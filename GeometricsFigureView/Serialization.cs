using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using GeometricsFigure;

namespace GeometricsFigureView
{
    public static class Serialization
    {
        private static readonly BinaryFormatter _formatter = new BinaryFormatter();

        public static void Serialize(string fileName, List<IFigure> file)
        {
            using (var fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                _formatter.Serialize(fs, file);
            }
        }

        public static List<IFigure> Deserialize(string fileName)
        {
            using (var fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                var file = (List<IFigure>)_formatter.Deserialize(fs);
                return file;
            }
        }
    }
}
