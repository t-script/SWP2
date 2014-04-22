﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace swp_u2.Model
{
    class ModelShape
    {
        public enum type
        {
            Rectangle, Square, Ellipse, Circle, Triangle
        };

        public type Typ { get; set; }
        public Path myPath { get; set; }
        public Point pos { get; set; }
    }
}
