﻿using System;
using UtilitySystems.XmlDatabase.Editor;

namespace RPGSystems.StatSystem.Editor {
    public class RPGStatModifierEditorExtension : EditorExtension {
        public override bool CanHandleType(Type type) {
            return typeof(RPGVitalAsset).IsAssignableFrom(type);
        }

        public override void OnGUI(object asset) {
            
        }
    }
}
