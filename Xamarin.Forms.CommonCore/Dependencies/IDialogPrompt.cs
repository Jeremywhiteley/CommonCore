﻿using System;
using System.Threading.Tasks;

namespace Xamarin.Forms.CommonCore
{
    public class Prompt
    {
        public string Title { get; set; }
        public string Message { get; set; }
        public string[] ButtonTitles { get; set; }
        public Action<bool> Callback { get; set; }
    }

    public interface IDialogPrompt
    {
        void ShowMessage(Prompt prompt);
        void ShowActionSheet(string title, string subTitle, string[] list, Action<int> callBack);
        void ShowToast(string message);
    }
}

