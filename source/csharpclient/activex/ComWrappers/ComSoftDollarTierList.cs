﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace TWSLib
{
    [ComVisible(true), ClassInterface(ClassInterfaceType.None)]
    public class ComSoftDollarTierList : IComList
    {
        private ComList<ComSoftDollarTier, IBApi.SoftDollarTier> sdtl;

        public ComSoftDollarTierList(List<IBApi.SoftDollarTier> list) 
        {
            sdtl = new ComList<ComSoftDollarTier, IBApi.SoftDollarTier>(list);
        }


        public object _NewEnum
        {
            get { return sdtl.GetEnumerator(); }
        }

        public object this[int index]
        {
            get { return sdtl[index]; }
        }

        public int Count
        {
            get { return sdtl.Count; }
        }

        public object Add()
        {
            var res = new ComSoftDollarTier();

            sdtl.Add(res);

            return res;
        }
    }
}
