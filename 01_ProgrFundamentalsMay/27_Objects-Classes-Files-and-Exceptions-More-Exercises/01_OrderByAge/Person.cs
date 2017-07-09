namespace _01_OrderByAge
{
    class Person
    {
        public Person(string name, string id , int age)
        {
            this.Name = name;
            this.Id = id;
            this.Age = age;
        }

        public string Name { get; set; }
        public string Id { get; set; }
        public int Age { get; set; } 
    } 
}
