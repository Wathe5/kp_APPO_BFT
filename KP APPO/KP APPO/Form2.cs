using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KP_APPO
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void setGroupBoxState(bool gb1, bool gb2, bool gb3)
        {
            groupBox1.Visible = gb1;
            groupBox2.Visible = gb2;
            groupBox3.Visible = gb3;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCreateConst_Click(object sender, EventArgs e)
        {
            try
            {
                BFT_Creator bftC = new BFT_Creator();
                Form1 firstForm = this.Owner as Form1;
                if (String.IsNullOrEmpty(textBoxConstData.Text)
                 || textBoxConstData.Text.Contains("[") || textBoxConstData.Text.Contains("]"))
                    MessageBox.Show("Строка пуста или содержит запрещённые [ ]", "Achtung!");
                else
                {
                    firstForm.insertText(bftC.createConst(textBoxConstData.Text));
                    this.Close();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString(), "Achtung!");
            }

        }

        private void buttonCreateVar_Click(object sender, EventArgs e)
        {
            try
            {
                BFT_Creator bftC = new BFT_Creator();
                Form1 firstForm = this.Owner as Form1;
                if (String.IsNullOrEmpty(textBoxVarName.Text) || String.IsNullOrEmpty(textBoxVarData.Text)
                 || textBoxVarName.Text.Contains("[") || textBoxVarName.Text.Contains("]")
                 || textBoxVarData.Text.Contains("[") || textBoxVarData.Text.Contains("]"))
                    MessageBox.Show("Строки пусты или содержат запрещённые [ ]", "Achtung!");
                else
                {
                    firstForm.insertText(bftC.createVariable(textBoxVarName.Text, textBoxVarData.Text));
                    this.Close();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString(), "Achtung!");
            }

        }

        private void buttonCreateLink_Click(object sender, EventArgs e)
        {
            try
            {
                BFT_Creator bftC = new BFT_Creator();
                Form1 firstForm = this.Owner as Form1;
                if (String.IsNullOrEmpty(textBoxLinkName.Text) || String.IsNullOrEmpty(textBoxLinkData.Text)
                 || textBoxLinkName.Text.Contains("[") || textBoxLinkName.Text.Contains("]")
                 || textBoxLinkData.Text.Contains("[") || textBoxLinkData.Text.Contains("]"))
                    MessageBox.Show("Строки пусты или содержат запрещённые [ ]", "Achtung!");
                else
                {
                    firstForm.insertText(bftC.createLink(textBoxLinkName.Text, textBoxLinkData.Text));
                    this.Close();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString(), "Achtung!");
            }

        }
    }
}
