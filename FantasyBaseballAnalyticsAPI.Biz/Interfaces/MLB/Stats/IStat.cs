using FantasyBaseballAnalyticsAPI.Biz.Enumerators;

namespace FantasyBaseballAnalyticsAPI.Biz.Interfaces.MLB.Stats
{
    interface IStat
    {
        int StatID { get; }
        string Name { get; }
        object Value { get; set; }
        eEvaluation Eval { get; }

        bool Compare(object val1, object val2);
    }
}
