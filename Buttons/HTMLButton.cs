namespace DesignPatterns_FactoryMethod.Buttons
{
    public class HTMLButton : Button
    {
        public void Click()
        {
            System.Console.WriteLine("Implementando click com HTML");
        }

        public void Render()
        {
            System.Console.WriteLine("Implementando rendereizacao HTML");
        }
    }
}