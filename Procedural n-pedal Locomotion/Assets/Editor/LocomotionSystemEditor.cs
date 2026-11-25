/* 
 * This file is part of the Procedural-Locomotion repo on github.com/ZykeDev 
 * Marco Vincenzi - 2021
 */

using UnityEngine;
using UnityEditor;

// Editor class to include the Setup and Weight buttons into the Locomotion System component.

[CustomEditor(typeof(LocomotionSystem))]
public class LocomotionSystemEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        LocomotionSystem locomotionSystem = (LocomotionSystem)target;

        GUILayout.Space(10);
        EditorGUILayout.LabelField("Setup", EditorStyles.boldLabel);

        // ---------------------------------------------------
        GUILayout.BeginHorizontal();

        if (GUILayout.Button(new GUIContent("Setup Model", "Setups the model so that it can be used by the Procedural Locomotion system.")))
        {
            locomotionSystem.SetupModel();
        }

        if (GUILayout.Button(new GUIContent("Setup Radial 5-Leg", "Auto-detects Body and Leg_0..4_Hip bones, sets Radial gait mode, and runs SetupModel.")))
        {
            locomotionSystem.AutoSetupRadialModel();
        }

        if (GUILayout.Button(new GUIContent("Reset Model", "Resets the model and removes the modules added by the Procedural Locomotion system.")))
        {
            locomotionSystem.ResetModel();
        }

        
        GUILayout.EndHorizontal();
        // ---------------------------------------------------

        GUILayout.Space(10);
        EditorGUILayout.LabelField("Weights", EditorStyles.boldLabel);

        // ---------------------------------------------------
        GUILayout.BeginHorizontal();

        if (GUILayout.Button(new GUIContent("Generate Weights", "Adds a Weight component to the Character's body and each of its limbs.")))
        {
            locomotionSystem.GenerateWeights();
        }

        if (GUILayout.Button(new GUIContent("Remove Weights", "Removes the Weight component from the Character's body and each of its limbs.")))
        {
            locomotionSystem.RemoveWeights();
        }

        GUILayout.EndHorizontal();
        // ---------------------------------------------------

    }
}
