using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using DialogueEditor;

namespace DemoBuild
{
    abstract class NodeActionItemStack : NodeAction
    {
        //--------------------------------------------------------------------------------------------------------------
        // Serialized vars

        public string Item { get; set; }
        public int Amount { get; set; }

        //--------------------------------------------------------------------------------------------------------------
        // Class Methods

        public NodeActionItemStack()
        {
            Amount = 1;
            Item = "DefaultItem";
        }
    }
}
