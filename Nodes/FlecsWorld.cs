using Godot;
using System;
using Flecs;
using Flecs.NET.Core;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;

[Tool]
public partial class FlecsWorld : Node
{
    World world1;
    public override void _Ready()
    {
        world1.Import<RenderModule3D>();
        return;
        using World world = World.Create();

        // Grab all module types
        IEnumerable<Type> derivedTypes = Assembly.GetExecutingAssembly()
        .GetTypes()
        .Where(type => typeof(IFlecsModule).IsAssignableFrom(type));

        foreach (Type type in derivedTypes)
        {
            // Get import function for module.
            MethodInfo import = typeof(World)
            .GetMethod(nameof(World.Import))!
            .MakeGenericMethod(type);

            // Import module.
            import.Invoke(world, null);
        }
    }

    public override void _Process(double delta)
    {
        
        world1.Progress((float)delta);
    }
}
