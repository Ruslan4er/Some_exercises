﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            TextEditor textEditor = new TextEditor();
            Compiller compiller = new Compiller();
            CLR clr = new CLR();

            VisualStudioFacade ide = new VisualStudioFacade(textEditor, compiller, clr);

            Programmer programmer = new Programmer();
            programmer.CreateApplication(ide);

            Console.Read();
        }
    }
}
