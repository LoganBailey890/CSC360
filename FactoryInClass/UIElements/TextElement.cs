using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using FactoryInClass.Interfaces;
using Newtonsoft.Json;

namespace FactoryInClass.UIElements
{
    public class TextElement : ICommonElement
    {
        string context = "";
        int height;
        int width;
        int top;
        int left;
        Dictionary<string, object> elementValues = new Dictionary<string, object>();
       
        public static string jsonString = "";

        public string GetContext()
        {
            return context;
        }

        public int GetHeight()
        {
            return height;
        }

        public int GetLeft()
        {
            return left;
        }

        public int GetTop()
        {
            return top;
        }

        public int GetWidth()
        {
            return width;
        }
        public void Write(string fileName)
        {

            if (!File.Exists(fileName))
            {
                FileStream stream = File.Create(fileName);
                stream.Close();
            }

            List<string> tempList = File.ReadAllLines(fileName).ToList();


            elementValues.Add("type", "textElement");
            elementValues.Add("context", context);
            elementValues.Add("height", height);
            elementValues.Add("width", width);
            elementValues.Add("top", top);
            elementValues.Add("left", left);

            jsonString = JsonConvert.SerializeObject(elementValues, Formatting.Indented);
            tempList.Add(jsonString);
            string ListToOnString = String.Join(",",tempList.ToArray());

            File.WriteAllText(fileName, ListToOnString);

        }

        public void SetContext(string context)
        {
            this.context = context;
        }

        public void SetWidth(int width)
        {
            this.width = width;
        }

        public void SetHeight(int height)
        {
            this.height = height;
        }

        public void SetTop(int top)
        {
            this.top = top;
        }

        public void SetLeft(int left)
        {
            this.left = left;
        }
    }
}
