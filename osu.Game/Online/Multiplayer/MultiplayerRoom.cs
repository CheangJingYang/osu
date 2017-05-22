﻿// Copyright (c) 2007-2017 ppy Pty Ltd <contact@ppy.sh>.
// Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu/master/LICENCE

using System.ComponentModel;
using osu.Game.Database;
using osu.Game.Users;

namespace osu.Game.Online.Multiplayer
{
    public class MultiplayerRoom
    {
        public string Name { get; set; }
        public User Host { get; set; }
        public MultiplayerRoomStatus Status { get; set; }
        public BeatmapMetadata CurrentBeatmap { get; set; }
    }

    public enum MultiplayerRoomStatus
    {
        [Description(@"Welcoming Players")]
        Open,

        [Description(@"Now Playing")]
        Playing,
    }
}
