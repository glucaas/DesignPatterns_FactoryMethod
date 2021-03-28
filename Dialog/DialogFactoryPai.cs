using DesignPatterns_FactoryMethod.Buttons;

namespace DesignPatterns_FactoryMethod.Dialog
{
    public abstract class DialogFactory
    {
        public void Render(){
            Button btt = CreateButton();
            btt.Click();
            btt.Render();
        }
        public abstract Button CreateButton();
    }
}