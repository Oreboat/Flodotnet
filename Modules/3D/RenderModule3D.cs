using System.Reflection;
using Flecs.NET;
using Flecs.NET.Core;
using Godot;
using Flodot;
using Flodot.Transform3D;

public partial class RenderModule3D : IFlecsModule
{
    protected World World;
public void InitModule(ref World world)
{
    World = world;
   // Module code here
   world.Module<RenderModule3D>();
   world.Routine<position3D>().Each((Entity e, ref position3D p)=> {

  });
{

};

}
protected void Routine<T>(Ecs.EachCallback<T> callback)
{
    World.Routine<T>().Each(callback);
}
}

