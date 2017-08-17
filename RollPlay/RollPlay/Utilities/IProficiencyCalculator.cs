namespace RollPlay.Utilities
{
    public interface IProficiencyCalculator
    {
        int GetProficiencyBonus(int characterLevel, double modifier = 1);
    }
}