namespace Bubble_Wrap_Bandits_Strike_Back
{
    public class LockSpecialist : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }

        public void PerformSkill(Bank bank)
        {
            bank.VaultScore -= this.SkillLevel;
        }
    }
}