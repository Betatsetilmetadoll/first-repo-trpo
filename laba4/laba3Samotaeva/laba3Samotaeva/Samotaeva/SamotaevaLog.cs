using System;
using System.Collections.Generic;
using System.Text;
using Core;


namespace Samotaeva
{
    class SamotaevaLog : LogAbstract, LogInterface
    {
        private static SamotaevaLog instance = null;
        static List<string> ListArr = new List<string>();


        //паттерн одиночка.Создает только один экз класса и дает к нему доступ.
        //
        public static SamotaevaLog getIntance()
        {
            if (instance == null)
                instance = new SamotaevaLog();
            return instance;
        }

        public LogInterface log(string str)
        {
            ListArr.Add(str);
            return this;
        }

        public LogInterface write()
        {
            writeConsole(ListArr.ToArray());
            return this;
        }
    }
}
