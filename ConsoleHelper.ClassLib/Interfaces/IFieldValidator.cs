namespace ConsoleHelper.ClassLib.Interfaces{

    public delegate bool FieldValidator();
    public interface IFieldValidator{
        string[] FieldArray{get;}
        void InitializeValidator();
    }
}