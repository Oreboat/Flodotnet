using Godot;
using System;
using System.Diagnostics;
using System.IO;

[Tool]
public partial class FlecsEntity : Node
{
    String dir = Directory.GetCurrentDirectory();
    public override void _Ready()
    {
        GD.Print("ttt");
        GD.Print(dir);
        if(Engine.IsEditorHint())
        {
            if(!Directory.Exists(dir + "/FlodotEntites"))
            {
                Directory.CreateDirectory(dir + "/FlodotEntites");
            }
            String Path = Name;
                if(GetParent().GetType() == typeof(FlecsEntity)){
                    Path = GetParent().Name + "." + Path;
                }
            Godot.Collections.Dictionary data = new Godot.Collections.Dictionary();
            if(!File.Exists(dir + "/FlodotEntites/" + Path + ".json"))//check if json file exists
            {

                data.Add("Path", Path);

                String json = Json.Stringify(data);
                GD.Print(json);
                //check for parents
                //set name based on if a parent exists
            }
            //otherwise load json file
            //check if parent is different name
                //rename parent in json file

        }
        else
        {
            QueueFree();
        }
    }
    public override void _ExitTree()
    {
        if(Engine.IsEditorHint())
        {
            //Delete Json file
        }
    }
}
