

using DesignPatterns_FactoryMethod.Buttons;

namespace DesignPatterns_FactoryMethod.Dialog
{
    public class WindownsDialog: DialogFactory
    {
        public WindownsDialog()
        {
        }

        public override Button CreateButton()
        {
            return new WindownsButton();
        }
    }
}