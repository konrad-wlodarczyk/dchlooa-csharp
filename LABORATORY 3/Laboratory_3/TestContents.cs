using System;
using System.Collections.Generic;
using System.Linq;

#pragma warning disable CS8600, CS8602, CS8605, CS8625

namespace C3
{
    // testing code for Submarine elements
    partial class TestSubmarine
    {
        // test if a class with given name exists in the project
        // name should be in the same namespace as the main Program class
        private static bool TestClass(string name)
        {
            testNumber++;
            Console.WriteLine();
            Type type = Type.GetType(nms + "." + name);
            if (type == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Test " + testNumber + " failed: class " + name + " not found.");
                failed++;
                return false;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Test " + testNumber + " passed: class " + name + " identified.");
            return true;
        }

        // test if a class with a given name inherits after another class or interface (works for both)
        // only use after confirming that these classes exist in the project
        private static bool TestInheritance(string baseClassOrInterface, string derivedClass)
        {
            testNumber++;
            Type derivedObj = Type.GetType(nms + "." + derivedClass);
            Type baseObj = Type.GetType(nms + "." + baseClassOrInterface);
            if (baseObj.IsAssignableFrom(derivedObj))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Test " + testNumber + " passed: class " + derivedClass + " inherits from " + baseClassOrInterface + ".");
                return true;
            }
            failed++;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Test " + testNumber + " failed: class " + derivedClass + " does not inherit from " + baseClassOrInterface + ".");
            return false;
        }

        // test if a class with a given name is an abstract class
        // only use after confirming that this class exists in the project
        private static bool TestAbstract(string name)
        {
            // this test is invisible unless it fails 
            Type type = Type.GetType(nms + "." + name);
            if (!type.IsAbstract)
            {
                testNumber++;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Test " + testNumber + " failed: class " + name + " is not marked as abstract.");
                failed++;
                return false;
            }
            return true;
        }

        // test if a class with a given name has a public property with given name and type
        // only use after confirming that this class exists in the project
        // type names whould be compatible with C# formal names, e.g. Double instead of double (you can omit System namespace though)
        private static bool TestProperty(string className, string name, string targetType)
        {
            testNumber++;
            Type type = Type.GetType(nms + "." + className);
            var property = type.GetProperty(name);
            if (property == null || !property.PropertyType.ToString().EndsWith("." + targetType))
            {
                failed++;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Test " + testNumber + " failed: unable to find property " + name + " in class " + className + ".");
                return false;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Test " + testNumber + " passed: property " + name + " in class " + className + " identified correctly.");
                return true;
            }
        }

