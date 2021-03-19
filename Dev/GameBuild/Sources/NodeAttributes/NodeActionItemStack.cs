using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using DialogueEditor;

namespace GameBuild
{
    class NodeActionItemStack : NodeAction
    {
        //--------------------------------------------------------------------------------------------------------------
        // Serialized vars

        public string Item { get; set; }
        public int Amount { get; set; }
        public QuantifiableActionType Action { get; set; }

        //--------------------------------------------------------------------------------------------------------------
        // Class Methods

        public NodeActionItemStack()
        {
            Amount = 1;
            Item = "DefaultItem";
        }

        public sealed override string GetDisplayText()
        {
            return $"[{Action} ItemStack] {{ \"{ Item }\" : { Amount } }}";
        }
    }
}
