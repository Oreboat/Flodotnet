using Godot;
using System;
using Flecs;
using Flecs.NET.Core;

public partial class FlecsWorld : Node
{
    public World World;

    public override void _Ready()
    {
        World = World.Create();
        World.Import<RenderModule3D>();
    }

    public override void _Process(double delta)
    {
        World.Progress((float)delta);
    }

    protected void register(Script module)
    {
        //World.Import<module>();
    }
}
