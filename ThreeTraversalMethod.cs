using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MyProject
{
    class ThreeTraversalMethod<Tkey, Tvalue>
    {
        Queue<Node> q = new Queue<Node>();
       
        private class Node
        {
            public Tkey key;
            public Tvalue value;
            public Node Left, Right;

            public Node(Tkey key1, Tvalue value1)
            {
                this.key = key1;
                this.value = value1;
                this.Left = null;
                this.Right = null;
            }
            public Node(Node node)
            {
                this.key = node.key;
                this.value = node.value;
                this.Left = node.Left;
                this.Right = node.Right;
            }
        }
        private Node root;
        private int number;
        public ThreeTraversalMethod()
        {
            this.root = null;
            this.number = 0;
        }
        public void insert(Tkey key2, Tvalue value2)
        {
            root = insert1(root, key2, value2);
            //q.Enqueue("");
            //q.Dequeue();
        }
        private Node insert1(Node node1, Tkey key3, Tvalue value3)
        {
            if (node1 == null)
            {
                number++;
                return new Node(key3, value3);
            }
            if ((key3 as IComparable).CompareTo(node1.key) == 0)
            {
                node1.value = value3;
            }
            else if ((key3 as IComparable).CompareTo(node1.key) < 0)
            {
                node1.Left = insert1(node1.Left, key3, value3);
            }
            else
            {
                node1.Right = insert1(node1.Right, key3, value3);
            }
            return node1;
        }
        
        public int size()
        {
            return number;
        }
        public bool isEmpty()
        {
            return number == 0;
        }
        public string TempPO = "";
        public string TempIO = "";
        public string TempPOO = "";
        public string PreOrderEnter()
        {
            PreOrder(root);
            return TempPO;
           
        }
        public string InOrderEnter()
        {
            InOrder(root);
            return TempIO;
        }
        public string PostOrderEnter()
        {
            PostOrder(root);
            return TempPOO;
        }

        private void PreOrder(Node node3)
        {
            if(node3 != null)
            {
                TempPO = TempPO +","+ node3.key.ToString();
                PreOrder(node3.Left);
                PreOrder(node3.Right);
            }
        }
        private void InOrder(Node node3)
        {
            if (node3 != null)
            {                
                InOrder(node3.Left);
                TempIO = TempIO + "," + node3.key.ToString();
                InOrder(node3.Right);
            }
        }
        private void PostOrder(Node node3)
        {
            if (node3 != null)
            {
                PostOrder(node3.Left);                
                PostOrder(node3.Right);
                TempPOO = TempPOO + "," + node3.key.ToString();
            }
        }
        public string TempLO = "";
        public string LevelOrderEnter()
        {
            TempLO = "";
            LevelOrder(root);
            return TempLO;
        }
        private void LevelOrder(Node node4)
        {            
            q.Enqueue(node4);
            while(q.Count != 0)
            {
                Node Front = q.Dequeue();
                TempLO = TempLO + "," + Front.key.ToString();
                if (Front.Left != null)
                {
                    q.Enqueue(Front.Left);
                    //LevelOrder(node4.Left);
                    //node4 = node4.Left;
                }
                if (Front.Right != null)
                {
                    q.Enqueue(Front.Right);
                    ////LevelOrder(node4.Right);
                    //node4 = node4.Right;
                }
            }
        }

        public string TempMin = "";
        public string MinimumEnter()
        {
            //判断搜索树中有无节点
            if (number == 0)
            {
                return "No number in this tree";
            }
            else
            {
                Minimum(root);
                return TempMin;
            }
        }
        private void Minimum(Node node5)
        {
            //寻找根节点左子树中左下角的一个节点
            if(node5.Left == null)
            {
                TempMin = node5.key.ToString();
            }
            else
            {
                Minimum(node5.Left);
            }
        }
        public string TempMax = "";
        public string MaximumEnter()
        {
            //判断搜索树中有无节点
            if (number == 0)
            {
                return "No number in this tree";
            }
            else
            {
                Maximum(root);
                return TempMax;
            }
        }
        private void Maximum(Node node5)
        {
            //寻找根节点右子树中右下角的一个节点
            if (node5.Right == null)
            {
                TempMax = node5.key.ToString();
            }
            else
            {
                Maximum(node5.Right);
            }
        }
        public void RemoveMinEnter()
        {
            if (root != null)
            {
                root = RemoveMin(root);
            }
        }
        private Node RemoveMin(Node node6)
        {
            if(node6.Left == null)
            {
                Node RightNode = node6.Right;
                node6 = null;
                number--;
                return RightNode;
            }
            node6.Left = RemoveMin(node6.Left);
            return node6;
        }

        private Node TempMIR = null;
        //private Node MinimumInRemoveEnter(Node node9)
        //{
        //    if (number == 0)
        //    {
        //        return null;
        //    }
        //    else
        //    {
        //        Minimum(node9);
        //        return TempMIR;
        //    }
        //}
        
        //为删除任意节点专门提供的返回node类型的查找Minimum函数
        private Node MinimumInRemove(Node node8)
        {
            if (node8.Left == null)
            {
                TempMIR = node8;
                return TempMIR;
            }
            else
            {
                return MinimumInRemove(node8.Left);
            }
        }
        public void RemoveEnter(Tkey key4)
        {
            root = Remove(root, key4);
        }
        private Node Remove(Node node7, Tkey key5)
        {
            //判断有没有根节点
            if(node7 == null)
            {
                return null;
            }

            //判断需要删除的节点位于根的左子树或右子树并在该子树中寻找需要删除的节点
            if ((key5 as IComparable).CompareTo(node7.key) < 0)
            {
                node7.Left = Remove(node7.Left, key5);
                return node7;
            }
            else if((key5 as IComparable).CompareTo(node7.key) > 0)
            {
                node7.Right = Remove(node7.Right, key5);
                return node7;
            }
            //在输入的node7就是需要删除的节点的情况下删除该节点
            else
            {
                if (node7.Left == null)
                {
                    Node rightnode = node7.Right;
                    node7 = null;
                    number--;
                    return rightnode;
                }
                if(node7.Right == null)
                {
                    Node leftnode = node7.Left;
                    node7 = null;
                    number--;
                    return leftnode;
                }

                //在删除节点后，找寻该节点右子树中的最小值并将其替换到被删除的节点的位置上
                Node Successor = MinimumInRemove(node7.Right);
                number++;
                Successor.Right = RemoveMin(node7.Right);
                Successor.Left = node7.Left;
                node7 = null;
                number--;
                return Successor;
            }
        }

        public string TempFloor = "";
        public string TempCeil = "";
        public string FloorCeilEnter(Tkey key6)
        {
            TempFloor = "";
            TempCeil = "";
            floor = null;
            ceil = null;
            if (number == 0)
            {
                return "No number in this tree";
            }
            else
            {
                FloorCeil(root, key6);
                if (floor == null)
                {
                    TempFloor = "NoFloor";
                }
                else
                {
                    TempFloor = floor.key.ToString();
                }
                if (ceil == null)
                {
                    TempCeil = "NoCeil";
                }
                else
                {
                    TempCeil = ceil.key.ToString();
                }
                return "ok";
            }
        }
        public string ReturnFloor()
        {
            return TempFloor;
        }
        public string ReturnCeil()
        {
            return TempCeil;
        }
        private Node floor;
        private Node ceil;
        private void FloorCeil(Node node8, Tkey key7)
        {            
            if (node8 != null)
            {
                if ((key7 as IComparable).CompareTo(node8.key) > 0)
                {
                    floor = node8;
                    FloorCeil(node8.Right, key7);
                }
                else if ((key7 as IComparable).CompareTo(node8.key) < 0)
                {
                    ceil = node8;
                    FloorCeil(node8.Left, key7);
                }
                else
                {
                    floor = ceil = node8;
                }
                
            }
            //else
            //{
                
            //    //if (floor == null)
            //    //{
            //    //    TempFloor = "NoFloor";
            //    //}
            //    //else
            //    //{
            //    //    TempFloor = floor.key.ToString();
            //    //}
            //    //if (ceil == null)
            //    //{
            //    //    TempCeil = "NoCeil";
            //    //}
            //    //else
            //    //{
            //    //    TempCeil = ceil.key.ToString();
            //    //}
            //}
        }

        public string TempFC = "";
        private int count = 1;
        public string FindCountEnter(Tkey key8)
        {
            count = 1;
            //此处如果想在每次点击按钮时初始化TB_Count内的文字，应当在程序体里把TempFC初始化
            TempFC = "";
            FindCount(root, key8);
            return TempFC;
        }

        private void FindCount(Node node9, Tkey key9)
        {
            if (node9 != null)
            {
                //找到最左边（最小的）的节点
                FindCount(node9.Left, key9);
                //从最左边（最小的）的节点开始依次将它的key值和想查询位置的key值比较
                if ((key9 as IComparable).CompareTo(node9.key) != 0)
                {
                    //不等于就count++
                    count++;
                }
                else
                {
                    //等于则输出
                    TempFC = TempFC + "," + count.ToString();
                }
                //不等于的情况下继续查找下一个节点
                FindCount(node9.Right, key9);
            }
        }

        public string TempFCR = "";
        public string FindCountReverseEnter(Tkey key10)
        {
            count = 1;
            TempFCR = "";
            FindCountReverse(root, key10);
            return TempFCR;            
        }

        private void FindCountReverse(Node node10, Tkey key11)
        {
            if (node10 != null)
            {
                FindCount(node10.Right, key11);
                if ((key11 as IComparable).CompareTo(node10.key) != 0)
                {
                    count++;
                }
                else
                {
                    TempFCR = TempFCR + "," + count.ToString();
                }
                FindCount(node10.Left, key11);
            }
        }


        public string TempFK = "";
        public string FindKeyEnter(int CountWant)
        {
            count = 1;
            //此处如果想在每次点击按钮时初始化TB_Count内的文字，应当在程序体里把TempFC初始化
            TempFK = "";
            FindKey(root, CountWant);
            return TempFK;
        }

        private void FindKey(Node node11, int CountWant1)
        {
            if (node11 != null)
            {
                //找到最左边（最小的）的节点
                FindKey(node11.Left, CountWant1);
                //从最左边（最小的）的节点开始依次将它的count值和想查询位置的count值比较
                if (CountWant1 != count)
                {
                    //不等于就count++
                    count++;
                }
                else
                {
                    //等于则输出
                    TempFK = node11.key.ToString();
                    count++;
                }
                //不等于的情况下继续查找下一个节点
                FindKey(node11.Right, CountWant1);
            }
        }

    }
}
