using System;
using System.Collections.Generic;

namespace SingleLinkedListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 创建一个单向链表
            //int num;
            //string name;
            //int score;

            //Console.WriteLine("请输入5位学生的成绩:");
            //SingleLinkedList<Student> linkedList = new SingleLinkedList<Student>();
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write("请输入学号：");
            //    num = int.Parse(Console.ReadLine());
            //    Console.Write("请输入姓名：");
            //    name = Console.ReadLine();
            //    Console.Write("请输入成绩：");
            //    score = int.Parse(Console.ReadLine());
            //    Student student = new Student(number: num, name: name, score: score);
            //    linkedList.AddNode(student);
            //    Console.WriteLine("----------------");
            //}

            //Console.WriteLine();
            //Console.WriteLine("输出学生成绩信息");
            //List<Node<Student>> list = linkedList.ListNode;
            //foreach (var item in list)
            //{
            //    Console.WriteLine($"学号： {item.Data.Number},姓名： {item.Data.Name},成绩： {item.Data.Score}");
            //    Console.WriteLine();
            //} 
            #endregion

            #region 删除单向链表中的节点
            //Random rand = new Random();
            //StudentLinkedList list = new StudentLinkedList();
            //int i, j, findword = 0;
            //int[,] data = new int[12, 10];
            //String[] name = new String[] { "Allen", "Scott",
            //    "Marry", "Jon", "Mark", "Ricky", "Lisa",
            //    "Jasica", "Hanson", "Amy", "Bob", "Jack" };
            //Console.WriteLine("学号 成绩  学号 成绩  学号 成绩  学号  成绩");
            //// 链表里面添加12个节点
            //for (i = 0; i < 12; i++)
            //{
            //    data[i, 0] = i + 1;
            //    data[i, 1] = (Math.Abs(rand.Next(50))) + 50;
            //    StudentNode node = new StudentNode(data[i, 0], name[i], data[i, 1]);
            //    list.AddNode(node);
            //}
            //// 分三行输出
            //for (i = 0; i < 3; i++)
            //{
            //    for (j = 0; j < 4; j++)
            //        Console.Write("[" + data[j * 3 + i, 0] + "]  [" + data[j * 3 + i, 1] + "]  ");
            //    Console.WriteLine();
            //}
            //while (true)
            //{
            //    Console.Write("请输入要删除成绩的学生学号，结束输入-1： ");
            //    findword = int.Parse(Console.ReadLine());
            //    if (findword == -1)
            //        break;
            //    else
            //    {
            //        StudentNode current = new StudentNode(list.HeadNode.Number, list.HeadNode.Name, list.HeadNode.Score);
            //        current.Next = list.HeadNode.Next;
            //        while (current.Number != findword) current = current.Next;
            //        list.DeleteNode(current);
            //    }
            //    Console.WriteLine("删除后成绩的链表，请注意！要删除的成绩其学生的学号必须在此链表中\n");
            //    list.Print();
            //}
            #endregion

            #region 单向链表中插入节点
            SingleLinkedList<int> linkedList = new SingleLinkedList<int>();
            linkedList.AddNode(1);
            linkedList.AddNode(45);
            linkedList.AddNode(56);
            linkedList.AddNode(389);
            List<Node<int>> list = linkedList.ListNode;
            Console.WriteLine("插入前链表元素");
            linkedList.Print();
            Console.WriteLine();
            // 插入头节点之前
            linkedList.InsertNode(57, 0);
            Console.WriteLine("插入头节点后链表元素");
            linkedList.Print();
            Console.WriteLine();
            // 插入尾节点之后
            linkedList.InsertNode(123, linkedList.GetLinkedListLength()-1);
            Console.WriteLine("插入尾节点后链表元素");
            linkedList.Print();
            Console.WriteLine();
            // 插入中间节点
            int index= new Random().Next(0, linkedList.GetLinkedListLength() - 1);
            linkedList.InsertNode(935, index);
            Console.WriteLine("插入中间节点后链表元素");
            linkedList.Print();
            Console.WriteLine();
            #endregion
            Console.ReadKey();
        }
    }
}
