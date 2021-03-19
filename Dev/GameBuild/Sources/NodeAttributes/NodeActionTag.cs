using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using DialogueEditor;

namespace GameBuild
{
    class NodeActionTag : NodeAction
    {
        public string Tag { get; set; }
        public QuantifiableActionType Action { get; set; }

        public NodeActionTag (){
            Tag = "DefaultTag";
        }

        public override string GetDisplayText()
        {
            return $"[{Action} Tag] \"{ Tag }\"";
        }
    }
}
