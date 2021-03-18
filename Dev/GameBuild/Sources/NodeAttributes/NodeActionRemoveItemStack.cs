using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using DialogueEditor;

namespace DemoBuild
{
    class NodeActionRemoveItemStack : NodeActionItemStack
    {
        public override string GetDisplayText()
        {
            return $"[Remove ItemStack] {{ \"{ Item }\" : { Amount } }}";
        }
    }
}
