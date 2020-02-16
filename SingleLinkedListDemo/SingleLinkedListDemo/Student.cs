namespace SingleLinkedListDemo
{
    /// <summary>
    /// 学生类
    /// </summary>
    public class Student
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

        public Student(int number,string name,int score)
        {
            Number = number;
            Name = name;
            Score = score;
        }
    }
}
