using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CraigslistClone.BLL.Interfaces;
using Ninject;
using System.Reflection;

namespace CraigslistClone.BLL.Factories
{
    public class DisplayerFactory
    {
        public IDisplayer Displayer { get; set; }

        public DisplayerFactory(IDisplayer displayer)
        {
            this.Displayer = displayer;
            BindDisplayer();
        }

        private void BindDisplayer()
        {
            Displayer.ExecuteOperation();  
        }

    }
}
