using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Media_Player
{
    [SuppressMessage("IntelliSenseCorrection", "IDE1006")]
    [SuppressMessage("IntelliSenseCorrection", "IDE0044")]
    [SuppressMessage("CodeQuality", "IDE0079:Remove unnecessary suppression", Justification = "<Pending>")]
    class FullScreen
    {
        Form TargetForm;
        FormWindowState storedWindowState;
        public FullScreen(Form targetForm)
        {
            TargetForm = targetForm;
        }

        public bool InFullScreen { get; set; } = false;
        public void EnterFullScreenMode()
        {
            TargetForm.MaximizeBox = false;
            TargetForm.MinimizeBox = false;
            storedWindowState = TargetForm.WindowState;
            TargetForm.WindowState = FormWindowState.Normal;
            TargetForm.FormBorderStyle = FormBorderStyle.None;
            TargetForm.WindowState = FormWindowState.Maximized;
            this.InFullScreen = true;
        }

        public void LeaveFullScreenMode()
        {
            TargetForm.MaximizeBox = true;
            TargetForm.MinimizeBox = true;
            TargetForm.FormBorderStyle = FormBorderStyle.Sizable;
            TargetForm.WindowState = storedWindowState;
            this.InFullScreen = false;
        }
    }
}
