using Godot;
using System;
using Flecs;
namespace Flodot{
namespace Component3D{

namespace MeshRenderer
{
    public struct mesh{public Rid rid;}
    public struct material{public Material mat;}
    
}
namespace Transform3D
{
    public struct position3D {public float x;public float y;public float z;}
    public struct rotation3D {public float x;public float y;public float z;}
    public struct scale3D {public float x;public float y; public float z;} 
}
}
}


