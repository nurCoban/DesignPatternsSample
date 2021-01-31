using System;

namespace Mediator
{
    class Demo
    {
        static void Main(string[] args)
        {
            Mediator mediator = new Mediator();

            CheckBoxColleague checkBox = new CheckBoxColleague(mediator);
            ButtonColleague button = new ButtonColleague(mediator);
            ComboBoxColleague comboBox  = new ComboBoxColleague(mediator);

            checkBox.TriggerEvent("checkbox is checked!");

            comboBox.TriggerEvent("combobox selected item changed!");

            button.TriggerEvent("button is clicked!");

            checkBox.TriggerEvent("checkbox is unchecked!");

            Console.ReadLine();
        }
    }
}
