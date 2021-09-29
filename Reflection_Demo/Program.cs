using System;
using System.Reflection;

namespace Reflection_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            TestCustomerDetailsUsingReflection();
            Console.ReadLine();
        }
        /// <summary>
        /// Tests the customer details using reflection.
        /// </summary>
        public static void TestCustomerDetailsUsingReflection()
        {
            //Assembly can also load from path
            //Assembly.LoadFrom("Write the path")
            //Assembly-predefined class,GetExecutingAssembly()-method which return assembly name which is executing
            Assembly assembly = Assembly.GetExecutingAssembly();
            //Type[]-loads array of all class files present in the assembly
            Type[] types = assembly.GetTypes();
            foreach(Type t in types)
            {
                Console.WriteLine("Available classes from current assembly:" +t.FullName);
            }
            //Type- predefined class, type-object of Type, GetType-Method() in Type class which gives the info about (namespace.class name)
            Type type = Type.GetType("Reflection_Demo.CustomerDetails");
            //Fullname-namespace.classname, Name-classname
            Console.WriteLine("FullName :" + type.FullName);
            Console.WriteLine("Name :" + type.Name);
            //Extracting properties=variables in the class 
            //PropertyInfo[]=predefined class,GetProperties-used to get all the variables declared in the class
            PropertyInfo[] propertyInfos = type.GetProperties();
            Console.WriteLine("Fetching Customer property details");
            foreach (PropertyInfo property in propertyInfos)
            {
                Console.WriteLine("ReturnType:" + property.PropertyType + "\t PropertyName:" + property.Name);
            }
            Console.WriteLine("Fetching Customer Method Details");
            //It retuns all methids created in the class, if there is no methods it returns a empty []
            MethodInfo[] methodInfos = type.GetMethods();
            foreach (MethodInfo method in methodInfos)
            {
                Console.WriteLine("ReturnType:" + method.DeclaringType + "\t Method Name:" + method.Name);
            }
            Console.WriteLine("Fetching Customer Method Details");
            //It retuns all the contructor present in the class 
            ConstructorInfo[] constructorInfos = type.GetConstructors();
            // info retruns void .ctor , void because constructor have no return type
            // ctor =constructors
            foreach (ConstructorInfo info in constructorInfos)
            {
                Console.WriteLine(info.Name);
                Console.WriteLine(info.ToString());
            }
        }
    }
}
