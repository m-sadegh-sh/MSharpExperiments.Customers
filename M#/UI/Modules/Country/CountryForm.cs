using MSharp;

namespace Modules
{
    class CountryForm : FormModule<Domain.Country>
    {
        public CountryForm()
        {            
            Field(x => x.Name)
                .Control(ControlType.Textbox)
                .Mandatory(true);
            
            Button("Cancel")
                .CausesValidation(false)
                .Icon(FA.Backward)
                .OnClick(x => x.CloseModal());
            
            Button("Save")
                .IsDefault()
                .Icon(FA.Check)
                .OnClick(x =>
                {
                    x.SaveInDatabase();
                    x.GentleMessage("Saved successfully.");
                    x.CloseModal(Refresh.Full);
                });
        }
    }
}