namespace SingleLinkedListDemo
{
    /// <summary>
    /// 链表节点类
    /// </summary>
    public class Node<T>
    {
        /// <summary>
        /// 数据字段
        /// </summary>
        public T Data { get; set; }

        /// <summary>
        /// 指针 指向下一个元素
        /// </summary>
        public Node<T> Next { get; set; }

        /// <summary>
        /// 无参构造函数
        /// </summary>
        public Node()
        {
            // 赋默认值
            this.Data = default(T);
            this.Next = null;
        }

        /// <summary>
        /// 只传递数据字段的构造函数，指针默认为null
        /// </summary>
        /// <param name="value"></param>
        public Node(T value)
        {
            this.Data = value;
            this.Next = null;
        }

        /// <summary>
        /// 同时传递数据和指针的构造函数
        /// </summary>
        /// <param name="value"></param>
        /// <param name="next"></param>
        public Node(T value,Node<T> next)
        {
            this.Data = value;
            this.Next = next;
        }

        /// <summary>
        /// 只传递指针的构造函数
        /// </summary>
        /// <param name="next"></param>
        public Node(Node<T> next)
        {
            this.Next = next;
        }
    }
}
