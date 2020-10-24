using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Windows.Forms;
namespace BalanceTree
{
    class Node
    {
        public int data;
        public int x;
        public int y;
        public Node left;
        public Node right;
        const int def = 50;
        public Node(int data, int a, int b)
        {
            this.data = data;
            this.x = a;
            this.y = b;
        }
    }
    class AVLTree
    {
        const int def = 60;
        
        DrawNode drn = new DrawNode();
        DrawCode drc = new DrawCode();
        
        Node root;
        public AVLTree()
        {
        }
        public void Add(int data, Graphics g)
        {
            Node newItem = new Node(data, 400, 50);
            if (root == null)
            {
                root = newItem;
                drn.drawNodeAndValue(root.x, root.y, root.data, g);
                drc.DisplayCode(0, g);
            }
            else
            {
                drc.DisplayCode(0, g);
                root = RecursiveInsert(root,root, newItem, g,-1);
                DisplayTree(g);
                Thread.Sleep(1000);
                root = reBalance(root, root, data, g);
                drc.DisplayCode(2, g);
                //root = UpdatePosition(root, root, -1);
                DisplayTree(g);
            }
            
        }
        private Node RecursiveInsert(Node current,Node parent, Node n, Graphics g,int check)
        {
            
            if (current == null)
            {
                current = n;
                current.y = parent.y + 80;
                if(check==0)
                    current.x = parent.x - def * getHeight(current);
                else if(check==1)
                    current.x = parent.x + def * getHeight(current);
               
                return current;
            }
            else if (n.data < current.data)
            {
                current.left = RecursiveInsert(current.left,current, n, g,0);
               


            }
            else if (n.data > current.data)
            {
                current.right = RecursiveInsert(current.right,current, n, g,1);

               

            }
          
            return current;
        }
        public Node balance_tree(Node current,Graphics g)
        {
            int b_factor = balance_factor(current);
            if (b_factor > 1)
            {
                if (balance_factor(current.left) > 0)
                {
                    drc.DisplayCode(3, g);
                    Thread.Sleep(1000);
                    current = RotateLL(current,g);
                   
                }
                else
                {
                    drc.DisplayCode(4, g);
                    Thread.Sleep(1000);
                    current = RotateLR(current,g);
                  
                }
             
            }
            else if (b_factor < -1)
            {
                if (balance_factor(current.right) > 0)
                {
                    drc.DisplayCode(6, g);
                    Thread.Sleep(1000);
                    current = RotateRL(current,g);
                   
                }
                else
                {
                    drc.DisplayCode(5, g);
                    Thread.Sleep(1000);
                    current = RotateRR(current,g);
                   
                }
             
            }
          
            return current;
            
        }
        public bool havetoBalance(Node cur)
        {
            if (balance_factor(cur) < -1 || balance_factor(cur) > 1)
                return true;
            return false;
        }
        public Node reBalance(Node cur, Node parent, int key,Graphics g)
        {
            if (havetoBalance(cur))
            {
                drc.DisplayCode(1, g);
                DisplayErr(cur,g);
                DisplayTree_Part(g, cur);
                
                Thread.Sleep(1000);
            }
            if (key < cur.data)
            {
                cur.left = reBalance(cur.left, cur, key,g);
                cur = balance_tree(cur,g);
               
            }
            else if (key > cur.data)
            {
                cur.right = reBalance(cur.right, cur, key,g);
                cur = balance_tree(cur,g);
               
            }
            else
            {
                return cur;
            }
          
            return cur;
        }
        public void Delete(int target,Graphics g)
        {
            root = Delete(root, target,g);
            drc.DisplayCode(2, g);
            DisplayTree(g);
        }
        private Node Delete(Node current, int target,Graphics g)
        {
            Node parent;
            if (current == null)
            {
                return null; 
            }
            else
            {
                if (target < current.data)
                {
                    current.left = Delete(current.left, target,g);
                    DisplayTree(g);
                    drc.DisplayCode(9, g);
                    Thread.Sleep(500);
                    if (balance_factor(current) == -2)//here
                    {
                        if (balance_factor(current.right) <= 0)
                        {
                            drc.DisplayCode(5, g);
                            Thread.Sleep(1000);
                            current = Del_RotateRR(current,g);
                            DisplayErr(current, g);
                            DisplayTree_Part(g, current);
                           
                            Thread.Sleep(1000);
                        }
                        else
                        {
                            drc.DisplayCode(6, g);
                            Thread.Sleep(1000);
                            current = Del_RotateRL(current,g);
                            DisplayErr(current, g);
                            DisplayTree_Part(g, current);
                            Thread.Sleep(1000);
                        }
                    }
                }
                //right subtree
                else if (target > current.data)
                {
                    current.right = Delete(current.right, target,g);
                    DisplayTree(g);
                    drc.DisplayCode(9, g);
                    Thread.Sleep(500);
                    if (balance_factor(current) == 2)
                    {
                        if (balance_factor(current.left) >= 0)
                        {
                            // DisplayTree_Part(g, current);
                            drc.DisplayCode(3, g);
                            Thread.Sleep(1000);
                            current = Del_RotateLL(current,g);
                            // Thread.Sleep(1000);
                            DisplayErr(current, g);
                            DisplayTree_Part(g, current);
                            Thread.Sleep(1000);
                        }
                        else
                        {
                            // DisplayTree_Part(g, current);
                            drc.DisplayCode(4, g);
                            Thread.Sleep(1000);
                            current = Del_RotateLR(current,g);
                            //Thread.Sleep(1000);
                            DisplayErr(current, g);
                            DisplayTree_Part(g, current);
                            Thread.Sleep(1000);
                        }
                    }
                }
                
                else
                {
                    if (current.right != null)
                    {
                        //delete its inorder successor
                        parent = current.right;
                        while (parent.left != null)
                        {
                            parent = parent.left;
                        }
                        current.data = parent.data;
                        current.right = Delete(current.right, parent.data,g);
                        DisplayTree(g);
                        drc.DisplayCode(9, g);
                        Thread.Sleep(500);
                        if (balance_factor(current) == 2)//rebalancing
                        {
                            if (balance_factor(current.left) >= 0)
                            {
                                
                                DisplayErr(current, g);
                                drc.DisplayCode(3, g);
                                Thread.Sleep(1000);
                                current = Del_RotateLL(current,g);
                                //DisplayTree_Part(g, current);
                                Thread.Sleep(1000);
                            }
                            else
                            {
                               
                                DisplayErr(current, g);
                                drc.DisplayCode(4, g);
                                Thread.Sleep(1000);
                                current = Del_RotateLR(current,g);
                                //DisplayTree_Part(g, current);
                                Thread.Sleep(1000);
                            }
                        }
                    }
                    else
                    {   //if current.left != null
                        return current.left;
                    }
                }
            }
            return current;
        }
        public void Find(int key)
        {
            if (Find(key, root).data == key)
            {
                Console.WriteLine("{0} was found!", key);
            }
            else
            {
                Console.WriteLine("Nothing found!");
            }
        }
        private Node Find(int target, Node current)
        {

            if (target < current.data)
            {
                if (target == current.data)
                {
                    return current;
                }
                else
                    return Find(target, current.left);
            }
            else
            {
                if (target == current.data)
                {
                    return current;
                }
                else
                    return Find(target, current.right);
            }

        }
        public void DisplayTree(Graphics g)
        {
           g.FillRectangle(Brushes.Black, 0, 0, 800, 800);;
            if (root == null)
            {
                
                return;
            }
            InOrderDisplayTree(root,root,g);
           
        }
        public void DisplayTree_Part(Graphics g,Node cur)
        {
           //g.FillRectangle(Brushes.Black, 0, 0, 800, 800);;
            if(cur.left==null&&cur.right==null)
            {
                drn.fillAnyPart(cur.x, cur.y, 40, 40, g);
            }
            else
            {
                if(cur.left==null&&cur.right!=null)
                {
                    drn.fillAnyPart(cur.x, cur.y,cur.right.x+40-cur.x,cur.right.y+40-cur.y, g);
                }
                if(cur.left!=null&&cur.right==null)
                {
                    drn.fillAnyPart(cur.left.x, cur.y,-cur.left.x+cur.x+40,-cur.y+cur.left.y+40, g);
                }
                if(cur.left!=null&&cur.right!=null)
                {
                    drn.fillAnyPart(cur.left.x, cur.y, cur.right.x+40-cur.left.x, cur.left.y+40-cur.y, g);
                }
            }
            InOrderDisplayTreeRed(cur, cur, g);
            
            
        }
        public void InOrderDisplayTreeRed(Node current, Node parent, Graphics g)
        {

            if (current != null)
            {
                InOrderDisplayTreeRed(current.left, current, g);
                drn.drawNodeAndValue(current.x, current.y, current.data, g);
                if (current != parent)
                    drn.drawRedArrow(parent.x, parent.y, current.x, current.y, g);
                drn.drawLevel(current.x + 20, current.y - 20, getHeight(current), g);
                InOrderDisplayTreeRed(current.right, current, g);
            }
        }

