using System.Reflection;

namespace AOPDemo
{
    public class Dispatcher<T> : DispatchProxy
    {
        public T Target { get; set; }

        public static T Create<T>(T target) where T : class
        {
            var proxy = Create<T, Dispatcher<T>>()
                as Dispatcher<T>;

            proxy.Target = target;
            return proxy as T;
        }

        protected override object Invoke(MethodInfo targetMethod, object[] args)
        {
            System.Console.WriteLine($"Logger, {targetMethod.Name} Calling!");
            var result = targetMethod.Invoke(Target, args);
            System.Console.WriteLine($"Logger, {targetMethod.Name} Called!");

            return result;
        }
    }
}