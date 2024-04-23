using System.Reflection;
using Flecs.NET;
using Flecs.NET.Core;

public partial class RenderModule3D : IFlecsModule
{
    protected World World;
public void InitModule(ref World world)
{
    World = world;
   // Module code here
   world.Module<RenderModule3D>();
   world.Routine<MeshSys>();
   Routine<MeshSys>();

}
protected void Routine<T>()
{
    World.Routine<T>();
}
}
