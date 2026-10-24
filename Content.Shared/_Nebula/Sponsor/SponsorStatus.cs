// SPDX-FileCopyrightText: 2026 Lytheriia
//
// SPDX-License-Identifier: AGPL-3.0-or-later

namespace Content.Shared._Nebula.Sponsor;

public sealed class SponsorStatus
{
    public int Rank { get; set; }
    public DateTimeOffset StartedAt { get; set; }

    public int Level => Rank;
}
