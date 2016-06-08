using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlConverter.Interface
{
    /// <summary>
    /// Converter Interface
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IConverter<T> where T : class
    {
        bool GenereateXml<T>(T value);
    }
}
