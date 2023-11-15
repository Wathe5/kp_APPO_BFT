using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace KP_APPO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            BFT_Elements bftE = new BFT_Elements();
            bftE.searchBFTtag(richTextBox1);
            treeView1.Nodes.Clear();
            treeView1.Nodes.Add(bftE.getTree());
            treeView1.ExpandAll();
        }


        // вставка нового бфт элемента и чтение всего текста заново
        public void insertText(string _text)
        {
            try
            {
                BFT_Elements bftE = new BFT_Elements();
                // запоминаем положение курсора
                int i = richTextBox1.SelectionStart;
                richTextBox1.Text = richTextBox1.Text.Insert(i, _text);
                // перемещаем курсор в конец тэга
                richTextBox1.SelectionStart = i + _text.Length;
                richTextBox1 = bftE.searchBFTtag(richTextBox1);
                treeView1.Nodes.Clear();
                treeView1.Nodes.Add(bftE.getTree());
                treeView1.ExpandAll();
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.ToString(), "Achtung!");
            }
        }


        // кнопка чтения тэгов
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                BFT_Elements bftE = new BFT_Elements();
                richTextBox1 = bftE.searchBFTtag(richTextBox1);
                treeView1.Nodes.Clear();
                // добавление древа тэгов на вывод
                treeView1.Nodes.Add(bftE.getTree());
                treeView1.ExpandAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString(), "Achtung!");
            }
        }
        private void buttonConstCreate_Click(object sender, EventArgs e)
        {
            try
            {
                Form2 secondForm = new Form2();
                // открывает возможность передачи данных и изменения их, при вызове из другой формы
                secondForm.Owner = this;
                secondForm.Show();
                secondForm.setGroupBoxState(true, false, false);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString(), "Achtung!");
            }
        }

        private void buttonVarCreate_Click(object sender, EventArgs e)
        {
            try
            {
                Form2 secondForm = new Form2();
                secondForm.Owner = this;
                secondForm.Show();
                secondForm.setGroupBoxState(false, true, false);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString(), "Achtung!");
            }
        }

        private void buttonLinkCreate_Click(object sender, EventArgs e)
        {
            try
            {
                Form2 secondForm = new Form2();
                secondForm.Owner = this;
                secondForm.Show();
                secondForm.setGroupBoxState(false, false, true);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString(), "Achtung!");
            }
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                BFT_Elements bftE = new BFT_Elements();
                OpenFileDialog openFile1 = new OpenFileDialog();

                // Ищем файлы формата .rtf
                openFile1.DefaultExt = "*.rtf";
                openFile1.Filter = "RTF Files|*.rtf|All Files|*.*";

                // Был ли выбран файл
                if (openFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                    openFile1.FileName.Length > 0)
                {
                    // Загружаем файл в rtb
                    richTextBox1.LoadFile(openFile1.FileName);
                    richTextBox1 = bftE.searchBFTtag(richTextBox1);
                    treeView1.Nodes.Clear();
                    treeView1.Nodes.Add(bftE.getTree());
                    treeView1.ExpandAll();
                    // создаем итератор и заполняем его
                    BFT_Iterator bftI = new BFT_Iterator();
                    bftI.addTree(bftE);
                    string message = null;
                    // собираем из него все BFT элементы
                    foreach (string tag in bftI)
                    {
                        message += tag + "\r\n";
                    }
                    MessageBox.Show(message, "Считанные BFT элементы:");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString(), "Achtung!");
            }

        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Сохраняем файл в формате .rtf
                SaveFileDialog saveFile1 = new SaveFileDialog();
                saveFile1.DefaultExt = "*.rtf";
                saveFile1.Filter = "RTF Files|*.rtf";
                // если ввели название файла
                if (saveFile1.ShowDialog() == DialogResult.OK && saveFile1.FileName.Length > 0)
                {
                    richTextBox1.SaveFile(saveFile1.FileName);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString(), "Achtung!");
            }
        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Вызываем диалог изменения шрифта
                BFT_Elements bftE = new BFT_Elements();
                FontDialog fd = new FontDialog();
                fd.Font = richTextBox1.Font;
                if (fd.ShowDialog() != DialogResult.Cancel)
                {
                    richTextBox1.Font = fd.Font;
                    richTextBox1 = bftE.searchBFTtag(richTextBox1);
                    treeView1.Nodes.Clear();
                    treeView1.Nodes.Add(bftE.getTree());
                    treeView1.ExpandAll();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString(), "Achtung!");
            }
        }

    }
}
