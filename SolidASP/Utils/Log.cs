using System.IO;

namespace SolidASP.Utils
{
    public class Log
    {
        private readonly string _name = "log.txt";

        public async void Save(string content)
        {
            await File.WriteAllTextAsync(_name, content);
        }
    } 
}
