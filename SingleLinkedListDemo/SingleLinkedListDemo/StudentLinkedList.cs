using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedListDemo
{
    public class StudentLinkedList
    {

        public List<StudentNode> ListNode { get; set; }


        public StudentLinkedList()
        {
            ListNode = new List<StudentNode>();
        }


        /// <summary>
        /// 头节点
        /// </summary>
        public StudentNode HeadNode;

        /// <summary>
        /// 尾节点
        /// </summary>
        public StudentNode LastNode;

        /// <summary>
        /// 判断当前链表是否为空链表
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return HeadNode == null;
        }

        /// <summary>
        /// 添加节点
        /// </summary>
        /// <param name="node"></param>
        public void AddNode(StudentNode node)
        {
            StudentNode newNode = node;
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
        /// 打印
        /// </summary>
        public void Print()
        {
            StudentNode current = HeadNode;
            while (current != null)
            {
                Console.WriteLine("[" + current.Number + " " + current.Name + " " + current.Score + "]");
                current = current.Next;
            }
        }

        /// <summary>
        /// 删除节点
        /// </summary>
        /// <param name="delNode"></param>
        public void DeleteNode(StudentNode delNode)
        {
            StudentNode newNode;
            StudentNode tmpNode;

            // 如果删除的是第一个节点
            if(HeadNode.Number==delNode.Number)
            {
                // 头指针指向第二个节点
                HeadNode = HeadNode.Next;
            }
            else if(LastNode.Number==delNode.Number)
            {
                // 删除的是最后一个节点
                newNode = HeadNode;
                // 循环找到最后一个节点的前一个节点
                // 当退出循环的时候newNode就是最后一个节点的前一个节点
                while(newNode.Next!=LastNode)
                {
                    // 指针后移，指向下一个节点
                    newNode = newNode.Next;
                }
                // 最后一个节点的前一个节点的next赋值为null
                newNode.Next = null;
                LastNode = newNode;
            }
            else
            {
                // 删除的是中间的节点
                newNode = HeadNode;
                tmpNode = HeadNode;
                // 循环找到要删除的节点
                // 循环退出时tmpNode节点就是要删除节点的前一个节点,newNode节点就是要删除的节点
                while(newNode.Number!=delNode.Number)
                {
                    tmpNode = newNode;
                    // 后移，指向下一个节点
                    newNode = newNode.Next;
                }
                // 要删除节点的前一个节点的next指向删除节点的下一个节点
                tmpNode.Next = newNode.Next;
            }
        }

    }
}
