using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;

namespace Hoo.Relaxant {
    partial class AboutBox : Form {
        public AboutBox() {
            InitializeComponent();

            //  Initialize the AboutBox to display the product information from the assembly information.
            //  Change assembly information settings for your application through either:
            //  - Project->Properties->Application->Assembly Information
            //  - AssemblyInfo.cs
            this.Text = String.Format("About {0}", AssemblyInfo.Title);
            this.labelProductName.Text = AssemblyInfo.Product;
            this.labelVersion.Text = String.Format("Version {0}", AssemblyInfo.Version);
            this.labelCopyright.Text = AssemblyInfo.Copyright;
            this.labelCompanyName.Text = AssemblyInfo.Company;
            this.textBoxDescription.Text = AssemblyInfo.Description;
        }

        
    }
}
