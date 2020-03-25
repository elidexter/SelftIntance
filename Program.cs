using System;
using System.Reflection;

namespace SelftIntance
{
    class Program
    {
        static void Main(string[] args)
        {
            var cla = GetInstance("SelftIntance.PersonaModel");
            var another=System.Reflection.Assembly.GetExecutingAssembly().CreateInstance("SelftIntance.PersonaModel");            
            Type thisType = another.GetType();
            MethodInfo theMethod = thisType.GetMethod("SayHello");
            theMethod.Invoke(another,null);// null means no parameters
            Console.ReadLine();
        }
        public static object GetInstance(string strFullyQualifiedName)
        {
            System.Type type = System.Type.GetType(strFullyQualifiedName);
            if (type != null)
                return Activator.CreateInstance(type);
            foreach (var asm in AppDomain.CurrentDomain.GetAssemblies())
            {
                type = asm.GetType(strFullyQualifiedName);
                if (type != null)
                    return Activator.CreateInstance(type);
            }
            return null;
        }
    }
}
