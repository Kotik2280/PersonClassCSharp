using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    abstract public class ID
    {
        private List<string> ids = new List<string>(); //Список существующих ID

        protected string CreateID(int format = 4)
        {
            Random rnd = new Random();

            string id = "";

            for (int i = 0; i < format; i++)
            {
                id += rnd.Next(0, 10);
            }

            //Создание ID до тех пор, пока он не будет уникальным
            while (CheckID(id))
            {
                for (int i = 0; i < format; i++)
                {
                    id += rnd.Next(0, 10);
                }
            }

            ids.Add(id);

            return id;
        }

        //Проверка уникальности ID
        private bool CheckID(string id)
        {
            for (int i = 0; i < ids.Count; i++)
            {
                if (ids[i] == id)
                    return true;
            }

            return false;
        }
    }
}
