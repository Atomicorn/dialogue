using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using DialogueEditor;

namespace DemoBuild
{
    class NodeActionAddItemStack : NodeActionItemStack
    {
        public override string GetDisplayText()
        {
            return $"[Add ItemStack] {{ \"{ Item }\" : { Amount } }}";
        }
    }
}