        public void InOrderDisplayTree(Node current,Node parent,Graphics g)
        {
           
            if (current != null)
            {
                InOrderDisplayTree(current.left,current,g);
                drn.drawNodeAndValue(current.x, current.y, current.data, g);
                if(current!=parent)
                    drn.drawArrow(parent.x, parent.y, current.x, current.y, g);
                drn.drawLevel(current.x+20, current.y-20, getHeight(current), g);
                InOrderDisplayTree(current.right,current,g);
            }
        }
        private int max(int l, int r)
        {
            return l > r ? l : r;
        }
        private int getHeight(Node current)
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
        private int balance_factor(Node current)
        {
            int l = getHeight(current.left);
            int r = getHeight(current.right);
            int b_factor = l - r;
            return b_factor;
        }
        #region Add_Rotate
        private Node RotateRR(Node parent,Graphics g)
        {
            drc.DisplayCode(8,g);
            Node tmp = parent;
            Node pivot = parent.right;
            parent.right = pivot.left;
            pivot.left = parent;
            UpdatePosition(tmp, pivot, -1);
            // DisplayTree(g);
            DisplayErr(pivot.left, g);
            drc.DisplayCode(8, g);
            DisplayTree_Part(g, pivot);
            drc.DisplayCode(8, g);
            Application.DoEvents();
            Thread.Sleep(1000);
            return pivot;
        }
        private Node RotateLL(Node parent,Graphics g)
        {
            Node tmp = parent;
            Node pivot = parent.left;
            drc.DisplayCode(7, g);

            parent.left = pivot.right;
          
            pivot.right = parent;
            UpdatePosition(tmp, pivot, -1);
            // DisplayTree(g);
            DisplayErr(pivot.right, g);
            DisplayTree_Part(g, pivot);
            Application.DoEvents();
            Thread.Sleep(1000);

            return pivot;
        }
        private Node RotateLR(Node parent,Graphics g)
        {
            
            Node tmp = parent;
            Node pivot = parent.left;
            parent.left = RotateRR(pivot,g);
            // UpdatePosition(tmp, parent,-1);
             DisplayTree(g);
            //DisplayErr(pivot.left, g);
            DisplayTree_Part(g, parent);
            Application.DoEvents();
            Thread.Sleep(1000);
           g.FillRectangle(Brushes.Black, 0, 0, 800, 800);
            
            return RotateLL(parent,g);
        }
        private Node RotateRL(Node parent,Graphics g)
        {
           
            Node tmp = parent;
            Node pivot = parent.right;
            parent.right = RotateLL(pivot,g);
            // UpdatePosition(tmp, parent, -1);
             DisplayTree(g);
           // DisplayErr(pivot.left, g);
            DisplayTree_Part(g, parent);
            Application.DoEvents();
            Thread.Sleep(1000);
           g.FillRectangle(Brushes.Black, 0, 0, 800, 800);;
            return RotateRR(parent,g);
        }
        #endregion
        #region del_Rotate
        private Node Del_RotateRR(Node parent, Graphics g)
        {
            drc.DisplayCode(8, g);
            DisplayTree_Part(g, parent);
            Node tmp = parent;
            Node pivot = parent.right;
            parent.right = pivot.left;
            pivot.left = parent;
            UpdatePosition(tmp, pivot, -1);
            // DisplayTree_Part(g, pivot);
            //  Application.DoEvents();
             Thread.Sleep(1000);
           g.FillRectangle(Brushes.Black, 0, 0, 800, 800);;
            return pivot;
        }
        private Node Del_RotateLL(Node parent, Graphics g)
        {
            drc.DisplayCode(7, g);
            DisplayTree_Part(g, parent);
            Node tmp = parent;
            Node pivot = parent.left;


            parent.left = pivot.right;

            pivot.right = parent;
            UpdatePosition(tmp, pivot, -1);

            // DisplayTree_Part(g, pivot);
            // Application.DoEvents();
             Thread.Sleep(1000);
           g.FillRectangle(Brushes.Black, 0, 0, 800, 800);;
            return pivot;
        }
        private Node Del_RotateLR(Node parent, Graphics g)
        {
            DisplayTree_Part(g, parent);
            Node tmp = parent;
            Node pivot = parent.left;
            parent.left = RotateRR(pivot, g);
             UpdatePosition(tmp, parent,-1);
            //DisplayTree_Part(g, parent);
           // Application.DoEvents();
            Thread.Sleep(1000);
           g.FillRectangle(Brushes.Black, 0, 0, 800, 800);;
            return RotateLL(parent, g);
        }
        private Node Del_RotateRL(Node parent, Graphics g)
        {
            DisplayTree_Part(g, parent);
            Node tmp = parent;
            Node pivot = parent.right;
            parent.right = RotateLL(pivot, g);
             UpdatePosition(tmp, parent, -1);
           // DisplayTree_Part(g, parent);
           // Application.DoEvents();
            Thread.Sleep(1000);
           g.FillRectangle(Brushes.Black, 0, 0, 800, 800);;
            return RotateRR(parent, g);
        }
        #endregion
        private Node UpdatePosition(Node parent, Node cur, int check)
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
                if(check==-1&&cur==root)
                {
                    cur.x = 400;
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
        public Node findParent(Node cur, Node find)
        {
            if(cur.left!=find&&cur.right!=find)
            {
                findParent(cur.left, find);
                findParent(cur.right, find);
            }
            return cur;
            
        }
        public void DisplayErr(Node cur,Graphics g)
        {
           g.FillRectangle(Brushes.Black, 0, 0, 800, 800);;
            if (root == null)
            {

                return;
            }
            AvoidNode(root, root,cur, g);
        }
        public void AvoidNode(Node current,Node parent,Node avoid,Graphics g)
        {

            if (current != null)
            {
                AvoidNode(current.left, current,avoid, g);
                drn.drawNodeAndValue(current.x, current.y, current.data, g);
                if (current != parent&&current!=avoid&&current!=avoid)
                    drn.drawArrow(parent.x, parent.y, current.x, current.y, g);
                drn.drawLevel(current.x + 20, current.y - 20, getHeight(current), g);
                AvoidNode(current.right, current,avoid, g);
            }
        }
    }
    
}
