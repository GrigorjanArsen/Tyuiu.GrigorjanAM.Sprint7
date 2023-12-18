using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Tyuiu.GrigorjanAM.Sprint7.Project.V9.Lib
{
    public class DataService
    {
        public string[,] LoadDataSet(string path)
        {
            string[] words = File.ReadAllLines(path, Encoding.GetEncoding(1251));
            int columns = words[0].Split(';').Length;
            int rows = words.Length;
            string[,] basa = new string[rows, columns];
            for (int i = 0; i < words.Length; i++)
            {
                string numIndex = words[i];
                string[] numArray = numIndex.Split(';');
                for (int j = 0; j < numArray.Length; j++) basa[i, j] = numArray[j];
            }
            return basa;
        }
    }
}
