using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace WeatherParserHttpGet
{
    public class CitiesTreeBuilder
    {
        public List<TreeNode> GetListNode(StreamReader stream)
        {
            bool isEmpty = true, isRoot = false;
            string parent = String.Empty;
            int afterCountTabs = 0;
            List<TreeNode> childs = new List<TreeNode>();
            TreeNode treeBranch = new TreeNode();
            while (!stream.EndOfStream)
            {
                string node = stream.ReadLine();
                int countTabs = GetCountTabs(node);
                if (!isEmpty && countTabs == 0)
                {
                    childs.Add(treeBranch);
                    treeBranch = new TreeNode();
                    treeBranch.Text = node;
                    parent = node;
                }
                else if (isEmpty && countTabs == 0)
                {
                    treeBranch.Text = node;
                    parent = node;
                }
                else if (treeBranch.Nodes.Count == 0)
                {
                    treeBranch.Nodes.Add(node, node);
                    parent = node;
                }
                else
                {
                    if (countTabs == afterCountTabs)
                    {
                        var parentNode = (treeBranch.Nodes.Find(parent, true).FirstOrDefault());
                        parent = parentNode.Parent.Text;
                        isRoot = (parentNode.Parent.Level == 0);
                    }
                    else if (countTabs < afterCountTabs)
                    {
                        var parentNode = (treeBranch.Nodes.Find(parent, true).LastOrDefault());
                        parent = GetParent(parentNode, afterCountTabs - countTabs, out isRoot);
                    }
                    TreeNode newNode;
                    if (isRoot)
                    {
                        newNode = treeBranch;
                        isRoot = false;
                    }
                    else newNode = treeBranch.Nodes.Find(parent, true).LastOrDefault();
                    newNode.Nodes.Add(node, node);
                    parent = node;
                }
                afterCountTabs = countTabs;
                isEmpty = false;
            }
            childs.Add(treeBranch);
            return childs;
        }

        private string GetParent(TreeNode node, int level, out bool isRoot)
        {
            while (level >= 0)
            {
                node = node.Parent;
                level--;
            }
            isRoot = (node.Level == 0);
            return node.Text;
        }

        private int GetCountTabs(string node)
        {
            return node.Split(new string[] { "\t" }, StringSplitOptions.None).Count() - 1;
        }

        
    }
}
