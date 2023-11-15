using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KP_APPO
{
    class BFT_Iterator : IEnumerable
    {
        private int count;
        private TreeNode tn = new TreeNode();

        public void addTree(BFT_Elements bftE)
        {
            count = bftE.getCounter();
            tn = bftE.getTree();
        }
        public IEnumerator GetEnumerator()
        {
            foreach(TreeNode tag in tn.Nodes[0].Nodes)
            {
                yield return tag.Text;
            }
            foreach (TreeNode tag in tn.Nodes[1].Nodes)
            {
                yield return tag.Text;
            }
            foreach (TreeNode tag in tn.Nodes[2].Nodes)
            {
                yield return tag.Text;
            }
        }

    }
}
