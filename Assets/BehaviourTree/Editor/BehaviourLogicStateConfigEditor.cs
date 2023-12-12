using System;
using System.Collections.Generic;
using MbsCore.BehaviourTree.Infrastructure;
using MbsCore.BehaviourTree.Runtime;
using UnityEditor;
using UnityEditor.MemoryProfiler;
using UnityEngine;
using XNode;
using XNodeEditor;

namespace MbsCore.BehaviourTree.Editor
{
    [CustomNodeEditor(typeof(BehaviourLogicStateConfig))]
    public class BehaviourLogicStateConfigEditor : BehaviourStateConfigEditor<BehaviourLogicStateConfig>
    {
        private const string ActionsField = "_actions";
        private const string TransitionField = "_transitions";
        private const string DecisionsField = "_decision";
        
        protected override void DrawBodyGUI()
        {
            DrawActionsList();
            DrawDecisionsList(); 
        }
        
        protected void DrawDecisionsList()
        {
            EditorGUILayout.Space();
            GUIStyle style = new GUIStyle(EditorStyles.boldLabel);
            EditorGUILayout.LabelField("Decisions:", style);
            EditorGUILayout.Space();
            IReadOnlyList<BehaviourTransitionConfig> transitionConfigs = State.EditorTransitionConfigs;
            if (transitionConfigs != null)
            {
                for (int i = 0; i < transitionConfigs.Count; i++)
                {
                    BehaviourTransitionConfig nodeTransition = transitionConfigs[i];
                    Horizontal(() =>
                    {
                        Vertical(() =>
                        {
                            if (GUILayout.Button("-", GUILayout.Width(30)))
                            {
                                List<BehaviourTransitionConfig> vector = new (transitionConfigs);
                                if (State.HasPort(nodeTransition.TruePort.Name))
                                {
                                    State.RemoveDynamicPort(nodeTransition.TruePort.Name);
                                }

                                if (State.HasPort(nodeTransition.FalsePort.Name))
                                {
                                    State.RemoveDynamicPort(nodeTransition.FalsePort.Name);
                                }

                                vector.RemoveAt(i);
                                
                                State.SetTransitions(vector.ToArray());
                                serializedObject.ApplyModifiedProperties();
                                transitionConfigs = State.EditorTransitionConfigs;
                            }

                            if (i > 0 && GUILayout.Button("↑", GUILayout.Width(30)))
                            {
                                BehaviourTransitionConfig selectedElement = transitionConfigs[i];
                                State.SetTransitionByIndex(i, transitionConfigs[i - 1]);
                                State.SetTransitionByIndex(i - 1, selectedElement);
                                serializedObject.ApplyModifiedProperties();
                            }
                            
                            if (i < (transitionConfigs.Count -1) && GUILayout.Button("↓", GUILayout.Width(30)))
                            {
                                BehaviourTransitionConfig selectedElement = transitionConfigs[i];
                                State.SetTransitionByIndex(i, transitionConfigs[i + 1]);
                                State.SetTransitionByIndex(i + 1, selectedElement);
                                serializedObject.ApplyModifiedProperties();
                            }
                        });
                        
                        SerializedProperty transitionsProperty = serializedObject.FindProperty(TransitionField);
                        SerializedProperty transitionProperty = transitionsProperty.GetArrayElementAtIndex(i);
                        SerializedProperty decisionsProperty = transitionProperty.FindPropertyRelative(DecisionsField);
                        NodeEditorGUILayout.PropertyField(decisionsProperty);
                    });

                    style = new GUIStyle(EditorStyles.boldLabel)
                    {
                        normal = {textColor = Color.yellow}
                    };

                    Horizontal(() =>
                    {
                        EditorGUILayout.Space();
                        DrawTargetLabel(nodeTransition.TruePort, style);
                        DrawPort(new GUIContent("TRUE"), nodeTransition.TruePort);
                    });
                    
                    EditorGUILayout.Space();
                    
                    Horizontal(() =>
                    {
                        EditorGUILayout.Space();
                        DrawTargetLabel(nodeTransition.FalsePort, style);
                        DrawPort(new GUIContent("FALSE"), nodeTransition.FalsePort);
                    });
                    
                    EditorGUILayout.Space();
                }
            }

            EditorGUILayout.Space();
            
            Horizontal(() =>
            {
                EditorGUILayout.Space();
                
                if (GUILayout.Button("+", GUILayout.Width(30)))
                {
                    if (transitionConfigs == null)
                    {
                        State.SetTransitions(Array.Empty<BehaviourTransitionConfig>());
                    }
                    
                    List<BehaviourTransitionConfig> vector = new (transitionConfigs);
                    NodePort newport = State.AddDynamicOutput(typeof(Connection), Node.ConnectionType.Override);
                    var truePort = new BehaviourPortConfig(newport.fieldName, null);
                    newport = State.AddDynamicOutput(typeof(Connection), Node.ConnectionType.Override);
                    var falsePort = new BehaviourPortConfig(newport.fieldName, null);
                    State.SetTransitions(vector.ToArray());
                    var trans = new BehaviourTransitionConfig(truePort, falsePort, Array.Empty<BehaviourDecisionConfig>());
                    vector.Add(trans);
                    serializedObject.ApplyModifiedProperties();
                }
            });
        }

        protected void DrawActionsList()
        {
            EditorGUILayout.Space();
            NodeEditorGUILayout.PropertyField(serializedObject.FindProperty(ActionsField));
        }

        private void DrawTargetLabel(IBehaviourPortConfig port, GUIStyle style)
        {
            string targetStateLabel = "RemainInState";
            if (port.NextState != null && port.NextState is BehaviourStateConfig stateConfig)
            {
                targetStateLabel = stateConfig.name;
            }
            
            EditorGUILayout.LabelField(targetStateLabel, style);
        }
    }
}