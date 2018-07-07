﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ProxySwitcher.Models.Misc
{
    public class OnPostSaveArgs<T> : EventArgs
    {
        public T Model { get; set; }
        public bool Success { get; set; }

        public OnPostSaveArgs() { }
        public OnPostSaveArgs(T model, bool success)
        {
            Model = model;
            Success = success;
        }
    }
}
