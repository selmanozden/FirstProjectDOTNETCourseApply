namespace courseapply.Models
{
    public static class ListModel
    {
        private static List<VariableModel> _programs = new List<VariableModel>();
        public static IEnumerable<VariableModel> Program => _programs;
        public static void Add(VariableModel model)
        {
            _programs.Add(model);
        }
    }
}
