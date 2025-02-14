﻿using Bliss.Component.Sprites.Office;
using Bliss.Models;
using System.Collections.Generic;

namespace Bliss.States.Summary
{
    public partial class SummaryState : State
    {
        public static string Name = "Summary";

        PlayerStats PlayerStats { get; set; }
        Dictionary<OrganizerIds, List<Rule>> Rules { get; set; }

        protected override void OnLoad(params object[] parameter)
        {
            PlayerStats = (PlayerStats)parameter[0];
            Rules = (Dictionary<OrganizerIds, List<Rule>>)parameter[1];

            if (PlayerStats.WronglyEndedCalls >= 1) PlayerStats.Warnings++;
            if (PlayerStats.WronglySortedDocuments >= 3) PlayerStats.Warnings++;
            if (PlayerStats.MissedCalls >= 1) PlayerStats.Warnings++;
            if (PlayerStats.DocumentsLeft >= 3) PlayerStats.Warnings++;

            AudioManager.ChangeSong(ContentManager.UpbeatSong, true);
        }
    }
}
