using System;
using System.Collections.Generic;

namespace SingleLinkedListDemo
{
    /// <summary>
    /// 单向链表类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class SingleLinkedList<T>
    {
        /// <summary>
        /// 存放所有链表节点的集合
        /// </summary>
        public List<Node<T>> ListNode { get; set; }

        /// <summary>
        /// 构造函数
        /// </summary>
        public SingleLinkedList()
        {
            ListNode = new List<Node<T>>();
        }

        /// <summary>
        /// 头节点
        /// </summary>
        private Node<T> HeadNode;

        /// <summary>
        /// 尾节点
        /// </summary>
        private Node<T> LastNode;

        /// <summary>
        /// 判断当前链表是否为空链表
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return HeadNode == null;
        }

        /// <summary>
        /// 新增节点
        /// </summary>
        public void AddNode(T item)
        {
            // 新建一个节点
            Node<T> newNode = new Node<T>(item);
           
            // 判断头节点是否为null,如果为null，那么新建的节点就是头节点，同时也是尾节点
            if (IsEmpty())
            {
                // 如果是空链表，则将头节点和尾节点都指向新建的节点
                HeadNode = newNode;
                LastNode = newNode;
            }
            else
            {
                // 尾节点的指针指向新建的节点
                // 新建的节点变为尾节点
                LastNode.Next = newNode;
                LastNode = newNode;
            }
            // 将新建的节点添加到集合中
            ListNode.Add(newNode);
        }

        /// <summary>
        /// 插入节点
        /// </summary>
        /// <param name="item">要插入的节点的值</param>
        /// <param name="index">要插入节点的位置</param>
        public void InsertNode(T item,int index)
        {
            // 创建新的节点
            Node<T> newNode = new Node<T>(item);
            //Node<T> tmpNode = new Node<T>(item);

            // 判断当前链表是否为空链表
            if(IsEmpty())
            {
                HeadNode = newNode;
                LastNode = newNode;
            }
            else
            {
                // 插入第一个节点
                if(index==0)
                {
                    // 新节点执行现在的头节点
                    newNode.Next = HeadNode;
                    // 新节点变为新的头节点
                    HeadNode = newNode;
                }
                else if(index==GetLinkedListLength()-1)
                {
                    // 插入尾节点
                    // 定义一个临时节点tempNode指向HeadNode
                    Node<T> tempNode = HeadNode;
                    // 循环找到尾节点
                    while(true)
                    {
                        // 如果tempNode的next不为null，说明当前节点不是尾节点，则后移
                        if(tempNode.Next!=null)
                        {
                            // 当前tempNode后移
                            tempNode = tempNode.Next;
                        }
                        else
                        {
                            // tempNode的next为null，说明tempNode节点是尾节点，则退出循环
                            break;
                        }
                    }
                    // tempNode是尾节点，则将尾节点的next指向新的节点
                    tempNode.Next = newNode;
                }
                else
                {
                    #region 插入中间位置
                    // 定义临时节点指向头节点
                    Node<T> tempNode = HeadNode;
                    // 经过index-1次循环后移，tempNode移动到要插入位置的前一个节点
                    for (int i = 0; i <=index-1; i++)
                    {
                        // tempNode节点每次后移一个位置
                        tempNode = tempNode.Next;
                    }
                    // 要插入位置的前一个节点
                    Node<T> preNode = tempNode;
                    // 要插入位置的节点
                    Node<T> currentNode = preNode.Next;
                    // 修改next指向，前一个节点指向新节点
                    preNode.Next = newNode;
                    // 新节点指向当前位置的节点
                    newNode.Next = currentNode;
                    #endregion
                }
            }
        }

        /// <summary>
        /// 获取链表长度
        /// </summary>
        /// <returns></returns>
        public int GetLinkedListLength()
        {
            // 长度
            int length = 0;
            if(HeadNode==null)
            {
                length = 0;
            }
            else
            {
                Node<T> tempNode = HeadNode;
                // 循环
                while(true)
                {
                    if(tempNode.Next!=null)
                    {
                        // 当前临时节点后移到下一个节点
                        tempNode = tempNode.Next;
                        // 长度自增
                        length++;
                    }
                    else
                    {
                        // 说明循环到了尾节点，退出循环
                        length++;
                        break;
                    }
                }
            }
            return length;
        }

        /// <summary>
        /// 打印
        /// </summary>
        public void Print()
        {
            //StudentNode current = HeadNode;
            //while (current != null)
            //{
            //    Console.WriteLine("[" + current.Number + " " + current.Name + " " + current.Score + "]");
            //    current = current.Next;
            //}

            Node<T> current = HeadNode;
            while (current != null)
            {
                Console.Write( current.Data+"  ");
                current = current.Next;
            }
            Console.WriteLine();
        }
    }
}