        // test if a class with a given name contains a given constructor (with argument types given as list of strings)
        // only use after confirming that this class exists in the project
        // type name remarks from TestProperty also apply here
        // note: currently, the order of the arguments is not checked (perhaps this should be changed in the future)
        private static bool TestConstructor(string className, List<string> arguments)
        {
            testNumber++;
            Type type = Type.GetType(nms + "." + className);
            var constructors = type.GetConstructors();
            foreach (var constructor in constructors)
            {
                var param = constructor.GetParameters();
                if (param.Length == arguments.Count)
                {
                    bool test = true;
                    for (int i = 0; i < arguments.Count; i++)
                    {
                        if (!param[i].ParameterType.ToString().EndsWith("." + arguments[i])) test = false;
                    }
                    if (test)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Test " + testNumber + " passed: constructor of class " + className + " identified correctly.");
                        return true;
                    }
                }
            }
            failed++;
            if (arguments.Count > 0) // this if is for easier console display
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Test " + testNumber + " failed: unable to find constructor of class " + className + " with arguments: ");
                for (int i = 0; i < arguments.Count - 1; i++) Console.Write(arguments[i] + ", ");
                Console.WriteLine(arguments[arguments.Count - 1] + ". (Hint: remember to use correct parameter order.)");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Test " + testNumber + " failed: unable to find default constructor of class " + className + ".");
            }
            return false;
        }

        // test if a class with a given name contains a default constructor
        // only use after confirming that this class exists in the project
        private static bool TestDefaultConstructor(string className)
        {
            // this test is invisible unless it fails 
            // one would have to hide a default constructor on purpose to trigger it
            Type type = Type.GetType(nms + "." + className);
            var constructor = type.GetConstructor(Type.EmptyTypes);
            if (constructor != null) return true;
            testNumber++;
            failed++;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Test " + testNumber + " failed: unable to find default constructor of class " + className + ".");
            return false;
        }

        // test if a class with a given name contains a method
        // method specification: returnType methodName(arguments), e.g. Double MyMethod(Double, String)
        // only use after confirming that this class exists in the project
        // type name remarks from above also apply here
        private static bool TestMethod(string className, string methodName, string returnType, List<string> arguments)
        {
            testNumber++;
            bool ans = true;
            Type type = Type.GetType(nms + "." + className);
            var method = type.GetMethod(methodName);
            if (method == null) ans = false;
            else
            {
                if (!method.ReturnType.ToString().EndsWith(returnType)) ans = false;
                else
                {
                    var param = method.GetParameters();
                    if (param.Length == arguments.Count)
                    {
                        foreach (string argument in arguments)
                        {
                            if (!param.Any(x => x.ParameterType.ToString().EndsWith("." + argument))) ans = false;
                        }
                    }
                    else ans = false;
                }
            }
            if (!ans)
            {
                failed++;
                Console.ForegroundColor = ConsoleColor.Red;
                if (arguments != null && arguments.Count > 0) // this if is for easier console display
                {
                    Console.Write("Test " + testNumber + " failed: unable to find method " + returnType + " " +
                    methodName + "(");
                    for (int i = 0; i < arguments.Count - 1; i++) Console.Write(arguments[i] + ", ");
                    Console.WriteLine(arguments[arguments.Count - 1] + ") of class " + className + ".");
                }
                else
                {
                    Console.WriteLine("Test " + testNumber + " failed: unable to find method " + returnType + " " +
                    methodName + "( ) of class " + className + ".");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                if (arguments != null && arguments.Count > 0)
                {
                    Console.Write("Test " + testNumber + " passed: method " + returnType + " " +
                    methodName + "(");
                    for (int i = 0; i < arguments.Count - 1; i++) Console.Write(arguments[i] + ", ");
                    Console.WriteLine(arguments[arguments.Count - 1] + ") of class " + className + " identified correctly.");
                }
                else
                {
                    Console.WriteLine("Test " + testNumber + " passed: method " + returnType + " " +
                    methodName + "( ) of class " + className + " identified correctly.");
                }
            }
            return ans;
        }

        // test if a class with a given name contains a given getter
        // only use after confirming that this class with this property exists in the project
        private static bool TestGetter(string className, string property)
        {
            // this test is invisible unless it fails 
            Type type = Type.GetType(nms + "." + className);
            if (type.GetProperty(property).GetGetMethod() != null) return true;
            testNumber++;
            failed++;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Test " + testNumber + " failed: unable to find getter of " + property + " in class " + className + ".");
            return false;
        }


        /*                                                                                                              */
        /*                                           generic tests end here                                             */
        /* the tests below are meant specifically for the submarine project and check logic (not existence) of elements */
        /*                                                                                                              */


        private static bool TestMaxCapacity(string className, object inst = null)
        {
            Type type = Type.GetType(nms + "." + className);
            object instance;
            if (inst == null)
            {
                var constructor = type.GetConstructor(new[] { typeof(double) });
                instance = constructor.Invoke(new object[] { 100.0 });
            }
            else instance = inst;
            // test if capacity was set correctly
            testNumber++;
            double? capacity = (double?)type.GetProperty("MaxCapacity").GetValue(instance);
            if (capacity == null || capacity != 100.0)
            {
                failed++;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Test " + testNumber + " failed: " + className + " does not set MaxCapacity in constructor.");
                return false;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Test " + testNumber + " passed: MaxCapacity set in constructor of  " + className + ".");
                return true;
            }
        }
        private static bool TestWeightVolume(string className, object[] parameters, object inst = null)
        {
            // specific test for weight/volume logic
            Type type = Type.GetType(nms + "." + className);
            object instance;
            if (inst == null)
            {
                List<Type> paramTypes = new List<Type>();
                foreach (object parameter in parameters) paramTypes.Add(parameter.GetType());
                var constructor = type.GetConstructor(paramTypes.ToArray());
                instance = constructor.Invoke(parameters);
            }
            else instance = inst;
            bool ans = true;
            // change volume and check if weight was updated automatically
            testNumber++;
            double? oldWeight = (double?)type.GetProperty("Weight").GetValue(instance);
            if (oldWeight != null) type.GetProperty("Volume").SetValue(instance, oldWeight + 1.0);
            double? newWeight = (double?)type.GetProperty("Weight").GetValue(instance);
            if (newWeight == null || newWeight == oldWeight)
            {
                failed++;
                ans = false;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Test " + testNumber + " failed: changing volume in " + className + " did not update weight.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Test " + testNumber + " passed: weight of " + className + " updated correctly with volume.");
            }
            // do the same for reverse
            testNumber++;
            double? oldVolume = (double?)type.GetProperty("Volume").GetValue(instance);
            if (oldVolume != null) type.GetProperty("Weight").SetValue(instance, oldVolume + 1.0);
            double? newVolume = (double?)type.GetProperty("Volume").GetValue(instance);
            if (newVolume == null || newVolume == oldVolume)
            {
                failed++;
                ans = false;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Test " + testNumber + " failed: changing weight in " + className + " did not update volume.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Test " + testNumber + " passed: volume of " + className + " updated correctly with weight.");
            }
            return ans;
        }

        private static bool TestVisitPort(string className, bool toMax, object[] parameters, object inst = null)
        {
            // specific test for VisitPort method
            testNumber++;
            Type type = Type.GetType(nms + "." + className);
            object instance;
            if (inst == null)
            {
                List<Type> paramTypes = new List<Type>();
                foreach (object parameter in parameters) paramTypes.Add(parameter.GetType());
                var constructor = type.GetConstructor(paramTypes.ToArray());
                instance = constructor.Invoke(parameters);
            }
            else instance = inst;
            var method = type.GetMethod("VisitPort");
            type.GetProperty("Volume").SetValue(instance, 5.0);
            method.Invoke(instance, new object[] { });
            if (toMax) // in this case, VisitPort should set volume to maximum capacity
            {
                if((double)type.GetProperty("Volume").GetValue(instance) == (double)type.GetProperty("MaxCapacity").GetValue(instance))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Test " + testNumber + " passed: volume of " + className + " set to MaxCapacity after visiting port.");
                    return true;
                }
                else
                {
                    failed++;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Test " + testNumber + " failed: volume of " + className + " was not set to MaxCapacity after visiting port.");
                    return false;
                }
            }
            else // in this case, VisitPort should set volume to zero
            {
                if ((double)type.GetProperty("Volume").GetValue(instance) == 0.0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Test " + testNumber + " passed: volume of " + className + " set to zero after visiting port.");
                    return true;
                }
                else
                {
                    failed++;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Test " + testNumber + " failed: volume of " + className + " was not set to zero after visiting port.");
                    return false;
                }
            }
        }
    }
}
