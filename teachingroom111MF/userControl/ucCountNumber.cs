using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teachingroom111MF.userControl
{
    public partial class ucCountNumber : UserControl
    {

        [Browsable(true)] // Makes it visible in the Visual Studio Property Grid
        [Category("CustomePropety")] // Groups it under a specific category in the designer
        public string InforText
        {
            get => lblInform.Text;
            set => lblInform.Text = value;
        }

        [Browsable(true)] // Makes it visible in the Visual Studio Property Grid
        [Category("CustomePropety")] // Groups it under a specific category in the designer
        public string Counts
        {
            get => lblCount.Text;
            set => lblCount.Text = value;
        }

        [Browsable(true)] // Makes it visible in the Visual Studio Property Grid
        [Category("CustomePropety")] // Groups it under a specific category in the designer
        public string Photos
        {
            get => ptbimage.ImageLocation;
            set => ptbimage.ImageLocation = value;
        }


        public ucCountNumber()
        {
            InitializeComponent();
        }

    }
}
