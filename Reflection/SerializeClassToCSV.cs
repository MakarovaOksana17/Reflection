using Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace Reflections
{
    public class SerializeClassToCSV : ISerialaze
    {
        public bool deSerialized(string classN)
        {
            string clName = classN.Replace("{", " ").Replace("}", " ").Replace("\"", "").Split(':')[0].Trim(); 
            Type namespaceType = Type.GetType($"{"Reflections"}.{clName}", true, true);
            object oClass = Activator.CreateInstance(namespaceType);
            foreach (var n in classN.Replace("{", " ").Replace("}", " ").Replace("\"", "").Replace(clName + ":", "").Split(','))
            {
                setValueProperty(n.Split(':')[0].Trim(), n.Split(':')[1].Trim(), oClass);                
            }
            if (oClass != null)
                return true;
            return false;
        }

        public string serialized(object classN)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("{\"" + classN.GetType().Name + "\":{");
            foreach (var prop in classN.GetType().GetProperties())
            {
                stringBuilder.Append($"\"{prop.Name}\": \"{prop.GetValue(classN)}\",");
            }
            stringBuilder.Remove(stringBuilder.Length - 1, 1);
            stringBuilder.Append("}}");

            if (stringBuilder != null)
            {
                return stringBuilder.ToString();
            }

            return "Не получилось";
        }

        private void setValueProperty(string name, string value, object type)
        {
            foreach (var prop in type.GetType().GetProperties())
            {
                if (prop.Name == name) { prop.SetValue(type, value, null); }
            }
        }
    }
}
