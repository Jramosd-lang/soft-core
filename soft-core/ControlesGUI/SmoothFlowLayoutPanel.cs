using System.Windows.Forms;

namespace soft_core.ControlesGUI
{
    /// <summary>
    /// FlowLayoutPanel con doble búfer para scroll más fluido.
    /// </summary>
    public class SmoothFlowLayoutPanel : FlowLayoutPanel
    {
        public SmoothFlowLayoutPanel()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer | 
                     ControlStyles.AllPaintingInWmPaint, true);
            UpdateStyles();
        }
    }
}
