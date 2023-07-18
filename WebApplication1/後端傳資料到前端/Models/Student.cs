namespace 後端傳資料到前端.Models
{
    public class Student
    {
        public string id { get; set; }
        public string name { get; set; }
        public int score { get; set; }

        public Student(string id, string name, int score)
        {
            id = id;
            name = name;
            score = score;
        }
    }
}
