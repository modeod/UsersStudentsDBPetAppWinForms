using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersStudentsDBForm
{
    public class ToolStripCheckedBox : ToolStripControlHost
    {
        public ToolStripCheckedBox() : base(new CheckBox())
        {

        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public CheckBox CheckBox
        {
            get { return (CheckBox)this.Control; }
        }
    }
}
