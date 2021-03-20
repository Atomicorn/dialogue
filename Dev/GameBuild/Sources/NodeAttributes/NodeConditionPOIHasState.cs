using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using DialogueEditor;

namespace GameBuild
{
    class NodeConditionPOIHasState : NodeCondition
    {
        //--------------------------------------------------------------------------------------------------------------
        // Serialized vars
        public string POIName { get; set; }
        public POIState TargetedState { get; set; }

        //--------------------------------------------------------------------------------------------------------------
        // Class Methods

        public NodeConditionPOIHasState()
        {
            TargetedState = POIState.Hidden;
            POIName = "DefaultPOIName";
        }

        protected override string GetDisplayText_Impl()
        {
            return $"[POI Has State] {{ \"{ POIName }\" : { TargetedState } }}";
        }
    }
}
