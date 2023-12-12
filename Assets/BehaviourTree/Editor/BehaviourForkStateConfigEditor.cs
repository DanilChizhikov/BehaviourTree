using System.Collections.Generic;
using MbsCore.BehaviourTree.Runtime;
using UnityEditor;
using UnityEditor.MemoryProfiler;
using UnityEngine;
using XNode;
using XNodeEditor;

namespace MbsCore.BehaviourTree.Editor
{
    [CustomNodeEditor(typeof(BehaviourForkStateConfig))]
    public class BehaviourForkStateConfigEditor : BehaviourStateConfigEditor<BehaviourForkStateConfig>
    {
        private const string ForksField = "_forks";
        private const string DecisionsField = "_decisions";
        
        protected override void DrawBodyGUI()
        {
            var forks = new List<BehaviourForkConfig>(State.ForkInfos);
            EditorGUILayout.Space();
            GUIStyle style = new GUIStyle(EditorStyles.boldLabel);
            EditorGUILayout.LabelField("Ports:", style);
            int forksCount = forks.Count;
            SerializedProperty forksProperty = serializedObject.FindProperty(ForksField);
            for (int i = 0; i < forksCount; i++)
            {
                BehaviourForkConfig fork = forks[i];
                Vertical(() =>
                {
                    Horizontal(() =>
                    {
                        if (GUILayout.Button("-", GUILayout.Width(30)))
                        {
                            if (State.HasPort(fork.Port.Name))
                            {
                                State.RemoveDynamicPort(fork.Port.Name);
                                forks.RemoveAt(i);
                                i--;
                                forksCount--;
                            }
                        }
                    });
            
                    Horizontal(() =>
                    {
                        EditorGUILayout.Space();
                        Vertical(() =>
                        {
                            int weight = EditorGUILayout.IntField("Weight", fork.Weight);
                            if (fork.Weight != weight)
                            {
                                forks[i] = fork.CloneDecisions(fork.Port as BehaviourPortConfig, fork.Weight);
                            }
                        
                            Horizontal(() =>
                            {
                                EditorGUILayout.Space();
                                var style = new GUIStyle(EditorStyles.boldLabel);
                                EditorGUILayout.LabelField("Decisions:", style);
                                SerializedProperty forkProperty = forksProperty.GetArrayElementAtIndex(i);
                                SerializedProperty decisionsProperty = forkProperty.FindPropertyRelative(DecisionsField);
                                NodeEditorGUILayout.PropertyField(decisionsProperty);
                            });
                            Horizontal(() => DrawPort(new GUIContent("Port"), fork.Port)); 
                        });
                    }); 
                });
            }
            
            Horizontal(() =>
            {
                if (GUILayout.Button("+", GUILayout.Width(30)))
                {
                    NodePort newport = Node.AddDynamicOutput(typeof(Connection), XNode.Node.ConnectionType.Override);
                    var port = new BehaviourPortConfig(newport.fieldName, null);
                    forks.Add(new BehaviourForkConfig(port, 0));
                }
            });
            
            State.SetForks(forks.ToArray());
        }
    }
}