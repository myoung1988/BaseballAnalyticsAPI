namespace FantasyBaseballAnalyticsAPI.Biz.Interfaces.MLB.LeagueStructure
{
    interface ITeam : IStructureBase
    {
        string City { get; set; }
        string LogoPath { get; set; }

        
    }
}
