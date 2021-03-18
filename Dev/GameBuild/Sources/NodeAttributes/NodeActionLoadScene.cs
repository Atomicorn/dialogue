using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using DialogueEditor;

namespace DemoBuild
{
    class NodeActionLoadScene : NodeAction
    {
        public string SceneName { get; set; }

        public NodeActionLoadScene()
        {
            SceneName = "DefaultScene";
        }

        public override string GetDisplayText()
        {
            return $"[Load Scene] \"{SceneName}\"";
        }
    }
}
