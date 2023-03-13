//using UnityEngine;
//using System.Collections;
//using System;
//using UnityEditor;

// public class CopyComponents : MonoBehaviour
// {
//    public GameObject sourceObject;
//    public GameObject targetObject;
//
//void Start()
//{
// Get all the components from the source object
//Component[] components = sourceObject.GetComponents<Component>();

// Copy the components to the target object
//foreach (Component component in components)
//{
// Skip Transform and GameObject components
//    if (!(component is Transform) && !(component is GameObject))
//{
// Copy the component to the target object
//UnityEditorInternal.ComponentUtility.CopyComponent(component);
//UnityEditorInternal.ComponentUtility.PasteComponentAsNew(targetObject);
//            }
//        }
//    }
//}