using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using DialogueEditor;

namespace GameBuild
{
    class NodeConditionHasItemStack : NodeCondition
    {
        //--------------------------------------------------------------------------------------------------------------
        // Serialized vars

        public string Item { get; set; }
        public int Amount { get; set; }

        //--------------------------------------------------------------------------------------------------------------
        // Class Methods

        public NodeConditionHasItemStack()
        {
            Amount = 1;
            Item = "DefaultItem";
        }

        protected override string GetDisplayText_Impl()
        {
            return $"[Has ItemStack] {{ \"{ Item }\" : { Amount } }}";
        }
    }
}
