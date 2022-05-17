using Google.Protobuf.WellKnownTypes;

namespace AElf.Contracts.FundingContract
{
    /// <summary>
    /// The C# implementation of the contract defined in fund_contract.proto that is located in the "protobuf"
    /// folder.
    /// Notice that it inherits from the protobuf generated code. 
    /// </summary>
    public class FundingContract : FundingContractContainer.FundingContractBase
    {
        /// <summary>
        /// Create a new project and add it to the list
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public override Project CreateProject(CreateProjectInput input)
        {
            // Should not greet to empty string or white space.
            Assert(!string.IsNullOrWhiteSpace(input.Name), "Invalid name.");

            // State.ProjectList.Value is null if not initialized.
            var projectList = State.ProjectList.Value ?? new ProjectList();

            // Add input.Value to State.GreetedList.Value if it's new to this list.
            var project = new Project()
            {
                Id = input.Name.Normalize().Replace(' ', '_'),
                Name = input.Name,
                Description = input.Description,
                Fundgoal = input.Fundgoal,
                Isactive = true
            };

            if (!projectList.Value.Contains(project))
            {
                projectList.Value.Add(project);
            }

            State.ProjectList.Value = projectList;

            return project;
        }

        public override Empty FundProject(FundInput input)
        {
            // State.ProjectList.Value is null if not initialized.
            var fundList = State.FunderList.Value ?? new FunderList();

            if (!fundList.Value.Contains(input))
            {
                fundList.Value.Add(input);
            }

            State.FunderList.Value = fundList;

            return new Empty();
        }

        public override ProjectList GetProjectList(Empty input)
        {
            return State.ProjectList.Value ?? new ProjectList();
        }

        public override FunderList GetFunderList(Empty input)
        {
            return State.FunderList.Value ?? new FunderList();
        }
    }
}