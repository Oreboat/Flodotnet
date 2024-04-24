using Godot;
using System;
using Flecs;
enum CameraMode{PERSPECTIVE, ORTHOGRAPHIC}
namespace Flodot{
namespace Component3D{

namespace MeshRenderer
{
    public struct meshComponent{public Mesh mesh;public Rid instance;}
    public struct material{public Material mat;}
}
namespace Transform3D
{
    public struct position3D {public float x;public float y;public float z;}
    public struct rotation3D {public float x;public float y;public float z;}
    public struct scale3D {public float x;public float y; public float z;} 
    
}
namespace Camera3D{

}
}
}



