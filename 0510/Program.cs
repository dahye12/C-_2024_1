class program
{
    class Parent
    {
        public int variable = 273;

    }
     class Child : Parent
    {
        public string variable = "shadowing";

    }
    static void Main(String[] args)
    {
        Child child = new Child();
        Console.WriteLine(child.variable);
        Console.WriteLine(((Parent)child).variable); // shadowing 말고 273도 출력되게 형변환 한 것
    }
}