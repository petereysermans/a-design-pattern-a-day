namespace ADesignPatternADay.Specification
{
    public class Person
    {
        private int  _age;

        public Person(int age)
        {
            _age = age;
        }

        public int Age { get { return _age; } }
    }
}