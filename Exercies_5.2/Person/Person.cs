namespace Exercies_5._2.Person
{
    public abstract class Person
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }

        public abstract void  AcceptPerson();
    }
}