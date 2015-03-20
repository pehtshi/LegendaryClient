using System;
using System.Collections.Generic;

namespace PVPNetConnect.RiotObjects.Platform.Summoner.Spellbook
{
    public class SpellBookPageDTO : RiotGamesObject
    {
        public override string TypeName
        {
            get { return this.type; }
        }

        private string type = "com.riotgames.platform.summoner.spellbook.SpellBookPageDTO";

        public SpellBookPageDTO()
        {
        }

        public SpellBookPageDTO(Callback callback)
        {
            this.callback = callback;
        }

        public SpellBookPageDTO(TypedObject result)
        {
            base.SetFields(this, result);
        }

        public delegate void Callback(SpellBookPageDTO result);

        private Callback callback;

        public override void DoCallback(TypedObject result)
        {
            base.SetFields(this, result);
            callback(this);
        }

        [InternalName("slotEntries")]
        public List<SlotEntry> SlotEntries { get; set; }

        [InternalName("summonerId")]
        public int SummonerId { get; set; }

        [InternalName("createDate")]
        public DateTime CreateDate { get; set; }

        [InternalName("name")]
        public string Name { get; set; }

        [InternalName("pageId")]
        public int PageId { get; set; }

        [InternalName("current")]
        public bool Current { get; set; }
    }
}