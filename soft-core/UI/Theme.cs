using System.Drawing;
using System.Windows.Forms;

namespace soft_core.UI
{
    public static class Theme
    {
        public static readonly Color Primary = Color.FromArgb(28, 67, 95);
        public static readonly Color Accent = Color.FromArgb(244, 245, 246);
        public static readonly Color Background = Color.FromArgb(250, 250, 251);
        public static readonly Color Card = Color.White;
        public static readonly Font DefaultFont = new Font("Segoe UI", 9F);

        public static void ApplyForm(Form f)
        {
            f.BackColor = Background;
            f.Font = DefaultFont;
        }

        public static void ApplyPrimaryButton(Button b)
        {
            b.BackColor = Primary;
            b.ForeColor = Color.White;
            b.FlatStyle = FlatStyle.Flat;
            b.FlatAppearance.BorderSize = 0;
            b.Font = new Font(DefaultFont.FontFamily, 9F, FontStyle.Bold);
        }

        public static void ApplyAccentLabel(Label l)
        {
            l.ForeColor = Primary;
            l.Font = new Font(DefaultFont.FontFamily, 10F, FontStyle.Bold);
        }

        public static void ApplyDataGridView(DataGridView dg)
        {
            dg.BackgroundColor = Card;
            dg.EnableHeadersVisualStyles = false;
            dg.ColumnHeadersDefaultCellStyle.BackColor = Accent;
            dg.RowTemplate.Height = 28;
            dg.Font = DefaultFont;
        }
    }
}
