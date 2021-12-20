using PocAwsSnsCore.Core;
using System;
using System.Windows.Forms;

namespace PocAwsSnsPublisher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            var x = new TopicSend().Send(txtInput.Text);
            lvItems.Items.Add(txtInput.Text);
            lvItems.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
        }
    }
}
