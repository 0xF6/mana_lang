namespace ishtar;

using System.Diagnostics;
using vein.runtime;
using static vein.runtime.MethodFlags;
public static unsafe class X_Utils
{
    [IshtarExport(0, "vein::ishtar::graph::bump")]
    [IshtarExportFlags(Public | Static)]
    public static IshtarObject* BumpModulesTypes(CallFrame current, IshtarObject** args)
    {
        foreach (var module in AppVault.CurrentVault.Modules)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"#module '{module.Name}'\n");
            Console.ForegroundColor = ConsoleColor.Gray;

            foreach (var @class in module.class_table)
                Console.WriteLine($"\t#class '{@class.FullName.NameWithNS}'");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }
        Console.ForegroundColor = ConsoleColor.White;
        return null;
    }

    [IshtarExport(0, "vein::ishtar::debugger::break")]
    [IshtarExportFlags(Public | Static)]
    public static IshtarObject* DebuggerBreak(CallFrame current, IshtarObject** _)
    {
        if (Debugger.IsAttached)
            Debugger.Break();
        return null;
    }

    public static void InitTable(Dictionary<string, RuntimeIshtarMethod> table)
    {
        new RuntimeIshtarMethod("vein::ishtar::graph::bump", Public | Static | Extern)
            .AsNative((delegate*<CallFrame, IshtarObject**, IshtarObject*>)&BumpModulesTypes)
            .AddInto(table, x => x.Name);
        new RuntimeIshtarMethod("vein::ishtar::debugger::break", Public | Static | Extern)
            .AsNative((delegate*<CallFrame, IshtarObject**, IshtarObject*>)&DebuggerBreak)
            .AddInto(table, x => x.Name);
    }
}