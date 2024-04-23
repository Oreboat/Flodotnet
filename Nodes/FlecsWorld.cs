using Godot;
using System;
using Flecs;
using Flecs.NET.Core;
[Tool]
public partial class FlecsWorld : Node
{
    public World World;

    public override void _Ready()
    {
        if(((SceneTree) Engine.GetMainLoop()).Root != this as Node)
        {
            
        }
        World = World.Create();
        World.Import<RenderModule3D>();
    }

    public override void _Process(double delta)
    {
        World.Progress((float)delta);
    }

    protected void Import<T>() where T : IFlecsModule, new()
    {
        World.Import<T>();
    }
}
