namespace ConsoleHelper.ClassLib.Interfaces{
    public interface IVew
    {
        IFieldValidator FieldValidator {get;}
        IEnumerable<IVew> ViewList {get;}
        void RunView();
    }
}