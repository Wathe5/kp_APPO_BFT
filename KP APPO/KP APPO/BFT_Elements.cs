using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace KP_APPO
{
    class BFT_Elements 
    {
        // кол-во BFT элементов
        private int counter;
        // дерево, хранящее метки
        private TreeNode tags;
        public BFT_Elements()
        {
            counter = 0;
            // заполнение древа при создании объекта
            tags = new TreeNode("BFT-элементы");
            // 1[.] value1 0[0]
            tags.Nodes.Add(new TreeNode("Константы"));
            // 1[type] value2 0[0]
            tags.Nodes.Add(new TreeNode("Переменные"));
            // 0[type] value1..value2 0[0]
            tags.Nodes.Add(new TreeNode("Связи"));
        }
        public int getCounter()
        {
            return counter;
        }
        public TreeNode getTree()
        {
            return tags;
        }
        // поиск тэгов по тексту
        public RichTextBox searchBFTtag(RichTextBox rtb)
        {
            rtb.SelectAll();
            rtb.SelectionColor = Color.Black;

            // начало BFT-элемента
            bool flag = false;
            // начало новой метки
            int buffer = 0;
            // Cursor position место курсора перед обыском
            int cp = rtb.SelectionStart;
            // отсчёт начинаем с первого вхождения скобки
            if (rtb.Text.IndexOf('[') > 0)
                for (int i = rtb.Text.IndexOf('[') - 1; i < rtb.Text.Length; i++)
                {
                    if (!flag)
                    {
                        // поиск начала метки
                        if ((rtb.Text[i] == '1' || rtb.Text[i] == '0') && rtb.Text[i + 1] == '[' )
                        {
                            if(rtb.Text[i + 2] == ']')
                            {// 1[] || 0[]
                                rtb.Select(i, 3);
                                rtb.SelectionColor = Color.BlueViolet;
                            }
                            else if (rtb.Text[i] == '0' && (rtb.Text[i + 2] == '.' || rtb.Text[i + 2] == '0') && rtb.Text[i + 3] == ']')
                            {// 0[.] || 0[0]
                                rtb.Select(i, 4);
                                rtb.SelectionColor = Color.BlueViolet;
                            }
                            else if (rtb.Text[i] == '1' && rtb.Text[i + 2] == '1' && rtb.Text[i + 3] == ']')
                            {// 1[1]
                                rtb.Select(i, 4);
                                rtb.SelectionColor = Color.BlueViolet;
                            }
                            else
                            {
                                flag = true;
                                buffer = i;
                                i += 4;
                            }
                        }
                    }
                    else
                    {
                        // поиск конца метки
                        if (rtb.Text[i] == '0' && rtb.Text[i + 1] == '[' && rtb.Text[i + 2] == '0' && rtb.Text[i + 3] == ']')
                        {
                            counter++;
                            this.isBFTtag(rtb.Text.Substring(buffer, i + 4 - buffer), counter);
                            // выделяем тэг подсветкой
                            rtb.Select(buffer, i + 4 - buffer);
                            rtb.SelectionColor = Color.BlueViolet;
                            flag = false;
                            // после конечной метки всегда пробел
                            i += 4;
                        }
                    }
                }
            rtb.Select(cp, 0);
            rtb.SelectionStart = cp;
            return rtb;
        }
        // определение типа тэга
        public void isBFTtag(String _word, int _bftNumber)
        {
            // строка очищается слева направо до тех пор, пока не останется только тэг закрытия
            while (!_word.Equals("0[0]"))
            {
                if (_word.StartsWith("1[.]"))
                {
                    // убираем открывающий тэг, иначе IndexOf найдет не ту [
                    _word = _word.Substring(5);
                    tags.Nodes[0].Nodes.Add(_bftNumber.ToString(), "1[.] " + _word.Substring(0, _word.IndexOf('[') - 2) + " 0[0]");
                }
                else if (_word.StartsWith("1["))
                {
                    _word = _word.Substring(2);
                    tags.Nodes[1].Nodes.Add(_bftNumber.ToString(), "1[" + _word.Substring(0, _word.IndexOf('[') - 2) + " 0[0]");
                }
                else // if (_word.StartsWith("0["))
                {
                    _word = _word.Substring(2);
                    tags.Nodes[2].Nodes.Add(_bftNumber.ToString(), "0[" + _word.Substring(0, _word.IndexOf('[') - 2) + " 0[0]");
                }
                // убираем пробел перед началом закрывающего или следующего открывающего тэга
                _word = _word.Substring(_word.IndexOf('[') - 1);
            }
        }
    }
}
