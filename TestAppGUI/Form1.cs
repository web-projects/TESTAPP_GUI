using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestAppGUI
{
    public partial class Form1 : Form
    {
        Font fontComboBox = new Font("MS Sans Serif", 10, FontStyle.Regular);
        Font fontUnderline = new Font("Aerial", 10, FontStyle.Underline | FontStyle.Regular);
        Font fontStrikeThrough = new Font("Aerial", 10, FontStyle.Italic | FontStyle.Strikeout);

        private static readonly string startAdaMode = "Start ADA Mode";
        private static readonly string endAdaMode = "End ADA Mode";
        private static readonly string updateMessage = "Update Message";

        private string [] disabledActionItems = new string [] { endAdaMode, updateMessage };

        public Form1()
        {
            InitializeComponent();

            this.actionsCB.DrawMode = DrawMode.OwnerDrawFixed;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetActions();
        }

        private void SetActions()
        {
            actionsCB.Items.Clear();
            actionsCB.Items.AddRange(new object[] 
            { 
                startAdaMode,
                updateMessage,
                endAdaMode 
            });
            actionsCB.SelectedIndex = actionsCB.Items.IndexOf(startAdaMode);

        }

        private void comboBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            string targetItem = actionsCB.Items[e.Index].ToString();
            if (disabledActionItems.Select(x => x).Where(y => y.Equals(targetItem)).Count() == 1)
            {
                e.Graphics.DrawString(actionsCB.Items[e.Index].ToString(), fontComboBox, Brushes.LightGray, e.Bounds);
            }
            else
            {
                e.DrawBackground();
                e.Graphics.DrawString(actionsCB.Items[e.Index].ToString(), fontComboBox, Brushes.Black, e.Bounds);
                e.DrawFocusRectangle();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string targetItem = actionsCB.Items[actionsCB.SelectedIndex].ToString();
            if (disabledActionItems.Select(x => x).Where(y => y.Equals(targetItem)).Count() == 1)
            {
                // find next selectable index
                for (int index = 0; index < actionsCB.Items.Count; index ++)
                {
                    targetItem = actionsCB.Items[index].ToString();
                    if (disabledActionItems.Select(x => x).Where(y => y.Equals(targetItem)).Count() == 0)
                    {
                        actionsCB.SelectedIndex = index;
                        break;
                    }
                }
            }
        }

        private void featureOn_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = sender as RadioButton;

            if (radio.Checked)
            {
                disabledActionItems = new string[] { startAdaMode };
                actionsCB.SelectedIndex = actionsCB.Items.IndexOf(endAdaMode);
            }
        }

        private void featureOff_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = sender as RadioButton;

            if (radio.Checked)
            {
                disabledActionItems = new string [] { endAdaMode, updateMessage };
                actionsCB.SelectedIndex = actionsCB.Items.IndexOf(startAdaMode);
            }
        }
    }
}
