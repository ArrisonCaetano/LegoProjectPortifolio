using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEditor;
namespace Window.Tools
{
    public class IP_ObjectRename_Editor : EditorWindow
    {
        #region Variables
        GameObject[] selected = new GameObject[0];
        string wantedPrefix;
        string wantedName;
        string wantedSuffix;
        bool addNumbering;

        #endregion


        #region Builtin Methods
        public static void LaunhcRenamer()
        {
            Debug.Log("We launched the Renamer Window");
            var win = GetWindow<IP_ObjectRename_Editor>();// create a var for storing the win 
            GUIContent content = new GUIContent("Rename Objects"); // rrequire for a GUI content
            win.titleContent = content;
            win.Show();
        }

        private void OnGUI()
        {
            //Get current selected objects
            selected = Selection.gameObjects;
            EditorGUILayout.LabelField("Selected" + selected.Length.ToString("000 "));

            //Display our User UI 
            EditorGUILayout.BeginHorizontal();
            GUILayout.Space(10);

            EditorGUILayout.BeginVertical();
            GUILayout.Space(10);

            EditorGUILayout.BeginVertical(EditorStyles.helpBox);
            GUILayout.Space(10);
            wantedPrefix = EditorGUILayout.TextField("Prefix: ",wantedPrefix,EditorStyles.miniTextField,GUILayout.ExpandWidth(true));
            wantedName = EditorGUILayout.TextField("Name ", wantedName, EditorStyles.miniTextField, GUILayout.ExpandWidth(true));
            wantedSuffix = EditorGUILayout.TextField("Suffix: ", wantedSuffix, EditorStyles.miniTextField, GUILayout.ExpandWidth(true));
            addNumbering = EditorGUILayout.Toggle("Add Numbering?", addNumbering);
            GUILayout.Space(10);
            EditorGUILayout.EndVertical();

            
            if (GUILayout.Button("Rename Selected Objects",GUILayout.Height(45),GUILayout.ExpandWidth(true)))
            {
                RenameObjects();
            }
            GUILayout.Space(10);
            EditorGUILayout.EndVertical();

            GUILayout.Space(10);
            EditorGUILayout.EndHorizontal();



            Repaint();// update de UI all the time 
        }
        #endregion

        #region Custom Methods
        
        void RenameObjects()
        {

            Array.Sort(selected, delegate (GameObject objA, GameObject objB) { return objA.name.CompareTo(objB.name); }); // sorting array in a correct order 

            for (int i = 0; i < selected.Length; i++)
            {
                string finalName = string.Empty;
                if (wantedPrefix.Length > 0) // checking if anything was typed in the wantedprefix
                {
                    finalName += wantedPrefix;
                }
                if(wantedName.Length > 0)
                {
                    finalName += "_"+ wantedName;
                }
                if(wantedSuffix.Length > 0)
                {
                    finalName += "_" + wantedSuffix;
                }
                if(addNumbering)
                {
                    finalName += "_" + i.ToString("000");
                }

                selected[i].name = finalName;
            }
        }





        #endregion

    }
}