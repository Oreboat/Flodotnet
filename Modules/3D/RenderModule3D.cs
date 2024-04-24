using System.Reflection;
using Flecs.NET;
using Flecs.NET.Core;
using Godot;
using Flodot;
using Flodot.Component3D.Transform3D;
using Flodot.Component3D.MeshRenderer;

public partial class RenderModule3D : IFlecsModule
{
    protected World World;
public void InitModule(ref World world)
{
    World = world;
    // Module code here
    world.Module<RenderModule3D>();
    world.Routine().With<position3D>().With<meshComponent>().With<rotation3D>().With<scale3D>().Each(( ref position3D p, ref meshComponent m, ref rotation3D r, ref scale3D s) => {
        Rid instance = RenderingServer.InstanceCreate();
        RenderingServer.InstanceSetBase(instance, m.mesh.GetRid());
        World3D world3d =(((SceneTree)Godot.Engine.GetMainLoop()).Root.World3D);
        Transform3D transform = new Transform3D(Basis.Identity, Vector3.Zero);

        RenderingServer.InstanceSetScenario(instance, world3d.Scenario);
        
  });
{

};

}
protected void Routine<T>(Ecs.EachCallback<T> callback)
{
    World.Routine<T>().Each(callback);
}
}

