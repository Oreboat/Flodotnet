#if TOOLS
using Godot;
using System;

[Tool]
public partial class plugin : EditorPlugin
{
	public override void _EnterTree()
	{
		AddCustomType("FlecsWorld","Node",GD.Load<Script>("res://addons/flodotnet/Nodes/FlecsWorld.cs"), GD.Load<Texture2D>("res://icon.svg"));
	}

	public override void _ExitTree()
	{
		RemoveCustomType("FlecsWorld");
	}
}
#endif
