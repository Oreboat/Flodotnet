using System.Reflection;
using Flecs.NET;
using Flecs.NET.Core;

public partial class RenderModule3D : IFlecsModule
{
public void InitModule(ref World world)
{
   // Module code here
   world.Module<RenderModule3D>();
}
}
