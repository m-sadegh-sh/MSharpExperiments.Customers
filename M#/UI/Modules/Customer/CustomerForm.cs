using MSharp;

namespace Modules
{
    class CustomerForm : FormModule<Domain.Customer>
    {
        public CustomerForm()
        {
            Field(x => x.Country)
                .Control(ControlType.DropdownList)
                .Mandatory(true);

            Field(x => x.CompanyName)
                .Control(ControlType.Textbox)
                .Mandatory(true);

            Field(x => x.ContractStartDate)
                .Control(ControlType.DatePicker)
                .Mandatory(true);

            Field(x => x.Logo)
                .Control(ControlType.FileUpload)
                .Mandatory(false);

            Field(x => x.Contract)
                .Control(ControlType.FileUpload)
                .Mandatory(false);

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