using Newtonsoft.Json;

namespace DotNetCore.AdminLTE.Scaffold.Utility
{
    public class Helper
    {

        /// <summary>
        /// Convert object to binary 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static byte[] Object2Bytes(object obj)
        {
            string json = JsonConvert.SerializeObject(obj);
            byte[] serializedResult = System.Text.Encoding.UTF8.GetBytes(json);
            return serializedResult;
        }

        /// <summary>
        /// Convert binary to object 
        /// </summary>
        /// <param name="buff"></param>
        /// <returns></returns>
        public static object Bytes2Object(byte[] buff)
        {
            string json = System.Text.Encoding.UTF8.GetString(buff);
            return JsonConvert.DeserializeObject<object>(json);
        }

        /// <summary>
        /// Convert binary to object(Generic)
        /// </summary>
        /// <param name="buff">被转换byte数组</param>
        /// <returns>转换完成后的对象</returns>
        public static T Bytes2Object<T>(byte[] buff)
        {
            string json = System.Text.Encoding.UTF8.GetString(buff);
            return JsonConvert.DeserializeObject<T>(json);
        }

    }
}
