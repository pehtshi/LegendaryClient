using System;

namespace PVPNetConnect.RiotObjects.Platform.Summoner
{
    public class SummonerLevelAndPoints : RiotGamesObject
    {
        public override string TypeName
        {
            get { return this.type; }
        }

        private string type = "com.riotgames.platform.summoner.SummonerLevelAndPoints";

        public SummonerLevelAndPoints()
        {
        }

        public SummonerLevelAndPoints(Callback callback)
        {
            this.callback = callback;
        }

        public SummonerLevelAndPoints(TypedObject result)
        {
            base.SetFields(this, result);
        }

        public delegate void Callback(SummonerLevelAndPoints result);

        private Callback callback;

        public override void DoCallback(TypedObject result)
        {
            base.SetFields(this, result);
            callback(this);
        }

        [InternalName("infPoints")]
        public double InfPoints { get; set; }

        [InternalName("expPoints")]
        public double ExpPoints { get; set; }

        [InternalName("summonerLevel")]
        public double SummonerLevel { get; set; }

        [InternalName("summonerId")]
        public double SummonerId { get; set; }
    }
}