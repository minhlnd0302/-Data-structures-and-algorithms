using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Windows.Forms;

namespace BinarySearchTree
{
    
    public class BSTree
    {
        DrawCode drc = new DrawCode();
        DrawNode drn = new DrawNode();
        public int data;
        public int x;
        public int y;
        public BSTree left;
        public BSTree right;
        public int X { get { return x; } set {x=value; } }
        public int Y { get { return y; } set { y = value; } }
        public BSTree(int key,int a,int b)
        {
            data = key;
            x = a;
            y = b;
            left = right = null;
        }
        public BSTree Left
        {
            get
            {
                return left;
            }
            set
            {
                left = value;
            }
        }
        public BSTree Right
        {
            get
            {
                return right;
            }
            set
            {
                right = value;
            }
        }
        public int Data
        {
            get
            {
                return data;
            }
            set
            {
                data = value;
            }
        }
       
    }

    public class Tree
    {
        DrawCode drc = new DrawCode();
        DrawNode drn = new DrawNode();
        const int def = 50;
        public BSTree root;
        public Tree()
        {
            root = null;
        }
        public void InsertNode(int key,Graphics g)
        {
            drc.InsertCode(27, g);
            Thread.Sleep(500);
            if (root == null)
            {
                BSTree newNode = new BSTree(key, 300, 50);
                root = newNode;
                drc.InsertCode(28, g);
                Thread.Sleep(500);
                drc.InsertCode(30, g);
                drn.fillNode(root.X, root.Y, g, "red-white", root.Data);
                Thread.Sleep(500);
            }
            else
            {
                BSTree cur = root;
                BSTree parent = null;
                drc.InsertCode(28, g);
                Thread.Sleep(500);
                drc.InsertCode(29, g);
                Thread.Sleep(500);
                int dem = 0;
                while (cur!=null)
                {
                    if (dem != 0)
                    {
                        drc.InsertCode(27, g);
                        Thread.Sleep(500);
                        drc.InsertCode(28, g);
                        Thread.Sleep(500);
                        drc.InsertCode(29, g);
                        Thread.Sleep(500);
                    }

                    if (parent==null||parent==root)
                        drn.fillNode(root.X, root.Y, g, "red-white", root.data);
                    else
                        drn.fillNode(parent.X, parent.Y, g, "white-red", parent.data);
                    parent = cur;
                    Application.DoEvents();
                    drn.drawBorder(parent.X, parent.Y, g, "orange");
                    Thread.Sleep(500);
                    if(key<cur.Data)
                    {
                        drc.InsertCode(0, g);
                        Thread.Sleep(500);
                        drc.InsertCode(2, g);
                        Thread.Sleep(500);
                        cur = cur.Left;
                        if(cur==null)
                        {
                            BSTree newNode = new BSTree(key, 0, 0);
                            parent.Left = newNode;
                            parent.left.x = parent.x - def * getHeight(parent.left);
                            parent.left.y = parent.y + 80;
                            if (parent!=root)
                                drn.fillNode(parent.X, parent.Y, g, "white-red", parent.data);
                            else
                                drn.fillNode(parent.X, parent.Y, g, "red-white", parent.data);
                            drc.InsertCode(28, g);
                            Thread.Sleep(500);
                            drc.InsertCode(30, g);
                            drn.fillNode(parent.left.X, parent.left.Y, g, "white-red", key);
                            drn.drawBorder(parent.left.X, parent.left.Y, g, "orange");
                            Thread.Sleep(500);
                            drn.DrawArr(parent.X, parent.Y, parent.left.X, parent.left.Y, g);
                        }
                       
                    }
                    else
                    {
                        drc.InsertCode(0, g);
                        Thread.Sleep(500);
                        drc.InsertCode(6, g);
                        Thread.Sleep(500);
                        drc.InsertCode(3, g);
                        Thread.Sleep(500);
                        Point pt = new Point();
                        cur = cur.Right;
                        if(cur==null)
                        {
                            BSTree newNode = new BSTree(key, pt.X, pt.Y);
                            parent.Right = newNode;
                            parent.right.x = parent.x + def * getHeight(parent.right);
                            parent.right.y = parent.y + 80;
                            if (parent != root)
                                drn.fillNode(parent.X, parent.Y, g, "white-red", parent.data);
                            else
                                drn.fillNode(parent.X, parent.Y, g, "red-white", parent.data);
                            drc.InsertCode(28, g);
                            Thread.Sleep(500);
                            drc.InsertCode(30, g);
                            drn.fillNode(parent.right.X, parent.right.Y, g, "white-red", key);
                            drn.drawBorder(parent.right.X, parent.right.Y, g, "orange");
                            Application.DoEvents();
                            Thread.Sleep(500);
                            drn.DrawArr(parent.X, parent.Y, parent.right.X, parent.right.Y, g);

                        }
                    }
                    
                    Thread.Sleep(500);
                    dem++;
                }
                UpdateNode(root, root, g);
            }
        }
        public void PreorderTraverse(BSTree node,BSTree parent,Graphics g)
        {
            drc.PreOrderCode(23, g);
            Thread.Sleep(500);
            if (node == null) return;
            if (node != parent)
            {
                drn.fillNode(parent.x, parent.y, g, "white", parent.data);
                drn.drawBorder(node.x, node.y, g, "white");
               
                Thread.Sleep(500);
            }
            else
            {
                drn.drawBorder(node.x, node.y, g, "white");
                Thread.Sleep(500);
            }
            drc.PreOrderCode(13, g);
            Thread.Sleep(500);
            drn.fillNode(node.X, node.Y, g, "white-black", node.Data);
            Thread.Sleep(500);
            Application.DoEvents();
            drc.PreOrderCode(9, g);
            Thread.Sleep(500);
            PreorderTraverse(node.left,node, g);
            Application.DoEvents();
            drc.PreOrderCode(10, g);
            Thread.Sleep(500);
            Application.DoEvents();
            PreorderTraverse(node.right,node,g);
           
        }
        public void InorderTraverse(BSTree node,BSTree parent, Graphics g)
        {
            if (node == null) return;
            drc.InOrderCode(22, g);
            Thread.Sleep(500);
            Application.DoEvents();
            if (node != parent)
            {
                drn.fillNode(parent.x, parent.y, g, "red",parent.data);
                drn.drawBorder(node.x, node.y, g, "red");
                Thread.Sleep(500);
            }
            else
            {
                drn.drawBorder(node.x, node.y, g, "red");
                Thread.Sleep(500);
            }

            drc.InOrderCode(7, g);
            Thread.Sleep(500);
            Application.DoEvents();
            //drc.InOrderCode(22, g);
            // Thread.Sleep(500);
            InorderTraverse(node.left,node,g);
            drc.InOrderCode(13, g);
            drn.fillNode(node.X, node.Y, g, "red-white", node.Data);
            Thread.Sleep(500);
            Application.DoEvents();
            drc.InOrderCode(8, g);
            Thread.Sleep(500);
            Application.DoEvents();
            //drc.InOrderCode(22, g);
            //Thread.Sleep(500);
            InorderTraverse(node.right,node,g);
            
        }
        public void PostorderTraverse(BSTree node,BSTree parent,  Graphics g)
        {
            if (node == null) return;
            drc.PosOrderCode(24, g);
            Thread.Sleep(500);
            if (node != parent)
            {
                drn.delBorder(node.x, node.y, g, "red");
              //  drn.drawBorder(node.x, node.y, g, "red");
                drn.fillNode(parent.x, parent.y, g, "yellow", parent.data);
                Thread.Sleep(500);
            }
            else
            {
                drn.drawBorder(node.x, node.y, g, "red");
                Thread.Sleep(500);
            }
            drc.PosOrderCode(11, g);
            Thread.Sleep(500);
            Application.DoEvents();
            PostorderTraverse(node.left,node,g);
            drc.PosOrderCode(12, g);
            Thread.Sleep(500);
            Application.DoEvents();
            PostorderTraverse(node.right,node,g);
            drc.PosOrderCode(25, g);
            Thread.Sleep(500);
            Application.DoEvents();
            drn.fillNode(node.X, node.Y, g, "yellow-green", node.Data);
            Thread.Sleep(500);
            Application.DoEvents();
        }
        public bool Search(BSTree node,BSTree parent, int key,Graphics g)
        {
            if (node == null) return false;
            drc.FindCode(26, g);
            Thread.Sleep(500);
            if (node.data == key)
            {
                drc.FindCode(6, g);
                
                drn.drawBorder(node.X, node.Y, g,"red");
                if(node!=this.root)
                {

                    drn.fillNode(parent.X, parent.Y, g, "white-red", parent.Data);
                }
                Thread.Sleep(500);
                Application.DoEvents();
                drc.FindCode(25, g);
                drn.fillNode(node.X, node.Y, g, "yellow-green", node.Data);
                
                return true;
            }
            if (node.data > key)
            {
               
                drn.drawBorder(node.X, node.Y, g, "red");
                if (node != this.root)
                {

                    drn.fillNode(parent.X, parent.Y, g, "white-red", parent.Data);
                }
                drc.FindCode(0, g);
                Thread.Sleep(500);
                drc.FindCode(4, g);
               
                Thread.Sleep(500);
                Application.DoEvents();
                return Search(node.left, node, key, g);
            }
            else if (node.data < key)
            {
                
                drn.drawBorder(node.X, node.Y, g, "red");
                if (node != this.root)
                {

                    drn.fillNode(parent.X, parent.Y, g, "white-red", parent.Data);
                }
                drc.FindCode(1, g);
                Thread.Sleep(500);
                drc.FindCode(5, g);
               
                Thread.Sleep(500);
                Application.DoEvents();
                return Search(node.right, node, key, g);
            }
            else return false;
            
        }
       
