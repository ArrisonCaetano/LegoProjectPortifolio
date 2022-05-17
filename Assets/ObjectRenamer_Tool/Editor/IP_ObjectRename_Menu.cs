using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


namespace Window.Tools
{
    public class IP_ObjectRename_Menu
    {
       
       [MenuItem("Nuped/Level Tools/Renamer Tool %#i")] //%# stands for crtl and shit + keyboard i
       public static void RenameSelectedObjects()
        {
            IP_ObjectRename_Editor.LaunhcRenamer();
        }

       
    }
}