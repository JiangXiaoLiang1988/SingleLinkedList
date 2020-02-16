using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedListDemo
{
    /// <summary>
    /// 演示删除节点使用的节点类
    /// </summary>
    public class StudentNode
    {
        /// <summary>
        /// 学号
        /// </summary>
        public int Number { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 成绩
        /// </summary>
        public int Score { get; set; }

        /// <summary>
        /// 指针 指向下一个元素
        /// </summary>
        public StudentNode Next { get; set; }

        public StudentNode(int number,string name,int score)
        {
            Number = number;
            Name = name;
            Score = score;
        }
    }
}
