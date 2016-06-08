using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using XmlConverter.Interface;

namespace XmlConverter.CoreImplementation
{
    public class GenericConverter<T> : IConverter<T> where T : class
    {
        readonly string FilePath;

        public GenericConverter(string filePath)
        {
            if (string.IsNullOrEmpty(filePath))
                throw new ArgumentNullException("The file path is null or empty");


            this.FilePath = filePath.ToString();
        }

        /// <summary>
        /// Generate an Xml file
        /// </summary>
        /// <typeparam name="T">the type of data</typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool GenereateXml<T>(T value)
        {
            try
            {
                XmlSerializer serialiser = new XmlSerializer(typeof(T));
                using (TextWriter Filestream = new StreamWriter(FilePath))
                {
                    serialiser.Serialize(Filestream, value);
                }

                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }


    }
}
