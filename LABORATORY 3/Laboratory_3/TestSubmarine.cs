using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

#pragma warning disable CS8600, CS8601, CS8602, CS8604, CS8605

namespace C3
{
    // testing code for Submarine elements
    // most of the actual logic is in TestContents.cs
    partial class TestSubmarine
    {
        private static int testNumber = 0;
        private static int failed = 0;
        private static string nms = typeof(Program).Namespace;
        public static bool Run()
        {
            bool ansHuman = false; // for life support system
            if (ansHuman = TestClass("Human"))
            {
                TestInheritance("ITransportable", "Human");
                TestAbstract("Human");
            }
            if (TestClass("Scientist"))
            {
                TestInheritance("Human", "Scientist");
                TestMethod("Scientist", "Work", "Void", new List<string> { "Double" });
                if(TestConstructor("Scientist", new List<string>() { "Equipment" })) TestWeightVolume("Scientist", new object[] { new Equipment() });
            }
            if (TestClass("Crewman"))
            {
                TestInheritance("Human", "Crewman");
                if(TestDefaultConstructor("Crewman")) TestWeightVolume("Crewman", new object[] { });
            }
            bool ansFuel = false; // for FuelTank
            if (ansFuel = TestClass("Fuel"))
            {
                TestInheritance("ITransportable", "Fuel");
                TestAbstract("Fuel");
                TestProperty("Fuel", "Type", "String");
                TestGetter("Fuel", "Type");
            }
            if (TestClass("FuelNuclear"))
            {
                TestInheritance("Fuel", "FuelNuclear");
                if (TestDefaultConstructor("FuelNuclear")) TestWeightVolume("FuelNuclear", new object[] { });
            }
            bool ansFuelD = false; // for FuelTank
            if (ansFuelD = TestClass("FuelDiesel"))
            {
                TestInheritance("Fuel", "FuelDiesel");
                if (TestDefaultConstructor("FuelDiesel")) TestWeightVolume("FuelDiesel", new object[] { });
            }
            bool ansFuelTank = false; // for Engine
            if (TestClass("FuelTank"))
            {
                bool ans1 = TestInheritance("IVisitPort", "FuelTank");
                bool ans2 = TestProperty("FuelTank", "MaxCapacity", "Double");
                bool ans3 = TestConstructor("FuelTank", new List<string>() { "Double", "Fuel" });
                bool ans4 = TestGetter("FuelTank", "MaxCapacity");
                TestMethod("FuelTank", "GetFuelType", "String", new List<string>() { });
                if (ans1 && ans2 && ans3 && ans4 && ansFuel && ansFuelD) 
                {
                    ansFuelTank = true;
                    var fuelDiesel = Type.GetType(nms + ".FuelDiesel").GetConstructor(Type.EmptyTypes).Invoke(new object[] { });
                    var constructor = Type.GetType(nms + ".FuelTank").GetConstructors().First();
                    try
                    {
                        var instance = constructor.Invoke(new object[] { 100.0, fuelDiesel });
                        TestWeightVolume("FuelTank", new object[] { }, instance);
                        TestVisitPort("FuelTank", true, new object[] { }, instance);
                    }
                    catch (Exception e) when (e is ArgumentException || e is TargetParameterCountException)
                    {
                        ansFuelTank = false;
                        testNumber++;
                        failed++;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Test " + testNumber + " failed: wrong order of arguments in FuelTank constructor. " + e);
                    }
                }
            }
            bool ansWaste = false; // for life support system
            if (ansWaste = TestClass("Waste"))
            {
                bool ans1 = TestInheritance("IVisitPort", "Waste");
                bool ans2 = TestDefaultConstructor("Waste");
                if(ans1 && ans2)
                {
                    TestWeightVolume("Waste", new object[] { });
                    TestVisitPort("Waste", false, new object[] { });
                }
            }
            bool ansOxygen = false; // for life support system
            if (ansOxygen = TestClass("OxygenBottle"))
            {
                bool ans1 = TestInheritance("IVisitPort", "OxygenBottle");
                bool ans2 = TestProperty("OxygenBottle", "MaxCapacity", "Double");
                bool ans3 = TestConstructor("OxygenBottle", new List<string>() { "Double" });
                bool ans4 = TestGetter("OxygenBottle", "MaxCapacity");
                if (ans1 && ans2 && ans3 && ans4)
                {
                    TestMaxCapacity("OxygenBottle");
                    TestWeightVolume("OxygenBottle", new object[] { 100.0 });
                    TestVisitPort("OxygenBottle", true, new object[] { 100.0 });
                }
            }
            bool ansFood = false; // for life support system
            if (ansFood = TestClass("FoodContainer"))
            {
                bool ans1 = TestInheritance("IVisitPort", "FoodContainer"); 
                bool ans2 = TestConstructor("FoodContainer", new List<string>() { "Double" });
                bool ans3 = TestProperty("FoodContainer", "MaxCapacity", "Double");
                bool ans4 = TestGetter("FoodContainer", "MaxCapacity");
                if(ans1 && ans2 && ans3 && ans4)
                {
                    TestMaxCapacity("FoodContainer");
                    TestWeightVolume("FoodContainer", new object[] { 100.0 });
                    TestVisitPort("FoodContainer", true, new object[] { 100.0 });
                }
            }
            if (TestClass("Engine"))
            {
                bool ans1 = TestConstructor("Engine", new List<string>() { "FuelTank", "Waste" });
                bool ans2 = TestMethod("Engine", "GetVelocity", "Double", new List<string>() { "Double" });
                bool ans3 = TestMethod("Engine", "CheckFuelBeforeTravel", "Boolean", new List<string>() { "Double" });
                bool ans4 = TestMethod("Engine", "Travel", "Void", new List<string>() { "Double" });
                if(ans1 && ans2 && ans3 && ans4 && ansWaste && ansFuelTank)
                {
                    // logic tests for Engine are put here
                    object instance = null;
                    object tank = null;
                    object waste = null;
                    Type type = Type.GetType(nms + ".Engine");
                    try
                    {
                        waste = Type.GetType(nms + ".Waste").GetConstructor(Type.EmptyTypes).Invoke(new object[] { });
                        var fuelDiesel = Type.GetType(nms + ".FuelDiesel").GetConstructor(Type.EmptyTypes).Invoke(new object[] { });
                        var constructorTank = Type.GetType(nms + ".FuelTank").GetConstructors().First();
                        tank = constructorTank.Invoke(new object[] { 100.0, fuelDiesel });
                        var constructor = Type.GetType(nms + ".Engine").GetConstructors().First();
                        instance = constructor.Invoke(new object[] { tank, waste });
                    }
                    catch (Exception e) when (e is ArgumentException || e is TargetParameterCountException)
                    {
                        testNumber++;
                        failed++;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Test " + testNumber + " failed: wrong order of arguments in Engine constructor. " + e);
                    }
                    if(instance != null && tank != null && waste != null)
                    {
                        // does velocity change with mass?
                        testNumber++;
                        Random RNG = new Random();
                        double testDouble = RNG.NextDouble(); 
                        var method = type.GetMethod("GetVelocity");
                        if((double)method.Invoke(instance, new object[] { testDouble }) == (double)method.Invoke(instance, new object[] { testDouble + 10.0 }))
                        {
                            failed++;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Test " + testNumber + " failed: submarine velocity did not change with mass.");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Test " + testNumber + " passed: submarine velocity changed with mass."); 
                        }
                        // can we travel with zero fuel? 
                        testNumber++;
                        (Type.GetType(nms + ".FuelTank")).GetProperty("Volume").SetValue(tank, 0.0);
                        method = type.GetMethod("CheckFuelBeforeTravel");
                        if((bool)method.Invoke(instance, new object[] { 1.0 }))
                        {
                            failed++;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Test " + testNumber + " failed: CheckFuelBeforeTravel returned true despite no fuel.");
                        }
                        else 
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Test " + testNumber + " passed: CheckFuelBeforeTravel returned false for no fuel.");
                        }
                        // are fuel and waste values updated during travel?
                        testNumber++;
                        (Type.GetType(nms + ".FuelTank")).GetProperty("Volume").SetValue(tank, 100.0);
                        (Type.GetType(nms + ".Waste")).GetProperty("Volume").SetValue(waste, 0.0);
                        (type.GetMethod("Travel")).Invoke(instance, new object[] { 0.1 });
                        if((double)(Type.GetType(nms + ".FuelTank")).GetProperty("Volume").GetValue(tank) < 100.0 
                            && (double)(Type.GetType(nms + ".Waste")).GetProperty("Volume").GetValue(waste) > 0.0)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Test " + testNumber + " passed: Travel method correctly updated fuel and waste values.");
                        }
                        else
                        {
                            failed++;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Test " + testNumber + " failed: Travel method did not decrease fuel or did not increase waste value.");
                        }
                    }
                }
            }
            if (TestClass("LifeSupportSystem"))
            {
                bool ans1 = TestConstructor("LifeSupportSystem", new List<string>() { "List`1[" + nms + ".OxygenBottle]",
                    "FoodContainer", "Waste", "List`1[" + nms + ".Human]" });
                bool ans2 = TestMethod("LifeSupportSystem", "CheckSuppliesBeforeTravel", "Boolean", new List<string>() { "Double" });
                bool ans3 = TestMethod("LifeSupportSystem", "Run", "Void", new List<string>() { "Double" });
                if (ans1 && ans2 && ans3 && ansHuman && ansWaste && ansFood && ansOxygen)
                {
                    // logic tests for LifeSupportSystem are put here
                    object instance = null;
                    object oxygen = null;
                    object food = null;
                    object waste = null;
                    Type type = Type.GetType(nms + ".LifeSupportSystem");
                    try
                    {
                        waste = Type.GetType(nms + ".Waste").GetConstructor(Type.EmptyTypes).Invoke(new object[] { });
                        oxygen = Type.GetType(nms + ".OxygenBottle").GetConstructors().First().Invoke(new object[] { 100.0 });
                        food = Type.GetType(nms + ".FoodContainer").GetConstructors().First().Invoke(new object[] { 100.0 });
                        var crewman = Type.GetType(nms + ".Crewman").GetConstructors().First().Invoke(new object[] { });
                        var listH = (IList)Activator.CreateInstance(typeof(List<>).MakeGenericType(Type.GetType(nms + ".Human")));
                        var listO = (IList)Activator.CreateInstance(typeof(List<>).MakeGenericType(Type.GetType(nms + ".OxygenBottle")));
                        listH.Add(crewman);
                        listO.Add(oxygen);
                        var constructor = Type.GetType(nms + ".LifeSupportSystem").GetConstructors().First();
                        instance = constructor.Invoke(new object[] { listO, food, waste, listH });
                        if (instance != null && oxygen!= null && food != null)
                        {
                            // can we travel with zero oxygen?
                            testNumber++;
                            (Type.GetType(nms + ".OxygenBottle")).GetProperty("Volume").SetValue(oxygen, 0.0);
                            var method = type.GetMethod("CheckSuppliesBeforeTravel");
                            if ((bool)method.Invoke(instance, new object[] { 1.0 }))
                            {
                                failed++;
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Test " + testNumber + " failed: CheckSuppliesBeforeTravel returned true despite no oxygen.");
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Test " + testNumber + " passed: CheckSuppliesBeforeTravel returned false for no oxygen.");
                            }
                            // can we travel with zero food?
                            testNumber++;
                            (Type.GetType(nms + ".OxygenBottle")).GetProperty("Volume").SetValue(oxygen, 100.0);
                            (Type.GetType(nms + ".FoodContainer")).GetProperty("Volume").SetValue(food, 0.0);
                            method = type.GetMethod("CheckSuppliesBeforeTravel");
                            if ((bool)method.Invoke(instance, new object[] { 1.0 }))
                            {
                                failed++;
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Test " + testNumber + " failed: CheckSuppliesBeforeTravel returned true despite no food.");
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Test " + testNumber + " passed: CheckSuppliesBeforeTravel returned false for no food.");
                            }
                            // are food, oxygen and waste values updated during travel?
                            testNumber++;
                            (Type.GetType(nms + ".OxygenBottle")).GetProperty("Volume").SetValue(oxygen, 100.0);
                            (Type.GetType(nms + ".FoodContainer")).GetProperty("Volume").SetValue(food, 100.0);
                            (Type.GetType(nms + ".Waste")).GetProperty("Volume").SetValue(waste, 0.0);
                            (type.GetMethod("Run")).Invoke(instance, new object[] { 0.1 });
                            if ((double)(Type.GetType(nms + ".OxygenBottle")).GetProperty("Volume").GetValue(oxygen) < 100.0
                                && (double)(Type.GetType(nms + ".FoodContainer")).GetProperty("Volume").GetValue(food) < 100.0
                                && (double)(Type.GetType(nms + ".Waste")).GetProperty("Volume").GetValue(waste) > 0.0)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Test " + testNumber + " passed: Run method correctly updated oxygen, food and waste values.");
                            }
                            else
                            {
                                failed++;
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Test " + testNumber + " failed: Run method did not decrease oxygen" +
                                    " or did not decrease food or did not increase waste value.");
                            }
                        }
                    }
                    catch (Exception e) when (e is ArgumentException || e is TargetParameterCountException)
                    {
                        testNumber++;
                        failed++;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Test " + testNumber + " failed: wrong order of arguments in LifeSupportSystem constructor. " + e);
                    }
                }
            }
            Console.WriteLine();
            if (failed > 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The submarine is not ready to run: " + failed + " out of " + testNumber + " tests failed.");
                Console.ResetColor();
                Console.WriteLine();
                return false;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("All tests passed! The submarine is ready to run.");
            Console.ResetColor();
            Console.WriteLine();
            return true;
        }
    }
}
