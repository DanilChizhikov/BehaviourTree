using System;
using MbsCore.BehaviourTree.Infrastructure;
using MbsCore.BehaviourTree.Runtime;
using UnityEditor;
using UnityEngine;
using XNode;
using XNodeEditor;

namespace MbsCore.BehaviourTree.Editor
{
    [CustomNodeEditor(typeof(BehaviourStateConfig))]
    public abstract class BehaviourStateConfigEditor<TState> : NodeEditor where TState : BehaviourStateConfig
    {
        private const string EnterField = "_enterState";
        
        protected TState State { get; private set; }
        protected BehaviourGraphConfig Graph { get; private set; }
        
        public sealed override void OnBodyGUI()
        {
            State = target as TState;
            if (State == null)
            {
                return;
            }
            
            Graph = State.graph as BehaviourGraphConfig;
            if (Graph == null)
            {
                return;
            }
            
            serializedObject.Update();
            DrawInputPort();
            DrawStartState();
            DrawBodyGUI();
            serializedObject.ApplyModifiedProperties();
        }

        protected abstract void DrawBodyGUI();
        
        protected void DrawPort(GUIContent label, IBehaviourPortConfig port)
        {
            NodePort outputPort = target.GetOutputPort(port.Name);
            NodeEditorGUILayout.PortField(label, outputPort, GUILayout.Width(40));
        }
        
        protected void Horizontal(Action action)
        {
            EditorGUILayout.BeginHorizontal();
            action();
            EditorGUILayout.EndHorizontal();
        }

        protected void Vertical(Action action)
        {
            EditorGUILayout.BeginVertical();
            action();
            EditorGUILayout.EndVertical();
        }

        private void DrawInputPort()
        {
            EditorGUILayout.Space();
            NodeEditorGUILayout.PortField(target.GetInputPort(EnterField), GUILayout.Width(100));
        }
        
        private void DrawStartState()
        {
            bool isStartNode = Graph.EnterState == State;
            GUIStyle style;
            if (isStartNode)
            {
                style = new GUIStyle(EditorStyles.boldLabel)
                        {
                                normal = {textColor = Color.green},
                                fontSize = 15,
                                fixedHeight = 25
                        };

                EditorGUILayout.LabelField("This is Start NODE", style);
            }
            else if (Graph.EnterState == null)
            {
                style = new GUIStyle(EditorStyles.boldLabel)
                        {
                                normal = {textColor = Color.red},
                                fontSize = 15,
                                fixedHeight = 25
                        };

                EditorGUILayout.LabelField("Please select START NODE", style);
            }

            if (!isStartNode)
            {
                if (GUILayout.Button("Set as start"))
                {
                    Graph.SetEnterState(State);
                }   
            }
        }
    }
}