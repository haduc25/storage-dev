using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace TestWF12
{
    public partial class Form1 : Form
    {
        string path = @"E:\"; //Lấy dữ liệu từ ổ E
        public Form1()
        {
            InitializeComponent();
            //LoadTreeView(); //Ex1:
            //Kiểm trả ổ E có tồn tại hay k?
            if (Directory.Exists(path))
            {
                TreeNode root2 = new TreeNode() { Text = path};
                LoadExplorer(root2);
                treeView1.Nodes.Add(root2);
            }
        }
        void LoadTreeView()
        {
            #region Ex1:
            ////Add Even
            //treeView1.NodeMouseClick += TreeView1_NodeMouseClick;
            ////On Check box
            //treeView1.CheckBoxes = true;
            ////Add Node
            //TreeNode root = new TreeNode();
            //root.Text = "Foder 1";
            //root.ImageIndex = 0;
            ////Add Node Con
            //TreeNode node = new TreeNode() { Text = "Foder Son 1" };
            //root.Nodes.Add(node);
            //node.ImageIndex = 1;


            //TreeNode root1 = new TreeNode();
            //root1.Text = "Foder 2";
            //root1.ImageIndex = 2;
            ////Add Node Con
            //TreeNode node1 = new TreeNode() { Text = "Foder Son 2" };
            //root1.Nodes.Add(node1);
            //node1.ImageIndex = 3;

            //treeView1.Nodes.Add(root);
            //treeView1.Nodes.Add(root1);
            #endregion
        }
        //Ex2
        //Tạo Hàm đệ quy
        void LoadExplorer(TreeNode root2)
        {
            if(root2 == null)
            {
                return;
            }
            try
            {
                treeView1.Nodes.Add(root2); //Thêm ổ E
                var folder = new DirectoryInfo(root2.Text).GetDirectories(); //Lấy dữ liệu,folder ổ E
                                                                             //Tạo Hàm đệ quy
                if (folder.Count() == 0)
                {
                    return;
                }
                foreach (DirectoryInfo item in folder)
                {
                    if (Directory.Exists(item.FullName))
                    {
                        TreeNode node = new TreeNode() { Text = item.FullName };
                        root2.Nodes.Add(node);
                        LoadExplorer(node);
                    }
                }
            }
            catch
            {
                return;
            }
        }
        private void TreeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            MessageBox.Show("You Click Here " + e.Node.Text);
            e.Node.Checked = !e.Node.Checked;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
