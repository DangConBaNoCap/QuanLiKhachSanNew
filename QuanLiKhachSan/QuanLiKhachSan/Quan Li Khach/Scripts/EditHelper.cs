using DevExpress.Utils.Controls;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiKhachSan.Quan_Li_Khach.Scripts
{
    public static class EditHelper
    {
        private static Dictionary<Type, Action<Control>> controldefaults = new Dictionary<Type, Action<Control>>() {
            {typeof(TextBox), c => ((TextBox)c).Clear()},
            {typeof(CheckBox), c => ((CheckBox)c).Checked = false},
            {typeof(ListBox), c => ((ListBox)c).Items.Clear()},
            {typeof(RadioButton), c => ((RadioButton)c).Checked = false},
            {typeof(GroupBox), c => ((GroupBox)c).Controls.ClearControls()},
            {typeof(Panel), c => ((Panel)c).Controls.ClearControls()},
            {typeof(TextEdit), c => ((TextEdit)c).ResetText()},
            {typeof(GridControl), c => ((GridControl)c).Controls.ClearControls()},
            {typeof(DateEdit), c => ((DateEdit)c).ResetText()},
            {typeof(GridLookUpEdit), c => ((GridLookUpEdit)c).ResetText()}
    };

        private static void FindAndInvoke(Type type, Control control)
        {
            if (controldefaults.ContainsKey(type))
            {
                controldefaults[type].Invoke(control);
            }
        }

        public static void ClearControls(this Control.ControlCollection controls)
        { 
            foreach (Control control in controls)
            {
                if(control.GetType()==typeof(RibbonControl))
                {
                    foreach (Control subcontrol in control.Controls)
                        FindAndInvoke(subcontrol.GetType(), control);
                }
                
            }
        }

        public static void ClearControls<T>(this Control.ControlCollection controls) where T : class
        {
            if (!controldefaults.ContainsKey(typeof(T))) return;

            foreach (Control control in controls)
            {
                if (control.GetType().Equals(typeof(T)))
                {
                    FindAndInvoke(typeof(T), control);
                }
            }

        }
    }
}
