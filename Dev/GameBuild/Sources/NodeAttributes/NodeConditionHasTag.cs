using DialogueEditor;

namespace GameBuild
{
    class NodeConditionHasTag : NodeCondition
    {
        //--------------------------------------------------------------------------------------------------------------
        // Serialized vars
        public string Tag { get; set; }

        //--------------------------------------------------------------------------------------------------------------
        // Class Methods

        public NodeConditionHasTag()
        {
            Tag = "DefaultTag";
        }

        protected override string GetDisplayText_Impl()
        {
            return $"[Has Tag] \"{Tag}\"";
        }
    }
}
