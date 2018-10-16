﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace TWSLib
{
    [ComVisible(true)]
    public interface ISmartComponent
    {
        int BitNumber { get; }
        string Exchange { get; }
        string ExchangeLetter { get; }
    }

    [ComVisible(true), ClassInterface(ClassInterfaceType.None)]
    public class ComSmartComponent : ComWrapper<KeyValuePair<int, KeyValuePair<string, char>>>, ISmartComponent
    {
        public ComSmartComponent()
        {
        }

        public ComSmartComponent(KeyValuePair<int, KeyValuePair<string, char>> theMap)
        {
            data = new KeyValuePair<int, KeyValuePair<string, char>>(theMap.Key, theMap.Value);
        }

        public int BitNumber { get { return data.Key; } }

        public string Exchange { get { return data.Value.Key; } }

        public string ExchangeLetter { get { return data.Value.Value + ""; } }
    }
}
