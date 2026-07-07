using System;

namespace C_projectviva.Sections
{
    // Quick console demo so you can test the Sections logic before the WinForms UI exists.
    // To try it: call SectionModuleDemo.Run(); from Program.Main and press F5 / dotnet run.
    public static class SectionModuleDemo
    {
        public static void Run()
        {
            var manager = new SectionManager();

            manager.Add("Upper Field", 12.5m);
            manager.Add("Lower Field", 8.0m);

            Console.WriteLine("All sections:");
            PrintAll(manager);

            manager.Update(1, "Upper Field (North)", 13.0m);
            manager.Delete(2);

            Console.WriteLine();
            Console.WriteLine("After update + delete:");
            PrintAll(manager);

            Console.WriteLine();
            Console.WriteLine("Search 'north':");
            foreach (var s in manager.Search("north"))
                Console.WriteLine("  " + s);
        }

        private static void PrintAll(SectionManager manager)
        {
            foreach (var s in manager.GetAll())
                Console.WriteLine("  " + s);
        }
    }
}
