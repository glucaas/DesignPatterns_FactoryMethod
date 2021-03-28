using DesignPatterns_FactoryMethod.Buttons;

namespace DesignPatterns_FactoryMethod.Dialog
{
    public class WebDialog : DialogFactory
    {
        public WebDialog()
        {
        }

        public override Button CreateButton()
        {
            return new HTMLButton();
        }
    }
}