namespace DesignPatterns.ClassLib
{
    public interface IFactory<T,K> where T : class,K,new(){
        K GetInstance();
    }

    public class FactoryPattern<T,K> where T : class,K,new(){
        public static K GetInstance(){
            K objK;
            objK = new T();
            return objK;
        }
    }
}