        public void UpdateNode(BSTree node,BSTree curNode, Graphics g)//Draw all of node again
        {

           // g.Clear(Color.DarkGreen);
            if (node == null) return;
            UpdateNode(node.left,node, g);
            UpdateNode(node.right,node, g);
            if (node == root)
                drn.fillNode(root.X, root.Y, g, "orange-white", root.Data);else
            drn.fillNode(node.X, node.Y, g, "white-red", node.Data);
            if(curNode!=node)
                drn.DrawArr(curNode.X, curNode.Y, node.X, node.Y, g);
            Application.DoEvents();
        }
        public void insertNodefromArr(int key)
        {
            if (root == null)
            {
                BSTree newNode = new BSTree(key, 300, 50);
                root = newNode;
               

            }
            else
            {
                BSTree cur = root;
                BSTree parent = null;
                int height = 1;
                int widthLeft = 0;
                int widthRight = 0;
               
                while (cur != null)
                {
                    parent = cur;
                    if (key < cur.Data)
                    {
                        widthLeft++;
                       
                        cur = cur.Left;
                        if (cur == null)
                        {
                           /* switch (height)
                            {
                                case 1:
                                    pt.X = parent.X - 200;
                                    pt.Y = parent.Y + 50;
                                    break;
                                case 2:

                                    pt.X = parent.X - 100;
                                    pt.Y = parent.Y + 100;

                                    break;
                                case 3:
                                    pt.X = parent.X - 50;
                                    pt.Y = parent.Y + 150;
                                    break;
                                default:
                                    pt.X = parent.X - 30;
                                    pt.Y = parent.Y + 150;
                                    break;

                            }*/
                            BSTree newNode = new BSTree(key, 0, 0);
                            parent.Left = newNode;
                            parent.left.X = parent.X - def * getHeight(parent.left);
                            parent.left.X = parent.Y + 80;



                        }

                    }
                    else
                    {
                        widthRight++;
                        
                        cur = cur.Right;
                        if (cur == null)
                        {
                            /* switch (height)
                             {
                                 case 1:
                                     pt.X = parent.X + 200;
                                     pt.Y = parent.Y + 50;
                                     break;
                                 case 2:
                                     pt.X = parent.X + 100;
                                     pt.Y = parent.Y + 100;

                                     break;
                                 case 3:
                                     pt.X = parent.X + 50;
                                     pt.Y = parent.Y + 150;
                                     break;
                                 default:
                                     pt.X = parent.X + 30;
                                     pt.Y = parent.Y + 150;
                                     break;

                             }*/
                            
                            BSTree newNode = new BSTree(key, 0, 0);
                            parent.Right = newNode;
                            parent.right.X = parent.X + def * getHeight(parent.right);
                            parent.right.X = parent.Y+80 ;

                        }
                    }
                    height++;
                }
            }
        }
        public void ReUpdate(Tree k,List<int> a)
        {
            foreach(int tmp in a)
            {
                k.insertNodefromArr(tmp);
            }
    
        }
        public void deleteAll(BSTree node)
        {
            if(node!=null)
            {
                deleteAll(node.left);
                deleteAll(node.right);
                root = null;
            }
        }
        public void levelUpdate(List<int> storage)
        {
            // List<int> storage = new List<int>();
            if (root == null) return;
            List<BSTree> queue = new List<BSTree>();
            queue.Add(root);
            // queue.Add(null);
            BSTree res = new BSTree(0,0,0);
            while (queue.Count != 0)
            {
                res = queue[0];
                if (res != null)
                {
                    storage.Add(res.data);
                    if (res.left != null)
                    {

                        queue.Add(res.left);//!!!
                        queue.RemoveAt(0);

                    }
                    if (res.right != null && res.left != null)
                    {
                        queue.Add(res.right);
                    }
                    if (res.right != null && res.left == null)
                    {
                        queue.Add(res.right);
                        queue.RemoveAt(0);

                    }
                    if (res.right == null && res.left == null)
                        queue.RemoveAt(0);
                }
                else
                {
                    if (queue.Count == 1)
                    {
                        break;
                    }
                }
            }
        }
        private BSTree DeleteN(BSTree root, BSTree deleteNode,BSTree parent,Graphics g)
        {
            drc.DelCode(31, g);
            Thread.Sleep(1000);
            drc.DelCode(39, g);
            Thread.Sleep(1000);
            if (root == null)
            {
                drc.DelCode(40, g);
                Thread.Sleep(1000);
                return root;
            }
           
            //Thread.Sleep(1000);
            if (root == this.root)
                drn.drawBorder(this.root.x, this.root.y, g, "red");
            else
            {
                drn.delBorder(parent.x, parent.y, g, "white");
                drn.drawBorder(root.x,root.y,g,"red");
                
            }
            drc.DelCode(17, g);
            Thread.Sleep(1000);
            drc.DelCode(0, g);
            Thread.Sleep(1000);
           // drc.DelCode(6, g);
          //  Thread.Sleep(1000);
            if (deleteNode.data < root.data)
            {
                
                drc.DelCode(32, g);
                Thread.Sleep(1000);
                Application.DoEvents();
                root.left = DeleteN(root.left, deleteNode,root,g);
               
            }
           
            if (deleteNode.data > root.data)
            {
                //drc.DelCode(6, g);
                //Thread.Sleep(1000);
                drc.DelCode(33, g);
                Thread.Sleep(1000);
                Application.DoEvents();
                root.right = DeleteN(root.right, deleteNode,root,g);
                
            }
            
            if (deleteNode.data == root.data)
            {
                drc.DelCode(29, g);
                Thread.Sleep(1000);
                Application.DoEvents();
                drc.DelCode(15, g);
                if (root.left == null && root.right == null)
                {
                    drc.DelCode(35, g);
                    Thread.Sleep(1000);
                    root = null;
                    return root;
                }
               
                else if (root.left == null || root.right == null)
                {
                    drc.DelCode(15, g);
                    Thread.Sleep(1000);
                    if (root.left == null)
                    {
                        drc.DelCode(35, g);
                        Thread.Sleep(1000);
                        Application.DoEvents();
                        BSTree temp = root;
                        root = root.right;
                        temp = null;
                    }
                    
                    else
                    {
                        drc.DelCode(16, g);
                        Thread.Sleep(1000);
                        drc.DelCode(34, g);
                        Thread.Sleep(1000);
                        Application.DoEvents();
                        BSTree temp = root;
                        root = root.left;
                        temp = null;
                    }
                }
               
                else
                {

                    drc.DelCode(6, g);
                    Thread.Sleep(1000);
                    drc.DelCode(36, g);
                    Thread.Sleep(1000);
                    drc.DelCode(37, g);
                    Application.DoEvents();
                    BSTree min = FindMin(root.right,g);
                    root.data = min.data;
                    UpdateNode(root, root, g);
                    Thread.Sleep(1000);
                    drc.DelCode(38, g);
                    root.right = DeleteN(root.right, min,root.right,g);
                }
            }
            return root;
        }
        public BSTree FindMin(BSTree root,Graphics g)
        {
            BSTree cur = null;
            while (root != null)
            {
                if(cur!=null)
                drn.delBorder(cur.x,cur.y,g,"white");
                cur = root;
                drn.drawBorder(cur.x, cur.y, g, "yellow");
                root = root.left;
                Thread.Sleep(500);
            }
            return cur;
        }
        //Public method with arg: int value of node to be deleted
        public void DeleteNode(int x,Graphics g)
        {
            BSTree deleteNode = new BSTree(x,0,0);
            DeleteN(root, deleteNode,root,g);
        }
        private int max(int l, int r)
        {
            return l > r ? l : r;
        }
        private int getHeight(BSTree current)
        {
            int height = 0;
            if (current != null)
            {
                int l = getHeight(current.left);
                int r = getHeight(current.right);
                int m = max(l, r);
                height = m + 1;
            }
            return height;
        }
        public BSTree UpdatePosition(BSTree parent, BSTree cur, int check)
        {

            if (cur != null)
            {
                if (check == 0)
                {
                    cur.x = parent.x - def * getHeight(cur);
                    cur.y = parent.y + 80;
                }
                if (check == 1)
                {
                    cur.x = parent.x + def * getHeight(cur);
                    cur.y = parent.y + 80;
                }
                if (check == -1 && cur == root)
                {
                    cur.x = 300;
                    cur.y = 50;
                }
                if (check == -1 && cur != root)
                {
                    cur.x = parent.x;
                    cur.y = parent.y;
                }
                UpdatePosition(cur, cur.left, 0);
                UpdatePosition(cur, cur.right, 1);
            }
            return cur;
        }
    }

}
